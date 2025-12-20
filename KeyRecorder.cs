using System.Text;


namespace ShortcutCreator
{
    public partial class KeyRecorder : Form
    {
        List<Keys> recordedKeys = new List<Keys> { Keys.None, Keys.None, Keys.None };
        int seconds = 0;

        public KeyRecorder()
        {
            InitializeComponent();
        }

        private void KeyRecorder_Load(object sender, EventArgs e)
        {
            tmrRecord.Start();
            lblSequence.Text = "Sequence: Recording...";
        }

        private void KeyRecorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (!tmrRecord.Enabled)
            {
                return;
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                recordedKeys.Insert(0, Keys.Control);
            }
            else if (e.KeyCode == Keys.ShiftKey)
            {
                recordedKeys.Insert(1, Keys.ShiftKey);
            }
            else
            {
                if (recordedKeys[2] != null && recordedKeys[2] == Keys.ShiftKey)
                {
                    MessageBox.Show("Test");
                    recordedKeys.Insert(2, Keys.None);
                }
                else
                {
                    recordedKeys.Insert(2, e.KeyCode);
                }
            }
        }

        private void tmrRecord_Tick(object sender, EventArgs e)
        {
            if (seconds >= 5)
            {
                seconds = 0;
                tmrRecord.Stop();
                tmrResult.Start();
                lblSequence.Text = "Sequence: " + getRecordedSequence();
            }
            seconds++;
        }

        private string getRecordedSequence()
        {
            StringBuilder sb = new StringBuilder("Ctrl+");
            if (recordedKeys[1] != null && (recordedKeys[1] == Keys.ShiftKey))
            {
                sb.Append("Shift+");
            }
            else
            {
                sb.Append("Alt+");
            }

            if (recordedKeys[2] != null)
            {
                sb.Append(recordedKeys[2]);
            }
            return sb.ToString();
        }

        private void tmrResult_Tick(object sender, EventArgs e)
        {
            if (seconds >= 5)
            {
                Close();
            }
            seconds++;
        }
    }
}
