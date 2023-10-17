using Newtonsoft.Json;

namespace ISSLocation.Models.ISS_people
{/// <summary>
/// Contains the root list of the JSON file
/// </summary>
    public class RootList
    {/// <summary>
     /// Contains status of message
     /// </summary>
        [JsonProperty("message")]
        public string message { get; set; }
        /// <summary>
        /// Contains a number
        /// </summary>
        [JsonProperty("number")]
        public string number { get; set; }
        /// <summary>
        /// Contains a  people
        /// </summary>

        [JsonProperty("people")]
        public List<PeopleItem> people { get; set; }
        /// <summary>
        /// The method converts the information into a convenient readable form
        /// </summary>
        /// <returns>Returns information about people and numbers</returns>
        public override string ToString()
        {
            return $"Peple: {people}, Number:{number}  ";
        }
    }
}
