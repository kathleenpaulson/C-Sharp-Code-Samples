//********************************************************************
//File: Course.cs
//
//Purpose:  This DLL contains the class definitions of Course, Professor,  
//          Room, CourseMeeting, and CourseScheduleUnitTesting.
//            
//Written by:  Kathleen Paulson
//
//Compiler:  Visual Studio 2015
//
//********************************************************************  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1dll
{
    public class Course
    {
        #region Private Member Variables
        private int id;
        private string designator;
        private string number;
        private string title;
        private string description;
        private int credits;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Designator
        {
            get { return designator; }
            set { designator = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

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
            id = 0;
            designator = "None";
            number = "101";
            title = "Sample Course";
            description = "None";
            credits = 3;
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("id = {0}, designator = {1}, number = {2}, title = {3}, description = {4}, credits = {5}",
                id, designator, number, title, description, credits);
        }
        #endregion
    }

    public class Professor
    {
        #region Private Member Variables
        private int id;
        private string name;
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
            id = 0;
            name = "unknown";
            phone = "(631) 555-1212";
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("id = {0}, name = {1}, phone = {2}",
                id, name, phone);
        }
        #endregion        
    }

    public class Room
    {
        #region Private Member Variables
        private int id;
        private string location;
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
            id = 0;
            location = "unknown";
            capacity = 20;
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("id = {0}, location = {1}, capacity = {2}",
                id, location, capacity);
        }
        #endregion        
    }

    public class CourseMeeting
    {
        #region Private Member Variables
        private int roomId;
        private int courseId;
        private int professorId;
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
            roomId = 101;
            courseId = 1000;
            professorId = 9000;
            dayTime = "Tuesday 9am - 10:40am";
        }

        //*******************************************************
        //Method:  override ToString
        //
        //Purpose:  Return a string of descriptive text and
        //          data for all member variables
        //*******************************************************
        public override string ToString()
        {
            return string.Format("roomId = {0}, courseId = {1}, professorId = {2}, dayTime = {3}",
                roomId, courseId, professorId, dayTime);
        }
        #endregion
    }

    public class CourseScheduleUnitTesting
    {
        #region Methods
        //*******************************************************
        //Method:  UnitTestCourse
        //
        //Purpose:  Declares an instance of Course and performs
        //          unit testing on all the properties of that
        //          instance.  Called from Main method of 
        //          Homework1ConsoleApp.Program.
        //*******************************************************
        public void UnitTestCourse()
        {
            Course myCourse = new Course();

            Console.WriteLine("********************");
            Console.WriteLine("Unit Testing: Course");
            Console.WriteLine("********************");

            //Unit test of Id property
            int testId = 50;
            myCourse.Id = testId;

            if (myCourse.Id == testId)
            {
                Console.WriteLine("Course Id Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Id Property: FAIL!");
            }

            //Unit test of designator property
            string testDesignator = "test designator";
            myCourse.Designator = testDesignator;

            if (myCourse.Designator == testDesignator)
            {
                Console.WriteLine("Course designator Property: Pass");
            }
            else
            {
                Console.WriteLine("Course designator Property: FAIL!");
            }

            //Unit test of number property (which is a string variable)
            string testNumber = "99";
            myCourse.Number = testNumber;

            if (myCourse.Number == testNumber)
            {
                Console.WriteLine("Course Number Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Number Property: FAIL!");
            }

            //Unit test of title property 
            string testTitle = "test title";
            myCourse.Title = testTitle;

            if (myCourse.Title == testTitle)
            {
                Console.WriteLine("Course Title Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Title Property: FAIL!");
            }

            //Unit test of description property 
            string testDescription = "test description";
            myCourse.Description = testDescription;

            if (myCourse.Description == testDescription)
            {
                Console.WriteLine("Course Description Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Description Property: FAIL!");
            }

            //Unit test of Credits property
            int testCredits = 60;
            myCourse.Credits = testCredits;

            if (myCourse.Credits == testCredits)
            {
                Console.WriteLine("Course Credits Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Credits Property: FAIL!");
            }

            Console.WriteLine();
        }

        //*******************************************************
        //Method:  UnitTestProfessor
        //
        //Purpose:  Declares an instance of Professor and performs
        //          unit testing on all the properties of that
        //          instance.  Called from Main method of 
        //          Homework1ConsoleApp.Program.
        //*******************************************************
        public void UnitTestProfessor()
        {
            Professor myProfessor = new Professor();

            Console.WriteLine("***********************");
            Console.WriteLine("Unit Testing: Professor");
            Console.WriteLine("***********************");

            //Unit test of Id property
            int testId = 50;
            myProfessor.Id = testId;

            if (myProfessor.Id == testId)
            {
                Console.WriteLine("Professor Id Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor Id Property: FAIL!");
            }

            //Unit test of Name property
            string testName = "Jeff Gold";
            myProfessor.Name = testName;

            if (myProfessor.Name == testName)
            {
                Console.WriteLine("Professor Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor Name Property: FAIL!");
            }

            //Unit test of Phone property
            string testPhone = "000-000-000";
            myProfessor.Phone = testPhone;

            if (myProfessor.Phone == testPhone)
            {
                Console.WriteLine("Professor Phone Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor Phone Property: FAIL!");
            }

            Console.WriteLine();
        }

        //*******************************************************
        //Method:  UnitTestRoom
        //
        //Purpose:  Declares an instance of Room and performs
        //          unit testing on all the properties of that
        //          instance.  Called from Main method of 
        //          Homework1ConsoleApp.Program.
        //*******************************************************
        public void UnitTestRoom()
        {
            Room myRoom = new Room();

            Console.WriteLine("********************");
            Console.WriteLine("Unit Testing: Room");
            Console.WriteLine("********************");

            //Unit test of Id property
            int testRoom = 105;
            myRoom.Id = testRoom;

            if (myRoom.Id == testRoom)
            {
                Console.WriteLine("Room Id Property: Pass");
            }
            else
            {
                Console.WriteLine("Room Id Property: FAIL!");
            }

            //Unit test of Location property
            string testLocation = "test location";
            myRoom.Location = testLocation;

            if (myRoom.Location == testLocation)
            {
                Console.WriteLine("Room Location Property: Pass");
            }
            else
            {
                Console.WriteLine("Room Location Property: FAIL!");
            }

            //Unit test of Capacity property
            int testCapacity = 40;
            myRoom.Capacity = testCapacity;

            if (myRoom.Capacity == testCapacity)
            {
                Console.WriteLine("Room Capacity Property: Pass");
            }
            else
            {
                Console.WriteLine("Room Capacity Property: FAIL!");
            }

            Console.WriteLine();
        }

        //*******************************************************
        //Method:  UnitTestCourseMeeting
        //
        //Purpose:  Declares an instance of CourseMeeting and performs
        //          unit testing on all the properties of that
        //          instance.  Called from Main method of 
        //          Homework1ConsoleApp.Program.
        //*******************************************************
        public void UnitTestCourseMeeting()
        {
            CourseMeeting myCourseMeeting = new CourseMeeting();

            Console.WriteLine("***************************");
            Console.WriteLine("Unit Testing: CourseMeeting");
            Console.WriteLine("***************************");

            //Unit test of RoomId property
            int testRoomId = 34;
            myCourseMeeting.RoomId = testRoomId;

            if (myCourseMeeting.RoomId == testRoomId)
            {
                Console.WriteLine("CourseMeeting RoomId Property: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting RoomId Property: FAIL!");
            }

            //Unit test of CourseId property
            int testCourseId = 600;
            myCourseMeeting.CourseId = testCourseId;

            if (myCourseMeeting.CourseId == testCourseId)
            {
                Console.WriteLine("CourseMeeting CourseId Property: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting CourseId Property: FAIL!");
            }

            //Unit test of ProfessorId property
            int testProfessorId = 600;
            myCourseMeeting.ProfessorId = testProfessorId;

            if (myCourseMeeting.ProfessorId == testProfessorId)
            {
                Console.WriteLine("CourseMeeting ProfessorId Property: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting ProfessorId Property: FAIL!");
            }

            //Unit test of DayTime property
            string testDayTime = "Mon 10-11am";
            myCourseMeeting.DayTime = testDayTime;

            if (myCourseMeeting.DayTime == testDayTime)
            {
                Console.WriteLine("CourseMeeting DayTime Property: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting DayTime Property: FAIL!");
            }

            Console.WriteLine();
        }

        #endregion
    }
}

