

using clock_time.Model;
using clock_time.Service;
using System.Collections.Immutable;
using static clock_time.Utils.Validations;

namespace clock_time
{
    public partial class Form1 : Form
    {
        private readonly IEmployeeService _employeeService;

        public Form1()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowTrackerForm(EmployeeModel employee)
        {
            ShiftTrackerForm shiftTrackerForm = new(employee);
            shiftTrackerForm.Show();
            Hide();
        }

        private void ShowPasswordChangerForm(EmployeeModel employee)
        {
            PasswordChangerForm passwordChangerForm = new(employee);
            passwordChangerForm.Show();
            Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string identityNumber = IdentityTextBox.Text;
            string password = PasswordTextBox.Text;

            if (AnyEmptyString(identityNumber, password))
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            var (employee, isPwdExpired) = _employeeService.Authenticate(identityNumber, password);

            if (employee == null)
            {
                MessageBox.Show("Login failure, one of the fields is invalid");
                return;
            }

            if (isPwdExpired)
            {
                MessageBox.Show("Password expaired, please update");
                ShowPasswordChangerForm(employee);
                return;
            }

            ShowTrackerForm(employee);

        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
