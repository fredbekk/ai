using Ai.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddWord : ContentPage
    {
        public AddWord()
        {
            InitializeComponent();
        }

        async void SaveSubjectClicked(object sender, EventArgs e)
        {
            var word = (Word)BindingContext;

            word.Created = DateTime.UtcNow;

            await App.Database.SaveSubject(word);
            await Navigation.PopAsync();
        }

        async void SaveVerbClicked(object sender, EventArgs e)
        {
            var word = (Word)BindingContext;

            word.Created = DateTime.UtcNow;

            await App.Database.SaveVerb(word);
            await Navigation.PopAsync();
        }

        async void SavePlaceClicked(object sender, EventArgs e)
        {
            var word = (Word)BindingContext;

            word.Created = DateTime.UtcNow;

            await App.Database.SavePlace(word);
            await Navigation.PopAsync();
        }
    }
}