using perrosPaseo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace perrosPaseo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}