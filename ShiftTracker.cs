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

namespace clock_time
{
    internal partial class ShiftTrackerForm : Form
    {
        private readonly EmployeeModel _currentEmployee;
        private readonly ITimeService _timeService;

        public ShiftTrackerForm(EmployeeModel currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            _timeService = new TimeService();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            var entryTime = EntryTimePicker.Value;
            var exitTime = ExitTimePicker.Value;

            bool success = _timeService.UpdateTime(entryTime, exitTime, _currentEmployee.Id);

            if (success)
            {
                MessageBox.Show("Time was inserted successfully");
                Application.Exit();
            }


        }
    }
}
