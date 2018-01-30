﻿using Xamarin.Forms;

namespace CarrouselView
{
    public partial class MainPage : ContentPage
	{

        private MainViewModel ViewModel
        {
            get { return BindingContext as MainViewModel; }
            set { BindingContext = value; }
        }

        public MainPage()
		{
			InitializeComponent();

            ViewModel = new MainViewModel();
            BindingContext = ViewModel;
		}
	}
}