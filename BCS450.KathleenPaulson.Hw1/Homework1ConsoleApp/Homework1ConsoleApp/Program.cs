//********************************************************************
//File: Program.cs
//
//Purpose:  Contains the class definition of Program.  Program 
//          is a menu-driven console app that does unit testing of
//          the class properties of homework1dll.dll.  
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
using homework1dll;

namespace Homework1ConsoleApp
{
    class Program
    {
        //*******************************************************
        //Method:  Main
        //
        //Purpose:  Displays the unit testing menu, and processes
        //          the user's selection.  
        //*******************************************************
        static void Main(string[] args)
        {
            CourseScheduleUnitTesting myUnitTest = new CourseScheduleUnitTesting();

            string userChoice = null;

            do
            {
                Console.WriteLine("Course Schedule Menu");
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - Unit Test Course");
                Console.WriteLine("2 - Unit Test Professor");
                Console.WriteLine("3 - Unit Test Room");
                Console.WriteLine("4 - Unit Test CourseMeeting");
                Console.WriteLine("5 - Exit");
                Console.WriteLine("Enter Choice: ");

                userChoice = Console.ReadLine();
               
                switch (userChoice)
                {
                    #region Unit Testing calls
                    case "1":
                        myUnitTest.UnitTestCourse();
                        break;
                    case "2":
                        myUnitTest.UnitTestProfessor();
                        break;
                    case "3":
                        myUnitTest.UnitTestRoom();
                        break;
                    case "4":
                        myUnitTest.UnitTestCourseMeeting();
                        break;
                    #endregion

                    case "5":
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid choice. Please try again.");
                        break;
                }

            } while (userChoice != "5");

            //When user selects "5", program is terminated.
            Environment.Exit(0);            
        }
    }
}
