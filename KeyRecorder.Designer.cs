namespace ShortcutCreator
{
    partial class frmKeyRecorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblSequence = new Label();
            tmrRecord = new System.Windows.Forms.Timer(components);
            tmrResult = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSequence
            // 
            lblSequence.AutoSize = true;
            lblSequence.Location = new Point(8, 24);
            lblSequence.Margin = new Padding(2, 0, 2, 0);
            lblSequence.Name = "lblSequence";
            lblSequence.Size = new Size(64, 15);
            lblSequence.TabIndex = 0;
            lblSequence.Text = "Sequence: ";
            // 
            // tmrRecord
            // 
            tmrRecord.Interval = 1000;
            tmrRecord.Tick += tmrRecord_Tick;
            // 
            // tmrResult
            // 
            tmrResult.Interval = 1000;
            tmrResult.Tick += tmrResult_Tick;
            // 
            // frmKeyRecorder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 65);
            Controls.Add(lblSequence);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmKeyRecorder";
            Text = "Recording key sequence";
            FormClosing += frmKeyRecorder_FormClosing;
            Load += frmKeyRecorder_Load;
            KeyDown += frmKeyRecorder_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSequence;
        private System.Windows.Forms.Timer tmrRecord;
        private System.Windows.Forms.Timer tmrResult;
    }
}