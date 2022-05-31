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
    public partial class frmHotels : Form
    {
        ICommonService _service;
        Hotel selectedHotel;
        Room selectedRoom;

        public frmHotels(ICommonService service)
        {
            _service = service;
            InitializeComponent();

            if (Shared.authenticatedUser == null)
            {
                frmLogin frmLogin = new frmLogin(service);
                frmLogin.ShowDialog();
                Shared.authenticatedUser = (Customer)frmLogin.Tag;
            }
        }

        private void txtHotel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            frmHotelSave frm = new frmHotelSave(_service);
            frm.ShowDialog();
            ListHotels();
        }

        private void frmHotels_Load(object sender, EventArgs e)
        {
            gbAdminHotels.Visible = Shared.authenticatedUser.IsAdmin;
            gbAdminRooms.Visible = Shared.authenticatedUser.IsAdmin;
            ListHotels();
            ListBookingsOnCalendar();
        }


        private void lbHotels_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtHotel_TextChanged(object sender, EventArgs e)
        {
            var hotels = _service.GetHotelsBySearch(txtHotel.Text);
            lbHotels.Items.Clear();
            foreach (var hotel in hotels)
            {
                lbHotels.Items.Add(hotel);
            }
        }

        private void lbHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            selectedHotel = (Hotel)lbHotels.SelectedItem;
            selectedRoom = null;
            var rooms = _service.GetRoomsByHotelId(selectedHotel.Id);
            foreach (var room in rooms)
            {
                lbRooms.Items.Add(room);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            SaveRoom(new Room { HotelId = selectedHotel.Id });
        }

        void SaveRoom(Room room)
        {
            if (selectedHotel == null)
            {
                MessageBox.Show("You should choice a hotel first");
                return;
            }

            frmRoomSave frm = new frmRoomSave(_service);
            frm.Tag = room;
            frm.ShowDialog();
            ListHotels();
            ListRooms();
        }

        void ListHotels()
        {
            var hotels = _service.GetHotels();

            //gvHotels.DataSource = _service.GetHotels();
            lbHotels.Items.Clear();
            foreach (var hotel in hotels)
            {
                lbHotels.Items.Add(hotel);
            }
        }

        void ListRooms()
        {
            var rooms = _service.GetRoomsByHotelId(selectedHotel.Id);

            //gvHotels.DataSource = _service.GetHotels();
            lbRooms.Items.Clear();
            foreach (var room in rooms)
            {
                lbRooms.Items.Add(room);
            }
        }


        private void lbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoom = (Room)lbRooms.SelectedItem;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            var difference = calendar.SelectionRange.End - calendar.SelectionRange.Start;
            var daysToStay = (int)difference.TotalDays;
            if (daysToStay < 1)
            {
                MessageBox.Show("You should choice a date range to book!");
                return;
            }

            if (selectedRoom == null)
            {
                MessageBox.Show("You should choice a room");
                return;
            }

            _service.AddBooking(selectedRoom.Id, calendar.SelectionRange.Start, calendar.SelectionRange.End, selectedRoom.Price * daysToStay, Shared.authenticatedUser.Id);
            ListBookingsOnCalendar();
            ShowBookings();
        }

        private void showBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBookings();
        }

        private void bnUpdateRoom_Click(object sender, EventArgs e)
        {
            SaveRoom(selectedRoom);
        }

        void ShowBookings()
        {
            frmBookings frm = new frmBookings(_service);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedHotel != null)
            {
                _service.DeleteHotel(selectedHotel.Id);
                ListHotels();
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (selectedRoom != null)
            {
                _service.DeleteRoom(selectedRoom.Id);
                ListRooms();
            }
        }

        void ListBookingsOnCalendar()
        {
            var bookingViews = _service.GetBookings(null, true);
            //calendar.MinDate = DateTime.Today;
            List<DateTime> boldedDates = new List<DateTime>();

            foreach (var b in bookingViews)
            {
                int days = (int)(b.CheckOutTime - b.CheckInTime).TotalDays;

                for (int i = 0; i < days; i++)
                {
                    DateTime day = b.CheckInTime.AddDays(i);
                    if (!boldedDates.Contains(day))
                    {
                        boldedDates.Add(day);
                    }
                }
                calendar.SelectionRange.Start = DateTime.MinValue;
                calendar.SelectionRange.End = DateTime.MinValue;
                calendar.BoldedDates = boldedDates.ToArray();
            }
        }
    }
}
