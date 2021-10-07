using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightClientEmployeeService
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
          //  EmployeeService.EmployeeServiceClient consoleClient = new EmployeeService.EmployeeServiceClient();
        //    consoleClient.DoWorkCompleted += new EventHandler<EmployeeService.DoWorkCompletedEventArgs>(consoleClient_DoWorkCompleted);
        //    consoleClient.DoWorkAsync();
        }

        //private void consoleClient_DoWorkCompleted(object sender, EmployeeService.DoWorkCompletedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void btnGetEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeServiceReference.EmployeeServiceClient client = new EmployeeServiceReference.EmployeeServiceClient();
            if (txtBoxId.Text.ToString() != "")
            {
                EmployeeServiceReference.Employee employee = client.GetEmployeeById(Convert.ToInt32(txtBoxId.Text));

                if (employee == null)
                {
                   

                    txtBoxName.Text = txtBoxId.Text = txtBoxDOB.Text = txtBoxGender.Text = "";

                    txtBlockMessage.Text = "Employee does not found.".ToString();
                    return;
                }


                txtBoxName.Text = employee.Name;

                txtBoxGender.Text = employee.Gender;
                txtBoxDOB.Text = employee.DateOfBirth.ToShortDateString();
                // lblMessage.ForeColor = Color.Green;
              //  txtBlockMessage.Foreground = Brushes.Green;

                txtBlockMessage.Text = "Employee retrieved";
            }
            else
            {
                // txtBlockMessage.Foreground = Color.Add(C);
                //txtBlockMessage.Foreground = Brushes.Red;

                txtBlockMessage.Text = "Invalid Id. Please enter correct id.";
            }

        }

        private void btnsaveEmployee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
