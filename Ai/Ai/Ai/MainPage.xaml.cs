using Ai.Models;
using System;
using Xamarin.Forms;

namespace Ai
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void AddWord_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddWord
            {
                BindingContext = new Word()
            });
        }

        private void OnGenerateClicked(object sender, EventArgs e)
        {

        }
    }
}
