namespace ShortcutCreator
{
    partial class frmShortcutCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            txtTarget = new TextBox();
            label2 = new Label();
            txtIcon = new TextBox();
            label3 = new Label();
            txtParameters = new TextBox();
            label4 = new Label();
            txtShortcut = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtComments = new TextBox();
            label7 = new Label();
            txtOutput = new TextBox();
            label8 = new Label();
            btnOpenTarget = new Button();
            btnOpenIcon = new Button();
            btnOpenOutput = new Button();
            btnGenerateShortcut = new Button();
            radNormalWindow = new RadioButton();
            radMinimized = new RadioButton();
            radMaximized = new RadioButton();
            groupBox1 = new GroupBox();
            pbxIcon = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(382, 23);
            txtName.TabIndex = 1;
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(91, 38);
            txtTarget.Name = "txtTarget";
            txtTarget.ReadOnly = true;
            txtTarget.Size = new Size(300, 23);
            txtTarget.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Target:";
            // 
            // txtIcon
            // 
            txtIcon.Location = new Point(91, 67);
            txtIcon.Name = "txtIcon";
            txtIcon.ReadOnly = true;
            txtIcon.Size = new Size(300, 23);
            txtIcon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Icon:";
            // 
            // txtParameters
            // 
            txtParameters.Location = new Point(91, 96);
            txtParameters.Name = "txtParameters";
            txtParameters.Size = new Size(382, 23);
            txtParameters.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Parameters:";
            // 
            // txtShortcut
            // 
            txtShortcut.Location = new Point(91, 125);
            txtShortcut.Name = "txtShortcut";
            txtShortcut.Size = new Size(382, 23);
            txtShortcut.TabIndex = 9;
            txtShortcut.KeyUp += txtShortcut_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "Shortcut Key:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 10;
            label6.Text = "Comments:";
            // 
            // txtComments
            // 
            txtComments.Location = new Point(91, 154);
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(382, 23);
            txtComments.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 186);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 12;
            label7.Text = "Run Option:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(164, 222);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(360, 23);
            txtOutput.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 226);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 14;
            label8.Text = "Output Path:";
            // 
            // btnOpenTarget
            // 
            btnOpenTarget.Location = new Point(398, 38);
            btnOpenTarget.Name = "btnOpenTarget";
            btnOpenTarget.Size = new Size(75, 23);
            btnOpenTarget.TabIndex = 16;
            btnOpenTarget.Text = "Open";
            btnOpenTarget.UseVisualStyleBackColor = true;
            btnOpenTarget.Click += btnOpenTarget_Click;
            // 
            // btnOpenIcon
            // 
            btnOpenIcon.Location = new Point(398, 67);
            btnOpenIcon.Name = "btnOpenIcon";
            btnOpenIcon.Size = new Size(75, 23);
            btnOpenIcon.TabIndex = 17;
            btnOpenIcon.Text = "Open";
            btnOpenIcon.UseVisualStyleBackColor = true;
            btnOpenIcon.Click += btnOpenIcon_Click;
            // 
            // btnOpenOutput
            // 
            btnOpenOutput.Location = new Point(528, 222);
            btnOpenOutput.Name = "btnOpenOutput";
            btnOpenOutput.Size = new Size(75, 23);
            btnOpenOutput.TabIndex = 18;
            btnOpenOutput.Text = "Open";
            btnOpenOutput.UseVisualStyleBackColor = true;
            btnOpenOutput.Click += btnOpenOutput_Click;
            // 
            // btnGenerateShortcut
            // 
            btnGenerateShortcut.Location = new Point(311, 251);
            btnGenerateShortcut.Name = "btnGenerateShortcut";
            btnGenerateShortcut.Size = new Size(75, 23);
            btnGenerateShortcut.TabIndex = 19;
            btnGenerateShortcut.Text = "Generate";
            btnGenerateShortcut.UseVisualStyleBackColor = true;
            btnGenerateShortcut.Click += btnGenerateShortcut_Click;
            // 
            // radNormalWindow
            // 
            radNormalWindow.AutoSize = true;
            radNormalWindow.Location = new Point(136, 184);
            radNormalWindow.Name = "radNormalWindow";
            radNormalWindow.Size = new Size(112, 19);
            radNormalWindow.TabIndex = 20;
            radNormalWindow.TabStop = true;
            radNormalWindow.Text = "Normal Window";
            radNormalWindow.UseVisualStyleBackColor = true;
            // 
            // radMinimized
            // 
            radMinimized.AutoSize = true;
            radMinimized.Location = new Point(254, 184);
            radMinimized.Name = "radMinimized";
            radMinimized.Size = new Size(81, 19);
            radMinimized.TabIndex = 21;
            radMinimized.TabStop = true;
            radMinimized.Text = "Minimized";
            radMinimized.UseVisualStyleBackColor = true;
            // 
            // radMaximized
            // 
            radMaximized.AutoSize = true;
            radMaximized.Location = new Point(341, 184);
            radMaximized.Name = "radMaximized";
            radMaximized.Size = new Size(82, 19);
            radMaximized.TabIndex = 22;
            radMaximized.TabStop = true;
            radMaximized.Text = "Maximized";
            radMaximized.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbxIcon);
            groupBox1.Location = new Point(484, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 199);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Icon";
            // 
            // pbxIcon
            // 
            pbxIcon.Location = new Point(22, 23);
            pbxIcon.Name = "pbxIcon";
            pbxIcon.Size = new Size(160, 160);
            pbxIcon.TabIndex = 0;
            pbxIcon.TabStop = false;
            // 
            // frmShortcutCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 281);
            Controls.Add(groupBox1);
            Controls.Add(radMaximized);
            Controls.Add(radMinimized);
            Controls.Add(radNormalWindow);
            Controls.Add(btnGenerateShortcut);
            Controls.Add(btnOpenOutput);
            Controls.Add(btnOpenIcon);
            Controls.Add(btnOpenTarget);
            Controls.Add(txtOutput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtComments);
            Controls.Add(label6);
            Controls.Add(txtShortcut);
            Controls.Add(label5);
            Controls.Add(txtParameters);
            Controls.Add(label4);
            Controls.Add(txtIcon);
            Controls.Add(label3);
            Controls.Add(txtTarget);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmShortcutCreator";
            Text = "Shortcut Creator";
            Load += frmShortcutCreator_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtTarget;
        private Label label2;
        private TextBox txtIcon;
        private Label label3;
        private TextBox txtParameters;
        private Label label4;
        private TextBox txtShortcut;
        private Label label5;
        private Label label6;
        private TextBox txtComments;
        private Label label7;
        private TextBox txtOutput;
        private Label label8;
        private Button btnOpenTarget;
        private Button btnOpenIcon;
        private Button btnOpenOutput;
        private Button btnGenerateShortcut;
        private RadioButton radNormalWindow;
        private RadioButton radMinimized;
        private RadioButton radMaximized;
        private GroupBox groupBox1;
        private PictureBox pbxIcon;
    }
}
