using ErindringsApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ErindringsApp.Views
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