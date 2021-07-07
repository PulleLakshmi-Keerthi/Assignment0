using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseTracker
{
    public partial class App : Application
    {
        public App()
        {
            //Licence
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDcwMDQzQDMxMzkyZTMyMmUzMEloK01pV2N6VytyOFRiTkxxTXU4YVNXaWwxVWJuSkpvcENmTGQzemVYTlU9");
            
            InitializeComponent();

             //MainPage = new MainPage();
            //MainPage = new AddExpense();
            MainPage = new SetBudget();
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
