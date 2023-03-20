using System.Text;

namespace AdaptorPattern
{
    public class CsvFileMaker : IFileMaker
    {
        private List<String> data = new();

        public List<String> Data 
        {
            get => data;
            set => data = value;
        }

        public CsvFileMaker(List<String> data)
        {
            Data = data;
        }
        public string GetFileText()
        {
            StringBuilder resultBuilder = new();
            for (int j = 0; j < Data.Count; j++)
            {
                resultBuilder.Append(Data[j]);
                if (j < Data.Count - 1)
                {
                    resultBuilder.Append(",");
                }
            }
            return resultBuilder.ToString();
        }
    }
}
