//********************************************************************
//File: Course.cs
//
//Purpose:  The class definition of Course.   
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
    public class Course
    {
        #region Private Member Variables
        [DataMember(Name = "id")]
        private int id;
        [DataMember(Name = "designator")]
        private string designator;
        [DataMember(Name = "number")]
        private string number;
        [DataMember(Name = "title")]
        private string title;
        [DataMember(Name = "description")]
        private string description;
        [DataMember(Name = "credits")]
        private int credits;
        #endregion

        #region Properties
        //*******************************************************
        //Method:  Id property
        //
        //Purpose:  Get and set id 
        //*******************************************************
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //*******************************************************
        //Method:  Designator property
        //
        //Purpose:  Get and set designator
        //*******************************************************
        public string Designator
        {
            get { return designator; }
            set { designator = value; }
        }

        //*******************************************************
        //Method:  Number property
        //
        //Purpose:  Get and set number 
        //*******************************************************
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        //*******************************************************
        //Method:  Title property
        //
        //Purpose:  Get and set title
        //*******************************************************
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        //*******************************************************
        //Method:  Description property
        //
        //Purpose:  Get and set description 
        //*******************************************************
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //*******************************************************
        //Method:  Credits property
        //
        //Purpose:  Get and set credits 
        //*******************************************************
        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        #endregion

        #region Methods

        //*******************************************************
        //Method:  Course
        //
        //Purpose:  Default constructor for Course  
        //*******************************************************
        public Course()
        {
            id = 1;
            designator = "BCS";
            number = "000";
            title = "Title of Programming Course";
            description = "Description of programming course.";
            credits = 3;
        }

        //*******************************************************
        //Method:  Course
        //
        //Purpose:  Constructor for Course (for testing purposes)
        //          This constructor was used to populate a Course
        //          instance to create test input files for 
        //          Assignment 2
        //*******************************************************
        public Course(int m_id, string m_designator, string m_number, 
            string m_title, string m_description, int m_credits)
        {
            id = m_id;
            designator = m_designator;
            number = m_number;
            title = m_title;
            description = m_description;
            credits = m_credits;
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("id = {0}, designator = {1}, number = {2}, title = {3}, description = {4}, credits = {5}\n",
                id, designator, number, title, description, credits);
        }
        #endregion
    }
}