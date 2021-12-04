using System;


namespace StructureAndEnumDemo
{
    class EnumDemo
    {
        static void Main()
        {
            Console.WriteLine(GstStateCodes.MH);
            Console.WriteLine(GstStateCodes.MH.GetHashCode());
            var values = Enum.GetValues(typeof(GstStateCodes));
            foreach(var value in values)
            {
                Console.WriteLine($"{value}={value.GetHashCode()}");
            }

            Employee employee = new Employee {EmpCode=100,EmpName="Scott",EmpGender=Gender.Male };
            Console.WriteLine($"Code={employee.EmpCode}\tName={employee.EmpName}\tGender={employee.EmpGender}");
            Console.ReadLine();
    
        }
    }

    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public Gender EmpGender { get; set; }

    }
}
