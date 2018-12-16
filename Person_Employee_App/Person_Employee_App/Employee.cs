using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Employee_App
{
    //STEP 3.) Created "Employee" class which inherits properties from "Person" class. Created int property "Id."
    class Employee : Person
    {
        int Id { get; set; }
    }
}
