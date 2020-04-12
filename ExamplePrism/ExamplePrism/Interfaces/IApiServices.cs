using ExamplePrism.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePrism.Interfaces
{
    public interface IApiServices
    {
        Task<IEnumerable<TodoItem>> getTodo();
    }
}
