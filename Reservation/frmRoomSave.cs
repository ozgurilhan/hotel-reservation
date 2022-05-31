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
    public partial class frmRoomSave : Form
    {
        ICommonService _service;
        Room room;

        public frmRoomSave(ICommonService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (room.Id == 0)
            {
                _service.AddRoom(room.HotelId, txtRoomName.Text, int.Parse(txtPrice.Text));
            }
            else
            {
                _service.UpdateRoom(room.Id, txtRoomName.Text, int.Parse(txtPrice.Text));
            }
           
            this.Hide();
        }

        private void frmRoomSave_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                room = (Room)this.Tag;
                txtRoomName.Text = room.RoomName;
                txtPrice.Text = room.Price.ToString();
            }
        }
    }
}
