using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApp.Shared.Responses
{
    public class ApiRespose
    {
        public string Messange { get; set; }
        public bool IsSuccess { get; set; }
    }

    public class ApiRespose<T> : ApiRespose
    {
        public T Value { get; set; }
    }

}


