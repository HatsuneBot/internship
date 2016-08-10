using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinTreeApplication.Models
{
    public class Student
    {
        private string name;
        private string testName;
        private string date;
        private int rating;

        public Student (string _name, string _testName, string _date, int _rating)
        {
            name = _name;
            testName = _testName;
            date = _date;
            rating = _rating;
        }
        public int GetRating()
        {
            return rating; 
        }
    }
}