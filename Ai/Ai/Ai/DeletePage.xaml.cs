using Ai.Models;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePage : ContentPage
    {
        public DeletePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var items = await App.Database.GetAll();
            listView.ItemsSource = items.OrderBy(i => i.Name);
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var word = e.SelectedItem as Word;
            await App.Database.Delete(word);
            DependencyService.Get<IToast>().Show($"{word.Name} deleted.");
            var items = await App.Database.GetAll();
            listView.ItemsSource = items.OrderByDescending(i => i.Created);
        }
    }
}