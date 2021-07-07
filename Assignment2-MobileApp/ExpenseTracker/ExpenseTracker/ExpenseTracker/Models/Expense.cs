using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime SelectedDate { get; set; }
        public string category { get; set; }
        

    }
}
