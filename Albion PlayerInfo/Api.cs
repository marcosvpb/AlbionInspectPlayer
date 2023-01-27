using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;



namespace Albion_PlayerInfo
{
    public class Api
    {
        public static Search GetPlayerInfoByName(string Name)
        {
            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nobody");
            string response = client.DownloadString(new Uri("https://gameinfo.albiononline.com/api/gameinfo/search?q=" + Name));
            // --> 'Normalize' response string here, if necessary
            Search photos = JsonConvert.DeserializeObject<Search>(response);

            // now buid the HTML string

            return photos;
        }

        public static List<Deaths> GetPlayerDeaths(string Id)
        {
            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nobody");
            string response = client.DownloadString(new Uri("https://gameinfo.albiononline.com/api/gameinfo/players/" + Id.Trim() + "/deaths"));
            // --> 'Normalize' response string here, if necessary
            List<Deaths> photos = JsonConvert.DeserializeObject<List<Deaths>>(response);

            // now buid the HTML string

            return photos;
        }

        public static List<Deaths> GetPlayerKills(string Id)
        {
            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nobody");
            string response = client.DownloadString(new Uri("https://gameinfo.albiononline.com/api/gameinfo/players/" + Id.Trim() + "/kills"));
            // --> 'Normalize' response string here, if necessary
            List<Deaths> photos = JsonConvert.DeserializeObject<List<Deaths>>(response);

            // now buid the HTML string

            return photos;
        }
    }
}
