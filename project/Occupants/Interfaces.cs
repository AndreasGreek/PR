using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    public interface IHuman
    {
        String PassportID { get; set; }
        String Name { get; set; }
        String Surname { get; set; }
        DateTime BirthDay { get; set; }
        String Sex { get; set; }
        String Phone { get; set; }
        String Email { get; set; }
    }

    public interface IOccupant
    {
        Boolean Status { get; set; }
        Int32 RoomNumber { get; set; }

        DateTime DateIn { get; set; }
        DateTime DateLeave { get; set; }
        TimeSpan Duration { get; set; }
        Double CountedPayment{ get; set; }
        Double PaidPayment{ get; set; }
        Double Debt { get; set; }
        Int32 NumberInList { get; set; }
    }

    public interface IRoom
    {
        Int32 RoomNumber { get; set; }
        String Sex { get; set; }
        Int32 QuantityOfOccupants { get; set; }
        Int32 FreePlaces { get; set; }
        List<Occupant> Occupants { get; set; }
        Int16 Condition { get; set; }
    }
}