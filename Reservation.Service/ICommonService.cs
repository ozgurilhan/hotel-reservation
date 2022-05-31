using Reservation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Service
{
    public interface ICommonService
    {
        void AddCustomer(string firstName, string lastName);
        void DeleteCustomer(int customerId);
        void UpdateCustomer(int customerId, string firstName, string lastName);
        Customer Login(string userName, string password);

        void AddHotel(string hotelName);
        void UpdateHotel(int hotelId, string hotelName);
        void DeleteHotel(int hotelId);
        List<Hotel> GetHotels();
        List<Hotel> GetHotelsBySearch(string hotelName);

        void AddRoom(int hotelId, string roomName, int price);
        void UpdateRoom(int roomId, string roomName, int price);
        void DeleteRoom(int roomId);
        List<Room> GetRoomsByHotelId(int hotelId);

        void AddBooking(int roomId, DateTime checkin, DateTime checkout, int price, int customerId);
        List<BookingView> GetBookings(int? customerId, bool isAdmin);
        void DeleteBooking(int id);

        //void AddRoomAvailability(int roomId, DateTime Day);
        //void UpdateRoomAvailability(int roomId, bool reserved);

    }

}
