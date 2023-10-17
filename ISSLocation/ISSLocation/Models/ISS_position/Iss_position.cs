using Newtonsoft.Json;

namespace ISSLocation.Models.ISS_position
{/// <summary>
/// Contains the properties of longitude and latitude
/// </summary>
    public class ISS_position
    {
        /// <summary>
        /// Contains the latitude property
        /// </summary>
        [JsonProperty("latitude")]
        public string latitude { get; set; }
        /// <summary>
        /// Contains the longitude property
        /// </summary>

        [JsonProperty("longitude")]
        public string longitude { get; set; }
    }
}
