using System.Diagnostics;
using System.IO;

namespace kotor_quicksave_backups
{
    internal class KotorQuickSaveBackup
    {
        private int backupTime = 1000;
        private FileSystemWatcher? fsw;
        private readonly TextBox tbLog;
        private System.Timers.Timer t;
        private bool currentlyDoingBackup = false;
        private string kotorPath = "";
        

        private string quickSavePath = "";
        public KotorQuickSaveBackup(TextBox tbLog, int backupTime)
        {
            this.tbLog = tbLog;
            this.backupTime = (backupTime < 1000 ? 1000 : backupTime);

            t = new System.Timers.Timer(backupTime); // how long do we wait after receiving an event before doing the backup
            t.AutoReset = false;
            t.Elapsed += BackupWaitTimeElapsed;
        }

        public static bool IsValidKotorPath(string path)
        {
            if (path == "")
            {
                return false;
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (Path.GetFileName(file) == "swkotor.exe")
                {
                    return true;
                }
            }

            return false;
        }

        public void SetKotorPath(string kotorPath)
        {
            this.kotorPath = kotorPath;
            quickSavePath = Path.Combine(kotorPath, "saves", "000000 - QUICKSAVE");
        }
        public void SetBackupTime(int backupTime)
        {
            this.backupTime = backupTime;
            t.Interval = this.backupTime;
        }

        public void StartAutoBackup() {
            if (kotorPath == "") {
                throw new Exception("Kotor Path is invalid");
            }

            Debug.Print($"Start {quickSavePath}");

            fsw = new FileSystemWatcher(quickSavePath);

            fsw.NotifyFilter = NotifyFilters.CreationTime
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Size;

            fsw.Changed += OnChanged;

            fsw.Filter = "*.*";
            fsw.IncludeSubdirectories = true;
            fsw.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            // ignore events while we're doing a backup
            if (currentlyDoingBackup)
            {
                return;
            }

            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Debug.WriteLine($"Changed: {e.FullPath}");
            AddLog($"File Changed: {Path.GetFileName(e.FullPath)}. Queuing backup in {backupTime}ms...");
            t.Stop(); // reset timer so it doenst continue running if a new change has happened
            t.Start();
        }

        public void AddLog(string log)
        {
            if (tbLog.InvokeRequired)
            {
                tbLog.BeginInvoke(new MethodInvoker(delegate ()
                {
                    AddLog(log);
                }));
            } else
            {
                tbLog.Text = $"{tbLog.Text} {DateTime.Now:yyyy-MM-dd HH:mm:ss} {log} {Environment.NewLine}";
            }
        }

        private void BackupWaitTimeElapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // we cannot fire another event as the previous has not finished processing
            if (currentlyDoingBackup)
            {
                return;
            }

            DoBackup();
        }

        private void DoBackup() {
            if (currentlyDoingBackup)
            {
                return;
            }

            if (kotorPath == "")
            {
                throw new Exception("Kotor Path is invalid");
            }

            AddLog("Starting the backup process.");
            currentlyDoingBackup = true;
            string quickSaveBackupFolder = Path.Combine(kotorPath, "_qsbkp");
            string quickSaveBackupFolderCurrent = Path.Combine(kotorPath, "_qsbkp", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));

            if (Directory.Exists(quickSaveBackupFolder) == false)
            {
                Directory.CreateDirectory(quickSaveBackupFolder);
            }

            if (Directory.Exists(quickSaveBackupFolderCurrent) == false)
            {
                Directory.CreateDirectory(quickSaveBackupFolderCurrent);
            }

            string[] files = Directory.GetFiles(quickSavePath);
            foreach (string file in files)
            {
                File.Copy(file, Path.Combine(quickSaveBackupFolderCurrent, Path.GetFileName(file)));
            }
            currentlyDoingBackup = false;
            AddLog("Backup process finished successfully.");
            AddLog($"Backup location: {quickSaveBackupFolderCurrent}");
        }
    }
}
