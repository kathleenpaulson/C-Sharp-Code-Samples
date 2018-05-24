//********************************************************************
//File: Program.cs
//
//Purpose:  Contains the class definition of Program.  Program 
//          is a menu-driven console app for the CourseScheduling dll classes.
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
using CourseScheduling;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace BCS450.kathleenpaulson.homework
{
    class Program
    {
        //*******************************************************
        //Method:  Main
        //
        //Purpose:  Displays the menu, and processes
        //          the user's selection.  
        //*******************************************************
        static void Main(string[] args)
        {
            //Instantiate all classes in the Course.cs DLL
            CourseCollection myCourseCollection = new CourseCollection();
            ProfessorCollection myProfessorCollection = new ProfessorCollection();
            RoomCollection myRoomCollection = new RoomCollection();
            CourseMeetingCollection myCourseMeetingCollection = new CourseMeetingCollection();
            Course myCourse = new Course();
            
            //These statements are used to create test data for the Course test input files
            myCourseCollection.Courses.Add(new Course(1, "BCS", "101", "Programming Concepts and Problem Solving", "Test description for BCS 101", 3));
            myCourseCollection.Courses.Add(new Course(2, "BCS", "102", "Computer Concepts and Applications", "Test description for BCS 102", 3));

            //These statements are used to create test data for the Professor test input files
            myProfessorCollection.Professors.Add(new Professor(1, "Arthur Hoskey", "(631)420-2435"));
            myProfessorCollection.Professors.Add(new Professor(2, "Jie Li", "(631)420-2435"));


            //These statements are used to create test data for the Room test input files
            myRoomCollection.Rooms.Add(new Room(1, "Whitman 128", 26));
            myRoomCollection.Rooms.Add(new Room(2, "Whitman 215", 20));


            //These statements are used to create test data for the CourseMeeting test input files
            myCourseMeetingCollection.CourseMeetings.Add(new CourseMeeting(1, 1, 1, "MW 8:00am - 9:15am"));
            myCourseMeetingCollection.CourseMeetings.Add(new CourseMeeting(1, 2, 2, "MW 9:25am - 10:40am"));

            string userChoice = null;

            do
            {
                Console.WriteLine("Course Schedule Menu");
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - Read CourseCollection from JSON file");
                Console.WriteLine("2 - Read CourseCollection from XML file");
                Console.WriteLine("3 - Write CourseCollection to JSON file");
                Console.WriteLine("4 - Write CourseCollection to XML file");
                Console.WriteLine("5 - Display CourseCollection data on screen");
                Console.WriteLine("6 - Show course data by id");
                Console.WriteLine("7 - Read ProfessorCollection from JSON file");
                Console.WriteLine("8 - Write ProfessorCollection to JSON file");
                Console.WriteLine("9 - Display ProfessorCollection data on screen");
                Console.WriteLine("10 - Read CourseMeetingCollection from JSON file");
                Console.WriteLine("11 - Write CourseMeetingCollection to JSON file");
                Console.WriteLine("12 - Display CourseMeetingCollection data on screen");
                Console.WriteLine("13 - Exit");
                Console.WriteLine("Enter Choice: ");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    #region Course Menu selection
                    case "1":
                        {
                            #region JSON deserialization - Course
                            Console.WriteLine("Enter your filename: ");
                            string jsonFile1 = Console.ReadLine();
                                                        
                            FileStream reader = new FileStream(jsonFile1, FileMode.Open, FileAccess.Read);

                            DataContractJsonSerializer inputSerializer;
                            inputSerializer = new DataContractJsonSerializer(typeof(CourseCollection));

                            myCourseCollection = (CourseCollection) inputSerializer.ReadObject(reader);
                            reader.Close();
                            #endregion
                        }

                        break;
                    case "2":
                        {
                            #region XML deserialization - Course
                            Console.WriteLine("Enter your filename: ");
                            string jsonFile2 = Console.ReadLine();

                            FileStream reader = new FileStream(jsonFile2, FileMode.Open, FileAccess.Read);

                            DataContractSerializer inputSerializer;
                            inputSerializer = new DataContractSerializer(typeof(CourseCollection));

                            myCourseCollection = (CourseCollection)inputSerializer.ReadObject(reader);
                            reader.Close();
                            #endregion
                        }

                        break;
                    case "3":
                        {
                            #region JSON serialization - Course
                            Console.WriteLine("Enter your filename: ");
                            string jsonFile3 = Console.ReadLine();
                            System.IO.FileStream writer = new FileStream(jsonFile3, FileMode.Create,
                               FileAccess.Write);

                            DataContractJsonSerializer ser;
                            
                            ser = new DataContractJsonSerializer(typeof(CourseCollection));                            

                            ser.WriteObject(writer, myCourseCollection);
                            
                            writer.Close();
                            #endregion
                        }
                        break;
                    case "4":
                        {
                            #region XML serialization - Course
                            Console.WriteLine("Enter your filename: ");
                            string jsonFile4 = Console.ReadLine();
                            System.IO.FileStream writer = new FileStream(jsonFile4, FileMode.Create,
                               FileAccess.Write);

                            DataContractSerializer ser;
                            ser = new DataContractSerializer(typeof(CourseCollection));

                            ser.WriteObject(writer, myCourseCollection);
                            writer.Close();
                            #endregion
                        }

                        break;

                    case "5":
                        Console.WriteLine(myCourseCollection.ToString());
                        break;

                    case "6":
                        Console.WriteLine("Enter a course id: ");
                        string userInput = Console.ReadLine();
                        int number1 = Convert.ToInt32(userInput);
                        myCourse = myCourseCollection.Find(number1);
                        Console.WriteLine(myCourse.ToString());
                        break;

                    case "7":
                        {
                            #region JSON deserialization - Professor
                            Console.WriteLine("Enter your filename: ");
                            string jsonFile7 = Console.ReadLine();

                            FileStream reader = new FileStream(jsonFile7, FileMode.Open, FileAccess.Read);

                            DataContractJsonSerializer inputSerializer;
                            inputSerializer = new DataContractJsonSerializer(typeof(ProfessorCollection));

                            myProfessorCollection = (ProfessorCollection)inputSerializer.ReadObject(reader);
                            reader.Close();
                            #endregion
                        }
                        break;

                    case "8":
                        {
                            #region JSON serialization - Professor

                            Console.WriteLine("Enter your filename: ");
                            string jsonFile8 = Console.ReadLine();
                            System.IO.FileStream writer = new FileStream(jsonFile8, FileMode.Create,
                               FileAccess.Write);

                            DataContractJsonSerializer ser;
                            ser = new DataContractJsonSerializer(typeof(ProfessorCollection));

                            ser.WriteObject(writer, myProfessorCollection);
                            writer.Close();
                            #endregion
                        }
                        break;

                    case "9":
                        Console.WriteLine(myProfessorCollection.ToString());
                        break;

                    case "10":
                        {
                            #region JSON deserialization - CourseMeeting Collection

                            Console.WriteLine("Enter your filename: ");
                            string jsonFile10 = Console.ReadLine();

                            FileStream reader = new FileStream(jsonFile10, FileMode.Open, FileAccess.Read);

                            DataContractJsonSerializer inputSerializer;
                            inputSerializer = new DataContractJsonSerializer(typeof(CourseMeetingCollection));

                            myCourseMeetingCollection = (CourseMeetingCollection)inputSerializer.ReadObject(reader);
                            reader.Close();
                            #endregion
                        }
                        break;

                    case "11":
                        {
                            #region JSON serialization - CourseMeeting Collection

                            Console.WriteLine("Enter your filename: ");
                            string jsonFile11 = Console.ReadLine();
                            System.IO.FileStream writer = new FileStream(jsonFile11, FileMode.Create,
                               FileAccess.Write);

                            DataContractJsonSerializer ser;
                            ser = new DataContractJsonSerializer(typeof(CourseMeetingCollection));

                            ser.WriteObject(writer, myCourseMeetingCollection);
                            writer.Close();
                            #endregion
                        }
                        break;

                    case "12":
                        Console.WriteLine(myCourseMeetingCollection.ToString());
                        break;

                    #endregion

                    case "13":
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid choice. Please try again.");
                        break;
                }

            } while (userChoice != "13");

            //When user selects "13", program is terminated.
            Environment.Exit(0);
        }
    }
}

