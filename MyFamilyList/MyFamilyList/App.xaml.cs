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

        public static ObservableCollection<Person> FamilyMembers { get; } = new ObservableCollection<Person>();

        protected override void OnStart()
        {
            base.OnStart();

            PopulateFamilyMembers();
        }

        private void PopulateFamilyMembers()
        {
            if (this.Properties.ContainsKey("FamilyMembersJson"))
            {
                string json = (string)this.Properties["FamilyMembersJson"];

                if (!string.IsNullOrWhiteSpace(json))
                {
                    // deserialize the json to a list of Person's
                    List<Person> people = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(json);


                    // add the Person's to FamilyMembers
                    foreach (var person in people)
                    {
                        FamilyMembers.Add(person);
                    }
                }
            }
        }

        protected override void OnSleep()
        {
            base.OnSleep();
            
            SaveFamilyMembers();
        }

        private void SaveFamilyMembers()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(FamilyMembers);

            Properties["FamilyMembersJson"] = json;
        }
    }
}
