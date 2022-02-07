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

namespace valentine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainLoad : Window
    {
        public MainLoad()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }


        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn2_MouseEnter(object sender, MouseEventArgs e)
        {
            int maxLeft = Convert.ToInt32(Grid1.ActualWidth - btn2.Width);
            int maxTop = Convert.ToInt32(Grid1.ActualHeight - btn2.Height);
            Random r = new Random();
            btn2.Margin = new Thickness(r.Next(maxLeft), r.Next(maxTop), 0, 0);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            No no = new No();
            no.Show();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Yes yes = new Yes();
            yes.Show();
        }
    }
}
