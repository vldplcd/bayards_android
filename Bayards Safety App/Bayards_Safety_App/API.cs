using System;
using System.Collections.Generic;
using System.Text;
using Bayards_Safety_App.Entities;
using System.Net.Http;

namespace Bayards_Safety_App
{
    public class API
    {
        /// <summary>
        /// Method that gets the complete list of sections; language is specified with language variable
        /// </summary>
        /// <returns>List of sections</returns>
        public List<Section> getCompleteSectionsList(string language)
        {
            using (HttpClient hc = new HttpClient())
            {
                //GET REQUEST
            }
            return null;
        }
        /// <summary>
        /// Method that gets the list of all risks from specified Section
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        public List<Risk> getRisksList(Section section)
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
        public List<string> getRiskInfo(Risk risk)
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
