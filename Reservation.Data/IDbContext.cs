using System.Data;

namespace Reservation.Data
{
    public interface IDbContext
    {
        IDbConnection Connection { get; }
    }
}
