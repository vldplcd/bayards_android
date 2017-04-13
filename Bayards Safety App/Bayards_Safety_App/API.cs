using System;
using System.Collections.Generic;
using System.Text;
using Bayards_Safety_App.Entities;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bayards_Safety_App
{
    public class API
    {

        const string UriSectionsListTemplate = "<valid_adress>";
        const string Uri
        /// <summary>
        /// Method that gets the complete list of sections; language is specified with language variable
        /// </summary>
        /// <returns>List of sections</returns>
        public async Task<List<Section>> getCompleteSectionsList(string language)
        {

           
            string requestUri = UriSectionsListTemplate;
            List<Section> result;
            using (HttpClient hc = new HttpClient())
            {
                var responseMsg = await hc.GetAsync(requestUri);
                var resultStr = await responseMsg.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<Section>>(resultStr);
            }
            return result;
        }
        /// <summary>
        /// Method that gets the list of all risks from specified Section
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns> 
        public async Task<List<SafetyObject>> getRisksList(Section section)
        {
            using (HttpClient hc = new HttpClient())
            {
                //GET REQUEST
            }
            return null;
        }
        /// <summary>
        /// Method that sends password to the server
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Returns true if password is correct, else returns false</returns>
        public bool isPasswordCorrect(string password)
        {
            if (password == "central") return true; //УДАЛИТЬ ПОСКОРЕЕЕЕЕ
               using (HttpClient hc = new HttpClient())
                {
                    //POST REQUEST
                }
            return false;

        }
        /// <summary>
        /// Method that gets all links to the data that has relation to this risk
        /// </summary>
        /// <param name="risk"></param>
        /// <returns>List of all links with risk data</returns>
        public async<List<string>> getRiskInfo(Risk risk)
        {
            //здесь мы получаем список ссылок на ресурсы по этому риску
            using (HttpClient hc = new HttpClient())
            {
                //GET REQUEST   
            }
            return null;
        }
    }
}
