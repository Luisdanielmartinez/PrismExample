using ExamplePrism.Interfaces;
using ExamplePrism.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePrism.Services
{
    public class ApiService : IApiServices
    {
        public ApiService()
        {
                
        }
        public Task<IEnumerable<TodoItem>> getTodo()
        {
            throw new NotImplementedException();
        }
    }
}
