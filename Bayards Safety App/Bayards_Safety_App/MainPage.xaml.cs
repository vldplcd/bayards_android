using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

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
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string filename = Path.Combine(path, "settings.txt");
                if (File.Exists(filename))
                {                    
                    string[] lines = File.ReadAllLines(filename);
                    if(Encoding.UTF8.GetString(Convert.FromBase64String(lines[0])) == "1")
                        Navigation.PushAsync(new Sections());
                    else
                        Navigation.PushAsync(new UserAgreementPage());
                }
                else
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
