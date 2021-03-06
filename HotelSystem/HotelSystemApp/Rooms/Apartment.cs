﻿namespace HotelSystemApp.Rooms
{
    using System;

    public class Apartment : Room
    {
        private int numberOfBathRooms;

        public Apartment(int numberOfRoom, decimal initialPrice, int numberOfBathRooms)
            : base(numberOfRoom, initialPrice)
        {
            this.NumberOfBathRooms = numberOfBathRooms;
            this.NumberOfBeds = 4;
        }

        public override int NumberOfBeds { get; protected set; }

        public int NumberOfBathRooms
        {
            get
            {
                return this.numberOfBathRooms;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid number of bathrooms");
                }

                this.numberOfBathRooms = value;
            }
        }
    }
}
