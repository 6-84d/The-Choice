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
    /// Interaction logic for SharesInfo.xaml
    /// </summary>
    public partial class SharesInfo : Page
    {
        private Frame mainFrame;
        public SharesInfo(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            DataContext = new SharesVM();
            this.Width = mainFrame.Width;
            this.Height = mainFrame.Height;
        }
    }
}
