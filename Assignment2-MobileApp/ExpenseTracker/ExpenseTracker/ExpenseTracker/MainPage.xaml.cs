using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ExpenseTracker.Models;
using Xamarin.Forms;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
           Expense expenses = new Expense();

            //get all expenses and set data context
            
       /*     ExpenseListview.ItemsSource = monthlyExpense.ExpenseList.OrderByDescending(x => x.Date);
            MonthBudget.Text = monthlyExpense.Budget.ToString("C", CultureInfo.CurrentCulture);
            
            balance = monthlyExpense.Balance;
            BalanceDisplay.Text = balance.ToString("C", CultureInfo.CurrentCulture);
            EditDeleteStack.IsVisible = false;*/

        }
        private async void OnAddExpenseClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushModalAsync(new AddExpense 
            {
                BindingContext =new Expense()
            });
        }

        private void AllexpensesListview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var expense = new Expense();
            string Filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Expenses.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Expense>));//initialises the serialiser
                                                                                //this should read stuff from the xml and update the static collection with the data
            
            Stream reader = new FileStream(Filepath, FileMode.Open);//initialises the writer
            var expenses = new List<Expense>();
           serializer.Deserialize(reader);//reads the file
           reader.Close();
        }
    }
}
