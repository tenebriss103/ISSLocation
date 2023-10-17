using ISSLocation.Models.ISS_people;
using ISSLocation.Models.ISS_position;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;


namespace ISSLocation.Controllers
{/// <summary>
/// This controller contains methods to find out the location of the International Space Station, the crew list, the number of people on the station, getting the time.
/// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Method for obtaining the position of the International Space Station from API 
        /// </summary>
        /// <returns>Returns the position</returns>
        public Root Position()
        {
            WebRequest request = WebRequest.Create("http://api.open-notify.org/iss-now.json");
            WebResponse response = request.GetResponse();
            JsonTextReader reader = new JsonTextReader(new StreamReader(response.GetResponseStream()));
            reader.SupportMultipleContent = true;
            JsonSerializer serializer = new JsonSerializer();
            return serializer.Deserialize<Root>(reader);

        }
        /// <summary>
        /// Method for obtaining a crew list from the International Space Station
        /// </summary>
        /// <returns>Returns the crew list</returns>
        public RootList ListOfPeople()
        {
            WebRequest request = WebRequest.Create("http://api.open-notify.org/astros.json");
            WebResponse response = request.GetResponse();
            JsonTextReader reader = new JsonTextReader(new StreamReader(response.GetResponseStream()));
            reader.SupportMultipleContent = true;
            JsonSerializer serializer = new JsonSerializer();
            return serializer.Deserialize<RootList>(reader);

        }
        /// <summary>
        /// Method for time conversion
        /// </summary>
        /// <returns>Returns the time</returns>
        public DateTime UnixTimeStampToDateTime()
        {
            int unixTimeStamp = Position().timestamp;
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        /// <summary>
        /// Method gets crew list from JSON file
        /// </summary>
        /// <returns>Returns the crew list</returns>
        public IEnumerable<PeopleItem> GetPeople()
        {

            var people = ListOfPeople().people;
            return people.Where(p => p.craft == "ISS").ToList();

        }
        /// <summary>
        /// The method gets the number of crew
        /// </summary>
        /// <returns>Returns the number of crew</returns>
        public int SumOfPeople()
        {
            return GetPeople().Count();

        }
        /// <summary>
        /// Representation to be returned
        /// </summary>
        /// <returns>Returns a view</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
