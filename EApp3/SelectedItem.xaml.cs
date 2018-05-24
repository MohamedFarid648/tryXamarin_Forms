﻿using EApp3.Models;
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
	public partial class SelectedItem : ContentPage
	{
		public SelectedItem (Company C)
		{
			InitializeComponent ();

            BindingContext = C;
		}
	}
}