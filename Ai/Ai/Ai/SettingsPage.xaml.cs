using Ai.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        async void AddWordsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddWord
            {
                BindingContext = new Word()
            });
        }

        async void DeleteWordsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeletePage());
        }
    }
}