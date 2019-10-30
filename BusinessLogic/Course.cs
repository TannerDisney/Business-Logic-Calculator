using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course(string courseName)
        {
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; } = "STAFF";

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        {
            get => CourseName;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        {
            get => NumberOfCredits;
            set
            {
                if (value >= 30 || value == 0)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
