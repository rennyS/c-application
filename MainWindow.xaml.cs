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

namespace MyFirstApp
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

        private void btnMyOKButton_Click(object sender, RoutedEventArgs e)
        {
            int age;
            age = Convert.ToInt32(txtAge.Text);
            if (age >= 67)
            {
                lblAgeOutput.Content = "retired";
            }
            else
            {
                int retirementage;
                retirementage = 67;
                retirementage = retirementage - age;

                lblAgeOutput.Content = "you need to wait " + retirementage + " years" ;
            }
        }

        private void btnAdvanced_Click(object sender, RoutedEventArgs e)
        {
            lblCourse.Visibility = Visibility.Visible;
            cboCourse.Visibility = Visibility.Visible;

        }

     
       

      

   
    }
}
