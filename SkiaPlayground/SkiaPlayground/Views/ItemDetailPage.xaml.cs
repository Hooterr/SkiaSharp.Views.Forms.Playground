using SkiaPlayground.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SkiaPlayground.Views
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