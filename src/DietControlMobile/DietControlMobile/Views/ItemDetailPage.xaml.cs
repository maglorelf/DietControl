using DietControlMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DietControlMobile.Views
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