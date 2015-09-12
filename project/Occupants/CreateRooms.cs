using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    public class CreateRooms:Room
    {
        List<Room> RoomsDB = new List<Room>();

        public CreateRooms() { }
        ~CreateRooms() { }
        //method for creation of empty rooms
        public IEnumerable<Room> CreateEmptyRooms()
        {
            for (Int16 floor = 1; floor < 5; floor++)
            {
                for (Int16 door = 1; door < 9; door++)
                {
                    Room room = new Room();
                    room.RoomNumber = Convert.ToInt32(floor.ToString() + "0" + door.ToString());
                    
                    room.FreePlaces = 4;

                    //set the condition of rooms;
                    if (floor == 1 || floor == 4) { room.Condition = 8; }
                    else if (floor == 2) { room.Condition = 9; }
                    else if (floor == 3) { room.Condition = 10; }

                    RoomsDB.Add(room);
                }
            }
            //return rooms in outside program
            foreach(Room room in RoomsDB)
            {
                yield return room;
            }
        }        
    }
}
