using System.Text.Json;

namespace AdaptorPattern
{
    public class JsonDataAdapter<T> : IFileMaker
    {
        private readonly CsvFileMaker _csvMaker;

        public JsonDataAdapter(dynamic csvMaker)
        {
            _csvMaker = csvMaker;
        }

        public string GetFileText()
        {
            return JsonSerializer.Serialize(_csvMaker.Data);
        }
    }
}
