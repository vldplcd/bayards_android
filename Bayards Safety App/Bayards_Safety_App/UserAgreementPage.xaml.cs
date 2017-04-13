using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bayards_Safety_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserAgreementPage : ContentPage
    {
        public UserAgreementPage()
        {
            InitializeComponent();
           
        }
        private void ContinueButton_Clicked(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "settings.txt");
            File.WriteAllText(filename, Convert.ToBase64String(Encoding.UTF8.GetBytes("1")));
            Navigation.PushAsync(new Sections());
            
        }
        private void onSwitchToggled(object sender, EventArgs e)
        {
        }

        
        
}
}
