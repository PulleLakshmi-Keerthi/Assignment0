using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SfPIEChart.ViewModel;
using Xamarin.Forms;

namespace SfPIEChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ChartVM();
        }
    }
}
