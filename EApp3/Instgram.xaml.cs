using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EApp3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Instgram : ContentPage
	{
		public Instgram (Person p)
		{
           

            InitializeComponent();

            if (!string.IsNullOrEmpty(p.Name))
                UserName.Text = p.Name;
            else
                UserName.Text = "No User Data";
        }

        private async  void BackButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        protected override bool OnBackButtonPressed()
        {
            //To prevent back button of the device for returned to the pervious page
            //(Disaple backbutton functionality)
            return true;
        }

        private async void GotoRelativeLayoutButton(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new RelativeLayout());
        }

        private  void GotoMasterDetailedButton(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new tryMasterDetail());

        }

        private async void GotoAbsoluteLayoutButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tryAbsoluteLayout());
        }

        private async void GotoGridLayoutButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayout());

        }

        private async void GotoTabbedPageButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EApp3.TabbedPage1());

        }

        private async void GotoPDFPageButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new  tryPDF());

        }

        private async void GotoListViewPageButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tryListview());

        }
    }
}