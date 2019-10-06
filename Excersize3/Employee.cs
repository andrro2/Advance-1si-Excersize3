using System;

namespace Excersize3
{
    internal class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(string name, System.DateTime birthDate,Gender gender,  int salary, string profession) : base(name, birthDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        internal Room Room { get => room; set => room = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object CloneWithRoom() 
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }

        public override string ToString()
        {
            return "Name: "+ name + " Birth date: "+ birthDate + " Gender: " + gender + " Salary: " + salary + " Profession: "+ profession +" Room: "+ room;
        }


    }
}