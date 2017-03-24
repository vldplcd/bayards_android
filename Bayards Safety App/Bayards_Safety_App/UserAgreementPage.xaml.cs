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
    public partial class UserAgreementPage : ContentPage
    {
        public UserAgreementPage()
        {
            InitializeComponent();
           
        }
        private void ContinueButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sections());
        }
        private void onSwitchToggled(object sender, EventArgs e)
        {
        }
    }
}
