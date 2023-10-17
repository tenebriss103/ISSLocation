using Newtonsoft.Json;

namespace ISSLocation.Models.ISS_people
{
    /// <summary>
    /// Contains properties for the crew
    /// </summary>
    public class PeopleItem
        {/// <summary>
         /// The property contains the name of the person
         /// </summary>
        [JsonProperty("name")]
            public string name { get; set; }
        /// <summary>
        /// The property contains the craft of the person
        /// </summary>
        [JsonProperty("craft")]
            public string craft { get; set; }
        }
    
}
