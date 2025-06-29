using System.Diagnostics;

namespace kotor_quicksave_backups
{
    public partial class KotorQuickSaveBackupForm : Form
    {
        KotorQuickSaveBackup kqsb;

        public KotorQuickSaveBackupForm()
        {
            InitializeComponent();
            kqsb = new KotorQuickSaveBackup(backupLogTextBox, 1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            swkotorexefound.Visible = false;
            startAutoBackupButton.Enabled = false;

            waitBeforeBackupTextBox.Text = (Properties.Settings.Default.waitBeforeBackup / 1000).ToString();

            gamePathTextBox.Text = Properties.Settings.Default.kotorPath;
            if (KotorQuickSaveBackup.IsValidKotorPath(Properties.Settings.Default.kotorPath))
            {
                swkotorexefound.Visible = true;
                startAutoBackupButton.Enabled = true;
            }
        }

        private void findGameExeButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath == "")
            {
                return;
            }

            Properties.Settings.Default.kotorPath = fbd.SelectedPath;
            Properties.Settings.Default.Save();

            swkotorexefound.Visible = false;
            startAutoBackupButton.Enabled = false;

            if (KotorQuickSaveBackup.IsValidKotorPath(Properties.Settings.Default.kotorPath))
            {
                swkotorexefound.Visible = true;
                startAutoBackupButton.Enabled = true;
            }

            gamePathTextBox.Text = fbd.SelectedPath;
        }

        private void startAutoBackupButton_Click(object sender, EventArgs e)
        {
            startAutoBackupButton.Enabled = false;
            findGameExeButton.Enabled = false;
            waitBeforeBackupTextBox.Enabled = false;

            kqsb.SetKotorPath(Properties.Settings.Default.kotorPath);
            kqsb.StartAutoBackup();
            kqsb.AddLog("Listening for quicksave events ....");
        }


        private void waitBeforeBackupTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(waitBeforeBackupTextBox.Text, out int res))
            {
                Properties.Settings.Default.waitBeforeBackup = res * 1000;
                Properties.Settings.Default.Save();
                kqsb.SetBackupTime(res * 1000);
                waitBeforeBackupTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                waitBeforeBackupTextBox.BackColor = Color.Red;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpBox().ShowDialog();
        }
    }
}
