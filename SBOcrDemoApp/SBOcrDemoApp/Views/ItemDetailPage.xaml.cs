using SBOcrDemoApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SBOcrDemoApp.Views
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