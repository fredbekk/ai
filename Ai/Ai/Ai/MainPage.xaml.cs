using Ai.Engine;
using Ai.Models;
using Ai.ViewModels;
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

        async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage
            {
            });
        }

        async void OnGenerateClicked(object sender, EventArgs e)
        {

            var subjects = await App.Database.GetAll(WordType.Subject);
            var verbs = await App.Database.GetAll(WordType.Verb);
            var places = await App.Database.GetAll(WordType.Place);

            if (!subjects.Any() || !verbs.Any() || !places.Any())
            {
                DependencyService.Get<IToast>().Show("Not enough words to generate something");
            }
            else
            {
                var generator = new Generator();
                var thing = generator.Generate(subjects, verbs, places);

                var result = new Result() { Text = $"Draw a {thing.Item1} that is {thing.Item2} in/on {thing.Item3}" };

                await Navigation.PushAsync(new ResultPage
                {
                    BindingContext = result
                });
            }
        }
    }
}
