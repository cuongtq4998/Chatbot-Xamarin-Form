using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ChatBot.Services;
using ChatBot.Views;

namespace ChatBot
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            //MainPage = new ChatPage();
            MainPage = new NavigationPage(new Home1Page());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
