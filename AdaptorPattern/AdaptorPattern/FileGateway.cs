namespace AdaptorPattern
{
    public class FileGateway
    {
        private string data = "";
        private string fileName = "";
        private string filePath = "";
        private string absolutePath = "";

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                UpdateAbsoultePath();
            }
        }

        public string FilePath
        {
            get { return filePath; }
            set
            {
                filePath = value;
                UpdateAbsoultePath();
            }
        }

        public FileGateway(string data, string fileName)
        {
            Data = data;
            string outputDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AdaptorProgram");
            Directory.CreateDirectory(outputDir);
            FileName = fileName;
            FilePath = outputDir;
            UpdateAbsoultePath();
        }

        public FileGateway(string data, string fileName, string filePath)
        {
            Data = data;
            FileName = fileName;
            FilePath = filePath;
            UpdateAbsoultePath();
        }

        private void UpdateAbsoultePath()
        {
            string outputFile = Path.Combine(FilePath, FileName);
            absolutePath = outputFile;
        }

        public void SaveFile()
        {
            File.WriteAllText(absolutePath, Data);
        }
    }
}
