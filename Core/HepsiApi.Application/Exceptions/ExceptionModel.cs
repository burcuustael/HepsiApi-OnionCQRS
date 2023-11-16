using Newtonsoft.Json;

namespace HepsiApi.Application.Exceptions
{
    public class ExceptionModel : ErrosStatusCode
    {
        public IEnumerable<string> Errors { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class ErrosStatusCode
    {
        public int StatusCode { get; set; }
    }
}
