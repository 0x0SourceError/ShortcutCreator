using IWshRuntimeLibrary;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ShortcutCreator
{
    public partial class frmShortcutCreator : Form
    {
        readonly WshShell shell = new WshShell();
        readonly CommonFileDialogFilter iconFilter = new CommonFileDialogFilter("Icon Files", "*.ico")
        {
            ShowExtensions = true,
        };

        public frmShortcutCreator()
        {
            InitializeComponent();
        }

        private void frmShortcutCreator_Load(object sender, EventArgs e)
        {
            radNormalWindow.Checked = true;
        }

        private void btnOpenTarget_Click(object sender, EventArgs e)
        {
            // The properties of this dialog are a bit hacky. This allows to select files and folders
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                EnsureFileExists = false,
                EnsurePathExists = false,
                EnsureValidNames = false,
                ShowHiddenItems = true,
                ShowPlacesList = true,
                Title = "Select target file or folder",
                DefaultFileName = "Folder Selection"
            })
            {
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    if (dialog.FileName.Contains(dialog.DefaultFileName))
                    {
                        string directory = dialog.FileName.Substring(0, dialog.FileName.IndexOf("Folder Selection") - 1);
                        txtTarget.Text = directory;
                    }
                    else
                    {
                        txtTarget.Text = dialog.FileName;
                    }
                }
            }
        }

        private void btnOpenIcon_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                EnsureFileExists = true,
                EnsurePathExists = true,
                ShowHiddenItems = true,
                ShowPlacesList = true,
                Title = "Select icon"
            })
            {
                dialog.Filters.Add(iconFilter);
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtIcon.Text = dialog.FileName;
                }
            }
        }

        private void btnOpenOutput_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
                Title = "Select output area"
            })
            {
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtOutput.Text = dialog.FileName;
                }
            }
        }

        private void btnGenerateShortcut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTarget.Text) || string.IsNullOrWhiteSpace(txtIcon.Text) || string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                MessageBox.Show("A target file/folder, icon, and output path are required to make a shortcut. Make sure all required fields are entered in",
                    "Missing input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string shortcutPath = txtTarget.Text + "\\";
            string fullShortcutPath = shortcutPath + (!string.IsNullOrWhiteSpace(txtName.Text) ? txtName.Text : "MyLink") + ".lnk";
            IWshShortcut shortcut = shell.CreateShortcut(fullShortcutPath);
            shortcut.IconLocation = txtIcon.Text;
            shortcut.Hotkey = txtShortcut.Text;
            shortcut.TargetPath = txtTarget.Text;
            shortcut.Arguments = !string.IsNullOrWhiteSpace(txtParameters.Text) ? txtParameters.Text : string.Empty;
            shortcut.Description = !string.IsNullOrWhiteSpace(txtComments.Text) ? txtComments.Text : string.Empty;
            shortcut.WindowStyle = getWindowStyle();
            shortcut.Save();
        }

        private int getWindowStyle()
        {
            if (radNormalWindow.Checked)
            {
                return 1; // 1 = Normal window
            }
            else if (radMaximized.Checked)
            {
                return 3; // 3 = Maximized
            }
            else
            {
                return 7; // 7 = Minimized
            }
        }

        private void txtShortcut_KeyUp(object sender, KeyEventArgs e)
        {
            txtShortcut.Text = "Ctrl+Alt+" + e.KeyData;
        }
    }
}
