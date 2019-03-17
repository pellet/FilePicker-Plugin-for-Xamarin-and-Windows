namespace Plugin.FilePicker
{
    public class FileOptions
    {
        public bool CanChooseFiles { get; set; }
        public bool AllowsMultipleSelection { get; set; }
        public bool CanChooseDirectories { get; set; }

        public FileOptions()
        {
            this.CanChooseFiles = true;
            this.AllowsMultipleSelection = false;
            this.CanChooseDirectories = false;
        }
    }
}