using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    public class Room:IRoom
    {
        protected Int32 m_roomNumber;
        protected String m_sex;
        protected Int32 m_quantityOfOccupants;
        protected Int32 m_freePlaces;
        protected List<Occupant> m_occupants;
        protected Int16 m_condition;

        public Room(Int32 roomNumber, Boolean sex, Int32 quantityOfOccupants, Int32 freePlaces, List<Occupant> occupants, Int16 condition) 
        { 
            Int32 m_roomNumber=roomNumber;
            Boolean m_sex=sex;
            Int32 m_quantityOfOccupants=quantityOfOccupants;
            Int32 m_freePlaces=freePlaces;
            List<Occupant> m_occupants=occupants;
            Int16 m_condition=condition;
        }

        public Room() 
        { 
        
        }
        ~Room() { }

        public Int32 RoomNumber 
        {
            set { m_roomNumber = value; }
            get { return m_roomNumber; }
        }
        public String Sex 
        {
            set { m_sex = value; }
            get { return m_sex; }
        }
        public Int32 QuantityOfOccupants 
        {
            set { m_quantityOfOccupants = value; }
            get { return m_quantityOfOccupants; } 
        }

        public Int32 FreePlaces 
        {
            set { m_freePlaces = value; }
            get { return m_freePlaces; } 
        }
        public List<Occupant> Occupants
        {
            set { m_occupants = value; }
            get { return m_occupants; }
        }
        public Int16 Condition
        {
            set { m_condition = value; }
            get { return m_condition; }
        }
    }
}
