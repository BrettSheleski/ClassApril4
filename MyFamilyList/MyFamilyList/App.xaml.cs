using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        public static FamilyMemberDatabase Database { get; } = new FamilyMemberDatabase();

        public static ObservableCollection<Person> FamilyMembers { get; } = new ObservableCollection<Person>();

        protected override void OnStart()
        {
            base.OnStart();

            PopulateFamilyMembers();
        }

        private void PopulateFamilyMembers()
        {
            // retrieve all family members from the database
            List<Person> peopleFromDatabase = Database.GetAll();

            // add them to the FamilyMembers collection

            foreach(Person person in peopleFromDatabase)
            {
                FamilyMembers.Add(person);
            }
        }

    }
}
