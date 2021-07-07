using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Xml.Serialization;

namespace ExpenseTracker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddExpense : ContentPage
    {

        Expense expense;
        public AddExpense()
        {
            InitializeComponent();
            expense = new Expense();
        }

        
        private async void ExpenseSaveBtn_Clicked(object sender, EventArgs e)
        {

           /* expense.Name = UserExpenseEntryName.Text;
            expense.category = CategoryPicker.Title;
            expense.Amount = Int32.Parse(UserExpenseEntryAmount.Text);*/

            var expense =(Expense)BindingContext;
            string Filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Expenses.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Expense>));//initialises the serialiser
                                                                                //this should read stuff from the xml and update the static collection with the data
                                                                                //deserialize the data already stored
            var allexpenses = new List<Expense>();
            allexpenses.Add(expense);

            Stream writer = new FileStream(Filepath, FileMode.Create);//initialises the writer

            serializer.Serialize(writer, allexpenses);//Writes to the file
            writer.Close();
            await Navigation.PopModalAsync();
        }
    

        private async void ExpenseCancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            expense.SelectedDate = thatDayDatePicker.Date;
            
        }
    }
}