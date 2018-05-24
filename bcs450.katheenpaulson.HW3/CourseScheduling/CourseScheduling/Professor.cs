//********************************************************************
//File: Professor.cs
//
//Purpose:  The class definition of Professor.           
//            
//Written by:  Kathleen Paulson
//
//Compiler:  Visual Studio 2017
//
//********************************************************************  

using System.Runtime.Serialization;

namespace CourseScheduling
{
    [DataContract]
    public class Professor
    {
        #region Private Member Variables
        [DataMember(Name = "id")]
        private int id;
        [DataMember(Name = "name")]
        private string name;
        [DataMember(Name = "phone")]
        private string phone;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion

        #region Methods
        //*******************************************************
        //Method:  Professor
        //
        //Purpose:  Default constructor for Professor  
        //*******************************************************
        public Professor()
        {
            id = 1;
            name = "Professor Name";
            phone = "(631) 555-1212";
        }

        //*******************************************************
        //Method:  Course
        //
        //Purpose:  Constructor for Professor (for testing purposes)
        //          This constructor was used to populate a Professor
        //          instance to create test input files for 
        //          Assignment 2
        //*******************************************************
        public Professor(int m_id, string m_name, string m_phone)
        {
            id = m_id;
            name = m_name;
            phone = m_phone;
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("id = {0}, name = {1}, phone = {2}\n",
                id, name, phone);
        }
        #endregion
    }
    
}
