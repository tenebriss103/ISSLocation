using Newtonsoft.Json;

namespace ISSLocation.Models.ISS_position
{
    /// <summary>
    /// Contains the root information of the JSON file
    /// </summary>
    public class Root
    {
        /// <summary>
        /// Contains status of message
        /// </summary>
        [JsonProperty("message")]
        public string message { get; set; }
        /// <summary>
        /// Contains time
        /// </summary>
        [JsonProperty("timestamp")]
        public int timestamp { get; set; }
        /// <summary>
        /// Contains position
        /// </summary>

        [JsonProperty("iss_position")]
        public ISS_position iss_position { get; set; }
    }
}
