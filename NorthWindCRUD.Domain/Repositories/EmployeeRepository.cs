using NorthWindCRUD.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthWindCRUD.Domain
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DataContext dataContext = new DataContext();
        public Employee Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Edit(Employee employee) 
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> GetAll()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
