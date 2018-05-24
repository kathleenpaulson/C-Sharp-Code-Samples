//********************************************************************
//File: RoomCollection.cs
//
//Purpose:  The class definition of RoomCollection.   
//            
//Written by:  Kathleen Paulson
//
//Compiler:  Visual Studio 2017
//
//********************************************************************  

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CourseScheduling
{
    [DataContract]
    public class RoomCollection
    {
        #region Private Member Variables
        [DataMember(Name = "rooms")]
        private List<Room> rooms;

        #endregion

        #region Properties
        public List<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        #endregion

        #region Methods
        //*******************************************************
        //Method:  RoomCollection
        //
        //Purpose:  Default constructor for RoomCollection 
        //*******************************************************
        public RoomCollection()
        {
            rooms = new List<Room>();
        }


        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            string result = "";
            if (rooms != null)
                foreach (var x in rooms)
                    result += String.Format("id = {0}, location = {1}, capacity = {2}\n",
                x.Id, x.Location, x.Capacity);

            return result;
        }

        public Room Find(int roomID)
        {
            // Find a room by ID.
            Room result = rooms.Find(
            delegate (Room m_Room)
            {
                return m_Room.Id == roomID;
            }
            );

            return result;
        }

        public Room Find(string location)
        {
            // Find a professor by name.

            Room result = rooms.Find(
            delegate (Room m_Room)
            {
                return m_Room.Location == location;
            }
            );

            return result;
        }
        #endregion

    }
}
