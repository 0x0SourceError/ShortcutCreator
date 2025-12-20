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
            btnClearShortcut = new Button();
            btnRecord = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 15);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(544, 31);
            txtName.TabIndex = 1;
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(130, 63);
            txtTarget.Margin = new Padding(4, 5, 4, 5);
            txtTarget.Name = "txtTarget";
            txtTarget.ReadOnly = true;
            txtTarget.Size = new Size(427, 31);
            txtTarget.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Target:";
            // 
            // txtIcon
            // 
            txtIcon.Location = new Point(130, 112);
            txtIcon.Margin = new Padding(4, 5, 4, 5);
            txtIcon.Name = "txtIcon";
            txtIcon.ReadOnly = true;
            txtIcon.Size = new Size(427, 31);
            txtIcon.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 5;
            label3.Text = "Icon:";
            // 
            // txtParameters
            // 
            txtParameters.Location = new Point(130, 160);
            txtParameters.Margin = new Padding(4, 5, 4, 5);
            txtParameters.Name = "txtParameters";
            txtParameters.Size = new Size(544, 31);
            txtParameters.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 8;
            label4.Text = "Parameters:";
            // 
            // txtShortcut
            // 
            txtShortcut.Location = new Point(130, 208);
            txtShortcut.Margin = new Padding(4, 5, 4, 5);
            txtShortcut.Name = "txtShortcut";
            txtShortcut.ReadOnly = true;
            txtShortcut.Size = new Size(314, 31);
            txtShortcut.TabIndex = 11;
            txtShortcut.KeyUp += txtShortcut_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 213);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 10;
            label5.Text = "Shortcut Key:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 262);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 13;
            label6.Text = "Comments:";
            // 
            // txtComments
            // 
            txtComments.Location = new Point(130, 257);
            txtComments.Margin = new Padding(4, 5, 4, 5);
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(544, 31);
            txtComments.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 310);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 15;
            label7.Text = "Run Option:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(234, 370);
            txtOutput.Margin = new Padding(4, 5, 4, 5);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(513, 31);
            txtOutput.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 377);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 19;
            label8.Text = "Output Path:";
            // 
            // btnOpenTarget
            // 
            btnOpenTarget.Location = new Point(569, 62);
            btnOpenTarget.Margin = new Padding(4, 5, 4, 5);
            btnOpenTarget.Name = "btnOpenTarget";
            btnOpenTarget.Size = new Size(107, 34);
            btnOpenTarget.TabIndex = 4;
            btnOpenTarget.Text = "Open";
            btnOpenTarget.UseVisualStyleBackColor = true;
            btnOpenTarget.Click += btnOpenTarget_Click;
            // 
            // btnOpenIcon
            // 
            btnOpenIcon.Location = new Point(569, 111);
            btnOpenIcon.Margin = new Padding(4, 5, 4, 5);
            btnOpenIcon.Name = "btnOpenIcon";
            btnOpenIcon.Size = new Size(107, 34);
            btnOpenIcon.TabIndex = 7;
            btnOpenIcon.Text = "Open";
            btnOpenIcon.UseVisualStyleBackColor = true;
            btnOpenIcon.Click += btnOpenIcon_Click;
            // 
            // btnOpenOutput
            // 
            btnOpenOutput.Location = new Point(757, 368);
            btnOpenOutput.Margin = new Padding(4, 5, 4, 5);
            btnOpenOutput.Name = "btnOpenOutput";
            btnOpenOutput.Size = new Size(107, 38);
            btnOpenOutput.TabIndex = 21;
            btnOpenOutput.Text = "Open";
            btnOpenOutput.UseVisualStyleBackColor = true;
            btnOpenOutput.Click += btnOpenOutput_Click;
            // 
            // btnGenerateShortcut
            // 
            btnGenerateShortcut.Location = new Point(444, 418);
            btnGenerateShortcut.Margin = new Padding(4, 5, 4, 5);
            btnGenerateShortcut.Name = "btnGenerateShortcut";
            btnGenerateShortcut.Size = new Size(107, 38);
            btnGenerateShortcut.TabIndex = 22;
            btnGenerateShortcut.Text = "Generate";
            btnGenerateShortcut.UseVisualStyleBackColor = true;
            btnGenerateShortcut.Click += btnGenerateShortcut_Click;
            // 
            // radNormalWindow
            // 
            radNormalWindow.AutoSize = true;
            radNormalWindow.Location = new Point(194, 307);
            radNormalWindow.Margin = new Padding(4, 5, 4, 5);
            radNormalWindow.Name = "radNormalWindow";
            radNormalWindow.Size = new Size(167, 29);
            radNormalWindow.TabIndex = 16;
            radNormalWindow.TabStop = true;
            radNormalWindow.Text = "Normal Window";
            radNormalWindow.UseVisualStyleBackColor = true;
            // 
            // radMinimized
            // 
            radMinimized.AutoSize = true;
            radMinimized.Location = new Point(363, 307);
            radMinimized.Margin = new Padding(4, 5, 4, 5);
            radMinimized.Name = "radMinimized";
            radMinimized.Size = new Size(119, 29);
            radMinimized.TabIndex = 17;
            radMinimized.TabStop = true;
            radMinimized.Text = "Minimized";
            radMinimized.UseVisualStyleBackColor = true;
            // 
            // radMaximized
            // 
            radMaximized.AutoSize = true;
            radMaximized.Location = new Point(487, 307);
            radMaximized.Margin = new Padding(4, 5, 4, 5);
            radMaximized.Name = "radMaximized";
            radMaximized.Size = new Size(122, 29);
            radMaximized.TabIndex = 18;
            radMaximized.TabStop = true;
            radMaximized.Text = "Maximized";
            radMaximized.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbxIcon);
            groupBox1.Location = new Point(691, 3);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(290, 332);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Icon";
            // 
            // pbxIcon
            // 
            pbxIcon.Location = new Point(31, 38);
            pbxIcon.Margin = new Padding(4, 5, 4, 5);
            pbxIcon.Name = "pbxIcon";
            pbxIcon.Size = new Size(229, 267);
            pbxIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxIcon.TabIndex = 0;
            pbxIcon.TabStop = false;
            // 
            // btnClearShortcut
            // 
            btnClearShortcut.Location = new Point(567, 207);
            btnClearShortcut.Margin = new Padding(4, 5, 4, 5);
            btnClearShortcut.Name = "btnClearShortcut";
            btnClearShortcut.Size = new Size(107, 35);
            btnClearShortcut.TabIndex = 12;
            btnClearShortcut.Text = "Clear";
            btnClearShortcut.UseVisualStyleBackColor = true;
            btnClearShortcut.Click += btnClearShortcut_Click;
            // 
            // btnRecord
            // 
            btnRecord.Location = new Point(452, 207);
            btnRecord.Margin = new Padding(4, 5, 4, 5);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(107, 34);
            btnRecord.TabIndex = 24;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // frmShortcutCreator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 468);
            Controls.Add(btnRecord);
            Controls.Add(btnClearShortcut);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnClearShortcut;
        private Button btnRecord;
    }
}
