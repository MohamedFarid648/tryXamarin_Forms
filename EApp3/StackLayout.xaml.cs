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
	public partial class StackLayout : ContentPage
	{
        Person p;
		public StackLayout ()
		{
			InitializeComponent ();
            p = new Person();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            p.Name = Name.Text;
            p.Password = Pass.Text;
            await Navigation.PushAsync(new Instgram(p));
        }
    }
    public class Person
    {

        public string Name { get; set; }
        public string Password { get; set; }
    }
}