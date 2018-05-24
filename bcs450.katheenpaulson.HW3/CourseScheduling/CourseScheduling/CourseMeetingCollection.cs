//********************************************************************
//File: CourseMeetingCollection.cs
//
//Purpose:  The class definition of CourseMeetingCollection.   
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
    public class CourseMeetingCollection
    {
        #region Private Member Variables
        [DataMember(Name = "courseMeetings")]
        private List<CourseMeeting> courseMeetings;

        #endregion

        #region Properties
        public List<CourseMeeting> CourseMeetings
        {
            get { return courseMeetings; }
            set { courseMeetings = value; }
        }

        #endregion

        #region Methods
        //*******************************************************
        //Method:  CourseMeetingCollection
        //
        //Purpose:  Default constructor for CourseMeetingCollection 
        //*******************************************************
        public CourseMeetingCollection()
        {
            courseMeetings = new List<CourseMeeting>();
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
            if (courseMeetings != null)
                foreach (var x in courseMeetings)
                    result += String.Format("roomId = {0}, courseId = {1}, professorId = {2}, dayTime = {3}\n",
                x.RoomId, x.CourseId, x.ProfessorId, x.DayTime);

            return result;
        }

        public CourseMeeting FindByCourse(int courseID)
        {
            // Find a course meeting by its courseID.
            CourseMeeting result = courseMeetings.Find(
            delegate (CourseMeeting m_CourseMeeting)
            {
                return m_CourseMeeting.CourseId == courseID;
            }
            );

            return result;
        }

        public CourseMeeting FindByProfessor(int professorID)
        {
            // Find a course meeting by professor id

            CourseMeeting result = courseMeetings.Find(
            delegate (CourseMeeting m_CourseMeeting)
            {
                return m_CourseMeeting.ProfessorId == professorID;
            }
            );

            return result;
        }

        public CourseMeeting FindByRoom(int roomID)
        {
            // Find a course meeting by room id

            CourseMeeting result = courseMeetings.Find(
            delegate (CourseMeeting m_CourseMeeting)
            {
                return m_CourseMeeting.RoomId == roomID;
            }
            );

            return result;
        }

        #endregion

    }
}
