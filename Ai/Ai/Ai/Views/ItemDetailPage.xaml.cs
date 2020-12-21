using Ai.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Ai.Views
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