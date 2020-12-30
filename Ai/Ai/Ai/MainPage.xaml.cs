using Ai.Models;
using System;
using System.Linq;
using Xamarin.Forms;

namespace Ai
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }

        async void AddWord_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddWord
            {
                BindingContext = new Word()
            });
        }

        async void OnGenerateClicked(object sender, EventArgs e)
        {

            var subjects = await App.Database.GetAllSubjects();
            var verbs = await App.Database.GetAllVerbs();
            var places = await App.Database.GetAllPlaces();

            if (!subjects.Any() || !verbs.Any() || !places.Any())
            {
                DependencyService.Get<IToast>().Show("Not enough words to generate something");
            }
        }
    }
}
