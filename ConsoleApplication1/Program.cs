using Bayards_Safety_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        static async void Main(string[] args)
        {
            API api = new API();
            var t = await api.getCompleteSectionsList("english");
        }
    }
}
