//********************************************************************
//File: CourseScheduleUnitTesting.cs
//
//Purpose:  The class definition of CourseScheduleUnitTesting.   
//            
//Written by:  Kathleen Paulson
//
//Compiler:  Visual Studio 2017
//
//********************************************************************  

using System;

namespace CourseScheduling
{
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
