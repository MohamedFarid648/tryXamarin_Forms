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
	public partial class GridLayout : ContentPage
	{
		public GridLayout ()
		{

            InitializeComponent ();
            /*
            for (int i = 0; i < 10; i++)
            {
                MySecondFlexLayout.Children.Add(new Button()
                {

                    Text = i.ToString(),
                    BackgroundColor = Color.White,
                    CornerRadius = 2,TextColor=Color.Black,
                    BorderColor = Color.Gray

                });
            }
            MySecondFlexLayout.Children.Add(new Button()
            {

                Text = "0",
                BackgroundColor = Color.White,
                CornerRadius = 2,
                TextColor = Color.Black,
                BorderColor = Color.Gray,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions=LayoutOptions.CenterAndExpand
            

            });*/
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {

        }

        private void NumberButtonClick(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            Result.Text += b.Text ;
        }
    }
}