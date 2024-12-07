namespace FilterEmployeeList //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static List<Employee> empList = new List<Employee>() {
            new Employee { empId=101, empName = "Rex", band="B4" },
            new Employee { empId=102, empName = "Tom", band="B2" },
            new Employee { empId=103, empName = "Peter", band="B1" }
        };

        public static IEnumerable<Employee> nameList = empList.Where(e => e.band == "B1");// implement the lambda expression here


        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            foreach (var emp in empList) {

                Console.WriteLine($"Employee Id : {emp.empId}");
                Console.WriteLine($"Name : {emp.empName}");
                Console.WriteLine($"Band : {emp.band}");

            }
        }
    }
}
