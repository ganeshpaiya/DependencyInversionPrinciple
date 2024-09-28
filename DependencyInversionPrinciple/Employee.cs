using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
   public class Employee //High
    {
        private ISendIntimation _sendIntimation;//abstraction

        public Employee(ISendIntimation sendIntimation)
        {
            _sendIntimation = sendIntimation;
        }
        public int PhoneNo { get; set; }
        public string EmpName { get; set; }
        public void AddEmployee()
        {
            Console.WriteLine("Employee Add in Database successfuly");

            _sendIntimation.sendintimation();

            //Intimation _inm = new Intimation();
            //_inm.sendintimation(); --> here  your operation meet required But not achieved DI 
            //High Level Modules(Class) done not depend on low level modules(class)
            ///Both should depend on abstraction
    }
    }
}
