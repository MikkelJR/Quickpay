using Newtonsoft.Json;

namespace QuickPayApi
{
    public class Callback
    {
        public static dynamic SerializeCallback(string jsonObject)
        {
            return JsonConvert.DeserializeObject(jsonObject);
        }
    }
}