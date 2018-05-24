//********************************************************************
//File: DataLayer.cs
//
//Purpose:  The class definition of DataLayer.   
//            
//Written by:  Kathleen Paulson
//
//Compiler:  Visual Studio 2017
//
//********************************************************************  

using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace CourseScheduling
{
    public class DataLayer
    {

        #region Private Member Variables

        private CourseCollection courses;
        

        #endregion

        #region Public Member Events
        public class CourseAddedEventArgs : EventArgs
        {
            public Course CourseAdded { get; set; }

            public CourseAddedEventArgs(Course c)
            {
                CourseAdded = c;
            }
        }

        public event EventHandler<CourseAddedEventArgs> CourseAddedEvent;

        public void FireCourseAddedEvent(Course c)
        {
            if (CourseAddedEvent == null)
                return;

            DataLayer.CourseAddedEventArgs evtArgs = new DataLayer.CourseAddedEventArgs(c);

            CourseAddedEvent(this, evtArgs);
        }

        #endregion

        #region Public Member Methods

        //*******************************************************
        //Method:  DataLayer
        //
        //Purpose:  Default constructor for DataLayer  
        //*******************************************************
        public DataLayer()
        {
            courses = new CourseCollection();            
        }


        //*******************************************************
        //Method:  Courses property
        //
        //Purpose:  Get and set id 
        //*******************************************************
        public CourseCollection Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        

        public void Initialize()
        {
            //Deserialize data from JSON files into member variables.
            #region JSON deserialization - Course

            string jsonFilebackup = "CourseJSON.txt";

            FileStream reader = new FileStream(jsonFilebackup, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(CourseCollection));

            courses = (CourseCollection)inputSerializer.ReadObject(reader);
            reader.Close();
            #endregion

        }

        public bool AddCourse(Course c)
        {
            //Add the passed in Course c to the Course Collection.
            //Write (serialize) the CourseCollection data back to the appropriate file.
            //Return true if successful(should always return true for this version).
            //Should fire a CourseAdded event.
            bool x = true;

            courses.Courses.Add(c);
            
            #region JSON serialization - Course

            string jsonFilebackup = "CourseJSON2.txt";
            System.IO.FileStream writer = new FileStream(jsonFilebackup, FileMode.Create,
               FileAccess.Write);

            DataContractJsonSerializer ser;

            ser = new DataContractJsonSerializer(typeof(CourseCollection));

            ser.WriteObject(writer, courses);

            writer.Close();
            #endregion
            


            //Fire event (notify listeners)
            FireCourseAddedEvent(c);

            
            return x;
        }

        

        #endregion




    }
}
