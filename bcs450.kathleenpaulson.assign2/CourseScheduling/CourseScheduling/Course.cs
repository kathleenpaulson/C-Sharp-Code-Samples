//********************************************************************
//File: Course.cs
//
//Purpose:  This is a DLL contains the class definitions of Course, Professor,  
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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

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

    [DataContract]
    public class ProfessorCollection
    {
        #region Private Member Variables
        [DataMember(Name = "professors")]
        private List<Professor> professors;

        #endregion

        #region Properties
        public List<Professor> Professors
        {
            get { return professors; }
            set { professors = value; }
        }

        #endregion

        #region Methods
        //*******************************************************
        //Method:  ProfessorCollection
        //
        //Purpose:  Default constructor for ProfessorCollection 
        //*******************************************************
        public ProfessorCollection()
        {
            professors = new List<Professor>();
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
            if (professors != null)
                foreach (var x in professors)
                    result += String.Format("id = {0}, name = {1}, phone = {2}\n",
                x.Id, x.Name, x.Phone);

            return result;
        }

        public Professor Find(int professorID)
        {
            // Find a professor by ID.
            Professor result = professors.Find(
            delegate (Professor m_Professor)
            {
                return m_Professor.Id == professorID;
            }
            );

            return result;
        }

        public Professor Find(string name)
        {
            // Find a Professor by name.

            Professor result = professors.Find(
            delegate (Professor m_Professor)
            {
                return m_Professor.Name == name;
            }
            );

            return result;
        }
        #endregion

    }

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