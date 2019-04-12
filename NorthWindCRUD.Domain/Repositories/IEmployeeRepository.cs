using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthWindCRUD.Domain
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> GetAll();
        Employee GetById(int id);
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        Employee Delete(Employee employee);
    }
}
