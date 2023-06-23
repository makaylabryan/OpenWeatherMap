using Newtonsoft.Json;

namespace OpenWeatherMap_Activity
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }

}
