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
	public partial class RiskDetails : ContentPage
	{
		public RiskDetails (string riskId, string riskName)
		{
			InitializeComponent ();
            Header.Text = riskName;
		}
        private void NextButton_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new RiskDetails(((Button)sender).CommandParameter.ToString(), ((Button)sender).CommandParameter.ToString()));
        }
        private void PrevButton_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new RiskDetails(((Button)sender).CommandParameter.ToString(), ((Button)sender).CommandParameter.ToString()));
        }
    }
}
