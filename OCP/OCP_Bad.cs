using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay.SRP
{
    public class OCP_Bad
    {
        private readonly EmailNotificationService _emailService;
        public OCP_Bad()
        {
            _emailService = new EmailNotificationService();
        }

        public void CreateEmployee(string firstName, string lastName, string email) {

            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException("First name is required");

            if(string.IsNullOrEmpty(lastName))
                throw new ArgumentException("Last name is required");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email is required");

            Employee newEmployee = new Employee();
            newEmployee.FirstName = firstName;
            newEmployee.LastName = lastName;
            newEmployee.Email = email;

            var isCreated = SaveEmployee(newEmployee);
            if (isCreated)
                _emailService.Notify(newEmployee);

        }

        public bool SaveEmployee(Employee employee) {
            //Save employee to database
            return true;
        }
    }
}
