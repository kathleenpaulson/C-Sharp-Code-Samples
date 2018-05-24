//********************************************************************
//File: CourseMeeting.cs
//
//Purpose:  The class definition of CourseMeeting.   
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
    public class CourseMeeting
    {
        #region Private Member Variables
        [DataMember(Name = "roomId")]
        private int roomId;
        [DataMember(Name = "courseId")]
        private int courseId;
        [DataMember(Name = "professorId")]
        private int professorId;
        [DataMember(Name = "dayTime")]
        private string dayTime;
        #endregion

        #region Properties
        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }

        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public int ProfessorId
        {
            get { return professorId; }
            set { professorId = value; }
        }

        public string DayTime
        {
            get { return dayTime; }
            set { dayTime = value; }
        }
        #endregion

        #region Methods
        //*******************************************************
        //Method:  CourseMeeting
        //
        //Purpose:  Default constructor for CourseMeeting 
        //*******************************************************
        public CourseMeeting()
        {
            roomId = 1;
            courseId = 2;
            professorId = 1;
            dayTime = "MW 8:00am-9:15am";
        }

        //*******************************************************
        //Method:  CourseMeeting
        //
        //Purpose:  Constructor for CourseMeeting (for testing purposes)
        //          This constructor was used to populate a CourseMeeting
        //          instance to create test input files for 
        //          Assignment 2
        //*******************************************************
        public CourseMeeting(int m_roomId, int m_courseId, int m_professorId,
            string m_dayTime)
        {
            roomId = m_roomId;
            courseId = m_courseId;
            professorId = m_professorId;
            dayTime = m_dayTime;
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("roomId = {0}, courseId = {1}, professorId = {2}, dayTime = {3}\n",
                roomId, courseId, professorId, dayTime);
        }
        #endregion
    }
}
