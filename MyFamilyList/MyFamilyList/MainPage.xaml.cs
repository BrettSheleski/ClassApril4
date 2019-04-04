using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFamilyList
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            FamilyListView.ItemsSource = App.FamilyMembers;
        }

        private async void AddFamilyMemberButton_Clicked(object sender, EventArgs e)
        {
            AddFamilyMemberPage addPage = new AddFamilyMemberPage();

            await Navigation.PushAsync(addPage);
        }
    }
}
