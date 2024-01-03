using SoapServiceApplication.Business_Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapServiceApplication.Business_Action
{
    public static class WorkersManager
    {
        public static WorkersResponse GetAllWorkers()
        {
            var workers = new List<Person>() { new Person()
            {
                FullName = "Roberto Carlos"
            },
            new Person()
            {
                FullName = "Jose María"
            }
            };
            return new WorkersResponse()
            {
                Workers = workers,
                ActionResult = true
            };
        }
    }
}