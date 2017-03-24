using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bayards_Safety_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Risks : ContentPage
	{
		public Risks (string sectionId)
		{
			InitializeComponent ();
            var Collection = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                Collection.Add(sectionId + " Risk " + i.ToString());
            }
            BindingContext = Collection;
            Title = "Risks";
        }
        private void RiskButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RiskDetails(((Button)sender).CommandParameter.ToString(), ((Button)sender).CommandParameter.ToString()));
        }
    }
}
