using System.Runtime.InteropServices;
using System.Text;


namespace ShortcutCreator
{
    public partial class frmKeyRecorder : Form
    {
        public static string ShortcutKeySet = "";

        [DllImport("user32.dll")]
        private static extern int GetKeyNameText(int lParam, StringBuilder lpString, int nSize);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        private const uint MAPVK_VK_TO_VSC = 0x0;
        // Using a simple in-place array to record key presses
        private Keys[] recordedKeys = { Keys.None, Keys.None };
        private string recordedKeyFriendlyName = Keys.None.ToString();
        private int recordingSeconds = 0;
        private int resultsSeconds = 0;

        public frmKeyRecorder()
        {
            InitializeComponent();
        }

        private void frmKeyRecorder_Load(object sender, EventArgs e)
        {
            // Reset keys on load (in case they have values from a previous run)
            recordedKeys[0] = Keys.None;
            recordedKeys[1] = Keys.None;
            tmrRecord.Start();
        }

        private void frmKeyRecorder_FormClosing(object sender, FormClosingEventArgs e)
        {
            recordingSeconds = 0;
            resultsSeconds = 0;
            lblSequence.Text = "Enter key sequence";
        }

        private void frmKeyRecorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (!tmrRecord.Enabled)
            {
                return;
            }

            if (e.KeyCode == Keys.ShiftKey)
            {
                recordedKeys[0] = Keys.ShiftKey;
            }
            else if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.Menu)
            {
                recordedKeys[0] = Keys.Alt;
            }
            else
            {
                // Control is always present when entering in a shortcut key sequence
                if (e.KeyCode != Keys.ControlKey)
                {
                    recordedKeys[1] = e.KeyCode;
                    recordedKeyFriendlyName = getKeyFriendlyName(recordedKeys[1]);
                }
            }
        }

        private void tmrRecord_Tick(object sender, EventArgs e)
        {
            if (recordingSeconds == 5)
            {
                recordingSeconds = 0;
                tmrRecord.Stop();
                tmrResult.Start();
                lblSequence.Text = "Sequence: " + getRecordedSequence();
                this.Text = "Result key sequence";
            }
            else
            {
                recordingSeconds++;
            }
        }

        private string getRecordedSequence()
        {
            // If a main key was not pressed (Ctrl, Alt/Shift are filled in by default)
            if (recordedKeys[1] == Keys.None)
            {
                return "N/A";
            }

            StringBuilder sb = new StringBuilder("Ctrl+");
            if (recordedKeys[0] == Keys.ShiftKey)
            {
                sb.Append("Shift+");
            }
            else
            {
                sb.Append("Alt+");
            }

            sb.Append(recordedKeyFriendlyName);
            ShortcutKeySet = sb.ToString();
            return ShortcutKeySet;
        }

        private void tmrResult_Tick(object sender, EventArgs e)
        {
            if (resultsSeconds == 3)
            {
                tmrResult.Stop();
                Close();
            }
            else
            {
                resultsSeconds++;
            }
        }

        private string getKeyFriendlyName(Keys key)
        {
            uint scanCode = MapVirtualKey((uint)key, MAPVK_VK_TO_VSC);
            int lParam = (int)(scanCode << 16);
            StringBuilder sb = new StringBuilder(64);
            int result = GetKeyNameText(lParam, sb, sb.Capacity);

            if (result > 0)
            {
                return sb.ToString();
            }

            // Just in case there is no user friendly name for a key
            return key.ToString();
        }
    }
}
