using CalculatorDataAccess;
using CalculatorTestWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorTestWebService.Controllers
{
    public class DatabaseController : ApiController
    {
        // GET: api/Database
        public IEnumerable<CalculatorResult> Get()
        {
            using (CalculatorDBEntities entities = new CalculatorDBEntities())
            {
                return entities.CalculatorResults.ToList();
            }
        }

        // GET: api/Database/5
        public CalculatorResult Get(int id)
        {
            using (CalculatorDBEntities entities = new CalculatorDBEntities())
            {
                return entities.CalculatorResults.FirstOrDefault();
            }
        }

        // POST: api/Database
        public void Post([FromBody]CalculatorItem item)
        {
            using (CalculatorDBEntities entities = new CalculatorDBEntities())
            {
                // return entities.CalculatorResults.FirstOrDefault();
                entities.CalculatorResults.Add(new CalculatorResult()
                {
                    Id = item.Id,
                    FirstNumber = item.FirstNumber,
                    SecondNumber = item.SecondNumber,
                    Result = item.Result,
                    Operator = item.Operator.ToString(),
                }) ;
                entities.SaveChanges();
            }
        }

        
        // DELETE: api/Database/5
        public void Delete(int id)
        {
            using (CalculatorDBEntities entities = new CalculatorDBEntities())
            {
                var result = entities.CalculatorResults
                    .Where(s => s.Id == id)
                    .FirstOrDefault();
            }
        }
    }
}
