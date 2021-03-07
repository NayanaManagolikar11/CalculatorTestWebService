using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorTestWebService.Models
{
    // object to store calculator data in sql database
    public class CalculatorItem
    {
        public int Id { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }
        public char Operator { get; set; }
    }
}