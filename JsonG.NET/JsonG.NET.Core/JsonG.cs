using Newtonsoft.Json;

namespace JsonG.NET.Core
{
    public class JsonG
    {
        public static string SerializeObject(object @object)
        {
            return JsonConvert.SerializeObject(@object);
        }
    }
}
