using Reservation.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class frmLogin : Form
    {
        ICommonService _customerService;

        public frmLogin(ICommonService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var customer = _customerService.Login(txtUserName.Text, txtPassword.Text);
            if (customer == null)
            {
                MessageBox.Show("Invalid Username or password");
                return;
            }
            this.Tag = customer;
            this.Hide();
        }
    }
}
