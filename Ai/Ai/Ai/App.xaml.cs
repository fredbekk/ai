using Ai.Data;
using System;
using System.IO;
using Xamarin.Forms;

namespace Ai
{
    public partial class App : Application
    {
        public static WordDatabase database;

        public static WordDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new WordDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Words.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
