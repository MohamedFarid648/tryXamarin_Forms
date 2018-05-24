using EApp3.Models;
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
	public partial class tryListview : ContentPage
	{
       async void  SelectedItem_Method(object sender,Xamarin.Forms.SelectedItemChangedEventArgs  e)
        {

            if (e.SelectedItem == null)
                return;
            var c = e.SelectedItem as Company;
            await Navigation.PushAsync(new SelectedItem(c));

            MyListView.SelectedItem = null; 
        }
		public tryListview ()
		{
			InitializeComponent ();

            MyListView.ItemSelected += SelectedItem_Method;

            List<Company> companies = new List<Company>()
            {

                new Company(){Name="Zad Solutions",ReutersCode=154,ReportPrice="2000",Description="Software Company",Sector="Information Technology",Industry="Software",Currency="Dollar",Id=1,ImageURL="http://lorempixel.com/100/100/people/2"},
                new Company(){Name="IBM",ReutersCode=154,ReportPrice="9000",Description="Software Company",Sector="Information Technology",Industry="ITService",Currency="Dollar",Id=2,ImageURL="http://lorempixel.com/100/100/people/2"},
                new Company(){Name="Microsoft",ReutersCode=154,ReportPrice="6000",Description="Software Company",Sector="Information Technology",Industry="Internet Software & Services",Currency="Dollar",Id=3,ImageURL="http://lorempixel.com/100/100/people/2"},
                new Company(){Name="Google",ReutersCode=154,ReportPrice="7000",Description="Software Company",Sector="Information Technology",Industry="ITService",Currency="Dollar",Id=4,ImageURL="http://lorempixel.com/100/100/people/2"},
                new Company(){Name="Apple",ReutersCode=154,ReportPrice="11000",Description="Software Company",Sector="Information Technology",Industry="ITService",Currency="Dollar",Id=5,ImageURL="http://lorempixel.com/100/100/people/2"},
                new Company(){Name="Itworx",ReutersCode=154,ReportPrice="8000",Description="Software Company",Sector="Information Technology",Industry="ITService",Currency="Dollar",Id=6,ImageURL="http://lorempixel.com/100/100/people/2"},

            };
            MyListView.ItemsSource = companies;
		}
	}
}