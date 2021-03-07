using CalculatorTestWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorTestWebService.Controllers
{
    public class CalculatorController :ApiController
    {
        
        public int GetAdd(int num1, int num2)
        {
            return num1 + num2;
        }
      
        public int GetSubtract(int num1, int num2)
        {
            return num1 - num2;
        }
        
        public int GetMultiply(int num1, int num2)
        {
            
            return num1 * num2;
        }
        public float GetDivide(int num1, int num2)
        {
            if (num2 == 0)
                  throw new ArgumentException("Cannot divide by zero!");
              
            return num1 / num2;
        }
        public int getRandomNumber()
        {
            return new Random().Next(1,1000);
        }
    }
}
