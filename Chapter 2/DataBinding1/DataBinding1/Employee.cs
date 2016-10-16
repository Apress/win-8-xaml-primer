using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding1
{
    class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public Employee( string name, string title )
        {
            Name = name;
            Title = title;
        }

        public static Employee GetEmployee()
        {
            var emp = new Employee( "Tom", "Developer" );
            return emp;
        }

    }
}
