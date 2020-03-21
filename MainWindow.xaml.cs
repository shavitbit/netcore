using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace wpfTestCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + txt1.Text);
            MessageBox.Show("i am trying to add somhting to the git gub environment ");

  //          WebRequest req = WebRequest.Create(@"https://od-api-demo.oxforddictionaries.com:443/api/v1/domains/en/es");
  //          req.Method = "GET";
  //          req.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username:password"));
  //          //req.Credentials = new NetworkCredential("username", "password");
  //          HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
  //          MessageBox.Show(resp.StatusDescription);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test n 2");
        }
    }
}
 