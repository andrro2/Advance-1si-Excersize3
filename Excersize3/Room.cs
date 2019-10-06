using System;

namespace Excersize3
{
    class Room
    {
        private int roomNumber;

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }

        public override string ToString()
        {
            return Convert.ToString(roomNumber);
        }
    }


}