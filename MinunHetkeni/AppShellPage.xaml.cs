using System;
using System.Collections.Generic;
using MinunHetkeni.Views;
using Xamarin.Forms;

namespace MinunHetkeni
{
    public partial class AppShellPage : Shell
    {
        public AppShellPage()
        {
            
            InitializeComponent();
            Routing.RegisterRoute("EnsimmäinenKategoriaPage", typeof(EnsimmäinenKategoriaPage));     //shell routing kategorian alasivulle.
        }
    }
}
