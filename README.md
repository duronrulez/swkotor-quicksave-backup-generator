## QuickSave Backup Generator
Star Wars Knights of the Old Republic tends to crash often.

One of those cases is when you are (quick)saving. This tool aims to fix the issue, by introducing an auto backup feature. 
After the tool detects a change in the quicksave slot it will - after a user defined delay - backup the quicksave slot to a dedicated folder.
The user defined delay is important, because depending on the computer running the game the quicksave time will vary, you may have to experiment with that value otherwise the backup script will create sometimes incomplete backups. 

If you still end up with some incomplete backups although they are unusuable, there should be correct ones before and after that can be used, so even if the value above is not set 100% correctly, its not all lost.

### Restoring a Backup
To restore a backup navigate to the backup folder and timestamp (visible in the tool log) copy all files and paste them over the native game quicksave slot, usually located in the folder that contains swkotor.exe under "saves/000000 - QUICKSAVE/".

### TODO:
- If there are enough users for this, there is an additional feature that can be added to allow the user to pick a specific backup to restore to the quicksave slot through this tools UI, but this is for another day.
- The backup delay process can also be improved to monitor specifically for all files that are expected to be modified, before starting a backup process, this will make the user defined delay obsolete.
