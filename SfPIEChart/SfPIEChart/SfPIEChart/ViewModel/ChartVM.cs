using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SfPIEChart.Model;

namespace SfPIEChart.ViewModel
{
    public class ChartVM
    {
        public ObservableCollection<Book> Data { get; set; }

        public ChartVM()
        {
            Data = new ObservableCollection<Book>();
            FillData();
        }

        private void FillData()
        {
            Book obj = new Book()
            {
                Name = "Book1",
                Quantity = 20
            };
            Data.Add(obj);

            Book obj2 = new Book()
            {
                Name = "Book2",
                Quantity = 30
            };
            Data.Add(obj2);


            Book obj3 = new Book()
            {
                Name = "Book3",
                Quantity = 10
            };
            Data.Add(obj3);

        }


    }
}
