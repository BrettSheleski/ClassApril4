using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFamilyList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Page familyListPage = new MainPage();

            NavigationPage navPage = new NavigationPage(familyListPage);

            MainPage = navPage;
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
