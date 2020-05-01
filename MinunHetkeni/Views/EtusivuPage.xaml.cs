using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MinunHetkeni
{
    public partial class EtusivuPage : ContentPage
    {
        public EtusivuPage()
        {
            InitializeComponent();
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("EnsimmäinenKategoriaPage");
        }

        //kun klikataan viewtä nii menee tähän routeen.

        

    }
}
