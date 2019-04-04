using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFamilyList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFamilyMemberPage : ContentPage
    {
        public AddFamilyMemberPage()
        {
            InitializeComponent();
        }

        async void AddButton_Clicked(object sender, EventArgs e)
        {
            Person person = new Person();

            person.FirstName = ???;
            person.LastName = ???;
            person.BirthDate = ???;

            await Navigation.PopAsync();
        }
    }
}