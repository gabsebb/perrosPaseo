using perrosPaseo.ViewModels;
using perrosPaseo.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace perrosPaseo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
