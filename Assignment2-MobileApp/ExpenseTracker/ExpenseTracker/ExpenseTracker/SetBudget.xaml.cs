using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseTracker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetBudget : ContentPage
    {
        Expense ex;
        public SetBudget()
        {
            InitializeComponent();
        }

        private async void OnSetBudgetSubmitButtonClicked(object sender, EventArgs e)
        {
         //      ex.Budgetformonth = Int32.Parse(BudgetEntry.Text);
                await Navigation.PushModalAsync(new MainPage());
          
        }
    }
        }
