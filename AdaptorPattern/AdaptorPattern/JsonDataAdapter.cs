using System.Text.Json;

namespace AdaptorPattern
{
    public class JsonDataAdapter : IFileMaker
    {
        private readonly CsvFileMaker _csvMaker;

        public JsonDataAdapter(CsvFileMaker csvMaker)
        {
            _csvMaker = csvMaker;
        }

        public JsonDataAdapter(IFileMaker csvMaker)
        {
            if (csvMaker is CsvFileMaker maker)
            {
                _csvMaker = maker;
            }
            else
            {
                throw new ArgumentException("JsonDataAdapter only accepts objects of type CsvFileMaker");
            }
        }

        public string GetFileText()
        {
            return JsonSerializer.Serialize(_csvMaker.Data);
        }
    }
}
