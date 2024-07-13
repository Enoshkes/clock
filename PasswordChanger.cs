using clock_time.Model;
using clock_time.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static clock_time.Utils.Validations;

namespace clock_time
{
    internal partial class PasswordChangerForm : Form
    {
        private readonly EmployeeModel _currentEmployee;
        private readonly IEmployeeService _employeeService;
        private readonly IPasswordService _passwordService;
        public PasswordChangerForm(EmployeeModel currentEmployee)
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _passwordService = new PasswordService();
            _currentEmployee = currentEmployee;
        }

        private bool IsOldPasswordCorrect(string pwd)
        {
            PasswordModel? passwordModel = _passwordService.ReadByEmployeeId(_currentEmployee.Id);
            return passwordModel != null && passwordModel.Password == pwd;
        }

        private bool IsConfirmPasswordValid(string pwd1, string pwd2) => pwd1 == pwd2;

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            string oldPassword = OldPasswordTextBox.Text;
            string newPassword = NewPasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            if (AnyEmptyString(oldPassword, newPassword, confirmPassword))
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            if (!IsOldPasswordCorrect(oldPassword)) 
            {
                MessageBox.Show("Invalid old password");
                return;
            }

            if (!IsConfirmPasswordValid(newPassword, confirmPassword))
            {
                MessageBox.Show("New password and Confirm password are not the same");
                return;
            } 

            bool success = _passwordService.UpdatePassword(
                _currentEmployee.Id, 
                newPassword
            );
            if (success) 
            {
                MessageBox.Show("Password updated successfully");
                ShiftTrackerForm shiftTrackerForm = new (_currentEmployee);
                Hide();
                shiftTrackerForm.Show();
            }

        }
    }
}
