//********************************************************************
//File: CourseCollection.cs
//
//Purpose:  The class definition of CourseCollection.   
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
    public class CourseCollection
    {
        #region Private Member Variables
        [DataMember(Name = "courses")]
        private List<Course> courses;

        #endregion

        #region Properties
        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        #endregion

        #region Methods
        //*******************************************************
        //Method:  CourseCollection
        //
        //Purpose:  Default constructor for CourseCollection 
        //*******************************************************
        public CourseCollection()
        {
            courses = new List<Course>();
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
            if (courses != null)
                foreach (var x in courses)
                    result += String.Format("id = {0}, designator = {1}, number = {2}, title = {3}, description = {4}, credits = {5}\n",
                    x.Id, x.Designator, x.Number, x.Title, x.Description, x.Credits);
            return result;
        }

        public Course Find(int courseID)
        {
            // Find a course by its ID.
            Course result = courses.Find(
            delegate (Course m_Course)
            {
                return m_Course.Id == courseID;
            }
            );

            return result;
        }

        public Course Find(string designator, string number)
        {
            // Find a course by its designator and number.

            Course result = courses.Find(
            delegate (Course m_Course)
            {
                return m_Course.Designator == designator && m_Course.Number == number;
            }
            );

            return result;
        }
        #endregion

    }
}
