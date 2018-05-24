//********************************************************************
//File: ProfessorCollection.cs
//
//Purpose:  The class definition of ProfessorCollection.   
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
}
