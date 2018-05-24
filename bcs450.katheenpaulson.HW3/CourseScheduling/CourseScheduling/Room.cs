//********************************************************************
//File: Room.cs
//
//Purpose:  The class definition of Room.   
//            
//Written by:  Kathleen Paulson
//
//Compiler:  Visual Studio 2017
//
//********************************************************************  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseScheduling
{
   
    [DataContract]
    public class Room
    {
        #region Private Member Variables
        [DataMember(Name = "id")]
        private int id;
        [DataMember(Name = "location")]
        private string location;
        [DataMember(Name = "capacity")]
        private int capacity;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        #endregion

        #region Methods
        //*******************************************************
        //Method:  Room
        //
        //Purpose:  Default constructor for Room  
        //*******************************************************
        public Room()
        {
            id = 1;
            location = "Campus location";
            capacity = 26;
        }

        //*******************************************************
        //Method:  Room
        //
        //Purpose:  Constructor for Room (for testing purposes)
        //          This constructor was used to populate a Room
        //          instance to create test input files for 
        //          Assignment 2
        //*******************************************************
        public Room(int m_id, string m_location, int m_capacity)
        {
            id = m_id;
            location = m_location;
            capacity = m_capacity;
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("id = {0}, location = {1}, capacity = {2}\n",
                id, location, capacity);
        }
        #endregion
    }
    
}
