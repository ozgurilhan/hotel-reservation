using Reservation.Domain;
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
    public partial class frmHotelSave : Form
    {
        ICommonService _service;
        Hotel hotel;

        public frmHotelSave(ICommonService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void frmHotelSave_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                hotel = (Hotel)this.Tag;
                txtHotelName.Text = hotel.HotelName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (hotel == null)
            {
                _service.AddHotel(txtHotelName.Text);
                this.Hide();
                return;
            }

            _service.UpdateHotel(hotel.Id, hotel.HotelName);
            this.Hide();
        }
    }
}
