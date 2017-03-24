using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Bayards_Safety_App
{
	public partial class MainPage : ContentPage
	{
       
		public MainPage()
		{
			InitializeComponent();
		}

        private string password = string.Empty;
        private void ContinueButton_Clicked(object sender, EventArgs e)
        {
            API api = new API();
            if(api.isPasswordCorrect(PasswordEntry.Text))
            {
                Navigation.PushAsync(new UserAgreementPage());
            }
            else
            {
                DisplayAlert("Warning", "The password is incorrect", "OK");
            }
            
        }

        private void PasswordEntry_Completed(object sender, EventArgs e)
        {
           
            password = ((Entry)sender).Text;
        }
    }
}
