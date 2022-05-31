using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Reservation.Data;
using Reservation.Domain;

namespace Reservation.Service
{
    public class CommonService : ICommonService
    {
        IRepository<Customer> _customerRepository;
        IRepository<Hotel> _hotelRepository;
        IRepository<Room> _roomRepository;
        IRepository<Booking> _bookingRepository;

        public CommonService(IRepository<Customer> customerRepository, IRepository<Hotel> hotelRepository, IRepository<Room> roomRepository, IRepository<Booking> bookingRepository)
        {
            _customerRepository = customerRepository;
            _hotelRepository = hotelRepository;
            _roomRepository = roomRepository;
            _bookingRepository = bookingRepository;
        }

        public void AddCustomer(string firstName, string lastName)
        {
            _customerRepository.Insert(new Customer { FirstName = firstName, LastName = lastName });
        }

        public void AddHotel(string hotelName)
        {
            _hotelRepository.Insert(new Hotel { HotelName = hotelName });
        }

        public void AddBooking(int roomId, DateTime checkin, DateTime checkout, int price, int customerId)
        {
            int bookingId = _bookingRepository.Insert(new Booking
            {
                CheckInTime = checkin,
                CheckOutTime = checkout,
                CustomerId = customerId,
                RoomId = roomId,
                Price = price,
            });
        }

        public void AddRoom(int hotelId, string roomName, int price)
        {
            _roomRepository.Insert(new Room { HotelId = hotelId, RoomName = roomName });
        }

        public void DeleteCustomer(int customerId)
        {
            _customerRepository.Delete(customerId);
        }

        public void DeleteHotel(int hotelId)
        {
            _hotelRepository.Delete(hotelId);
        }

        public void DeleteRoom(int roomId)
        {
            _roomRepository.Delete(roomId);
        }

        public Customer Login(string userName, string password)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("username", userName);
            parameters.Add("password", password);

            return _customerRepository.ExecuteReader<Customer>("sel_login", parameters).FirstOrDefault();
        }

        public void UpdateCustomer(int customerId, string firstName, string lastName)
        {
            var customer = _customerRepository.GetById(customerId);

            if (customer != null)
            {
                customer.FirstName = firstName;
                customer.LastName = lastName;
            }
        }

        public void UpdateHotel(int hotelId, string hotelName)
        {
            var hotel = _hotelRepository.GetById(hotelId);
            if (hotel != null)
            {
                hotel.HotelName = hotelName;
            }
        }

        public void UpdateRoom(int roomId, string roomNname, int price)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", roomId);
            var room = _customerRepository.ExecuteReader<Room>("sel_get_room_by_id", parameters).FirstOrDefault();

            if (room != null)
            {
                room.RoomName = roomNname;
                room.Price = price;
                _roomRepository.Update(room);
            }
        }

        public List<Hotel> GetHotels()
        {
            return _hotelRepository.GetList().ToList();
        }

        public List<Hotel> GetHotelsBySearch(string hotelName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("hotelName", hotelName);
            var hotels = _hotelRepository.ExecuteReader<Hotel>("sel_search_hotels", parameters).ToList();
            return hotels;
        }

        public List<Room> GetRoomsByHotelId(int hotelId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("hotelId", hotelId);
            var rooms = _hotelRepository.ExecuteReader<Room>("sel_rooms_by_hotel_id", parameters).ToList();
            return rooms;
        }

        public List<BookingView> GetBookings(int? customerId, bool isAdmin)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("customerId", customerId);
            parameters.Add("isAdmin", isAdmin);


            List<BookingView> bookings = _bookingRepository.ExecuteReader<BookingView>("sel_bookings_by_customer_id", parameters).ToList();
            return bookings;
        }

        public void DeleteBooking(int id)
        {
            _bookingRepository.Delete(id);
        }
    }
}