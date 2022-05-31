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
    public partial class frmBookings : Form
    {
        ICommonService _service;

        public frmBookings(ICommonService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void frmBookings_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = Shared.authenticatedUser.IsAdmin;
            ListBookings();
        }

        void ListBookings()
        {
            gvBookings.DataSource = _service.GetBookings(Shared.authenticatedUser.Id, Shared.authenticatedUser.IsAdmin);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("You should select a booking first");
                return;
            }

            int bookingId = Convert.ToInt32(gvBookings.SelectedRows[0].Cells["id"].Value);
            _service.DeleteBooking(bookingId);
            ListBookings();
        }
    }
}
