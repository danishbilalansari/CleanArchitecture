using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        //custom operations here
        Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname);
    }
}
