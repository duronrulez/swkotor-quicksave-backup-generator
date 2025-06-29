namespace kotor_quicksave_backups
{
    partial class KotorQuickSaveBackupForm
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
            components = new System.ComponentModel.Container();
            gamePathLabel = new Label();
            gamePathTextBox = new TextBox();
            findGameExeButton = new Button();
            swkotorexefound = new Label();
            startAutoBackupButton = new Button();
            backupLogTextBox = new TextBox();
            backupLogLabel = new Label();
            waitBeforeBackupLabel = new Label();
            waitBeforeBackupTextBox = new TextBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gamePathLabel
            // 
            gamePathLabel.AutoSize = true;
            gamePathLabel.Location = new Point(12, 49);
            gamePathLabel.Name = "gamePathLabel";
            gamePathLabel.Size = new Size(66, 15);
            gamePathLabel.TabIndex = 0;
            gamePathLabel.Text = "Kotor Path:";
            // 
            // gamePathTextBox
            // 
            gamePathTextBox.Location = new Point(84, 46);
            gamePathTextBox.Name = "gamePathTextBox";
            gamePathTextBox.ReadOnly = true;
            gamePathTextBox.Size = new Size(308, 23);
            gamePathTextBox.TabIndex = 1;
            // 
            // findGameExeButton
            // 
            findGameExeButton.Location = new Point(398, 46);
            findGameExeButton.Name = "findGameExeButton";
            findGameExeButton.Size = new Size(75, 23);
            findGameExeButton.TabIndex = 2;
            findGameExeButton.Text = "Browse";
            findGameExeButton.UseVisualStyleBackColor = true;
            findGameExeButton.Click += findGameExeButton_Click;
            // 
            // swkotorexefound
            // 
            swkotorexefound.AutoSize = true;
            swkotorexefound.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            swkotorexefound.ForeColor = Color.Green;
            swkotorexefound.Location = new Point(84, 81);
            swkotorexefound.Name = "swkotorexefound";
            swkotorexefound.Size = new Size(249, 15);
            swkotorexefound.TabIndex = 4;
            swkotorexefound.Text = "✓ swkotor.exe found in the selected folder.";
            swkotorexefound.Visible = false;
            // 
            // startAutoBackupButton
            // 
            startAutoBackupButton.Enabled = false;
            startAutoBackupButton.Location = new Point(169, 137);
            startAutoBackupButton.Name = "startAutoBackupButton";
            startAutoBackupButton.Size = new Size(120, 23);
            startAutoBackupButton.TabIndex = 5;
            startAutoBackupButton.Text = "Start Auto Backup";
            startAutoBackupButton.UseVisualStyleBackColor = true;
            startAutoBackupButton.Click += startAutoBackupButton_Click;
            // 
            // backupLogTextBox
            // 
            backupLogTextBox.Location = new Point(11, 219);
            backupLogTextBox.Multiline = true;
            backupLogTextBox.Name = "backupLogTextBox";
            backupLogTextBox.ReadOnly = true;
            backupLogTextBox.ScrollBars = ScrollBars.Both;
            backupLogTextBox.Size = new Size(461, 428);
            backupLogTextBox.TabIndex = 6;
            // 
            // backupLogLabel
            // 
            backupLogLabel.AutoSize = true;
            backupLogLabel.Location = new Point(11, 201);
            backupLogLabel.Name = "backupLogLabel";
            backupLogLabel.Size = new Size(72, 15);
            backupLogLabel.TabIndex = 7;
            backupLogLabel.Text = "Backup Log:";
            // 
            // waitBeforeBackupLabel
            // 
            waitBeforeBackupLabel.AutoSize = true;
            waitBeforeBackupLabel.Location = new Point(9, 106);
            waitBeforeBackupLabel.Name = "waitBeforeBackupLabel";
            waitBeforeBackupLabel.Size = new Size(113, 15);
            waitBeforeBackupLabel.TabIndex = 8;
            waitBeforeBackupLabel.Text = "Wait Before Backup:";
            // 
            // waitBeforeBackupTextBox
            // 
            waitBeforeBackupTextBox.Location = new Point(128, 103);
            waitBeforeBackupTextBox.Name = "waitBeforeBackupTextBox";
            waitBeforeBackupTextBox.RightToLeft = RightToLeft.Yes;
            waitBeforeBackupTextBox.Size = new Size(35, 23);
            waitBeforeBackupTextBox.TabIndex = 9;
            waitBeforeBackupTextBox.Text = "30";
            toolTip1.SetToolTip(waitBeforeBackupTextBox, "How many seconds to wait after a quicksave event is detected, before doing the backup.");
            waitBeforeBackupTextBox.TextChanged += waitBeforeBackupTextBox_TextChanged;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 106);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 10;
            label1.Text = "seconds after last quicksave event.";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // KotorQuickSaveBackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 661);
            Controls.Add(label1);
            Controls.Add(waitBeforeBackupTextBox);
            Controls.Add(waitBeforeBackupLabel);
            Controls.Add(backupLogLabel);
            Controls.Add(backupLogTextBox);
            Controls.Add(startAutoBackupButton);
            Controls.Add(swkotorexefound);
            Controls.Add(findGameExeButton);
            Controls.Add(gamePathTextBox);
            Controls.Add(gamePathLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "KotorQuickSaveBackupForm";
            Text = "Kotor QuickSave Backup";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gamePathLabel;
        private TextBox gamePathTextBox;
        private Button findGameExeButton;
        private Label swkotorexefound;
        private Button startAutoBackupButton;
        private TextBox backupLogTextBox;
        private Label backupLogLabel;
        private Label waitBeforeBackupLabel;
        private TextBox waitBeforeBackupTextBox;
        private ToolTip toolTip1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}
