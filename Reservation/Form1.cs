using Reservation.Domain;
using Reservation.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
       

        ICommonService _customerService;
        public Form1(ICommonService customerService)
        { 
            InitializeComponent();
            if (Shared.authenticatedUser == null)
            {
                frmLogin frmLogin = new frmLogin(customerService);
                frmLogin.ShowDialog();
                Shared.authenticatedUser = (Customer) frmLogin.Tag;
            }
            _customerService = customerService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
