using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace The_choice.Resources.Pages
{
    /// <summary>
    /// Interaction logic for CurrencyInfo.xaml
    /// </summary>
    public partial class CurrencyInfo : Page
    {
        public CurrencyInfo(Frame mainFrame)
        {
            InitializeComponent();
            DataContext = new CurrencyListVM();
        }
    }
}
