namespace CourseDetails //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name    
    {
        //Implement the property here

        public static Dictionary<string, int> CourseDetails { get; set; } = new Dictionary<string, int>();

        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here

            Course course = new Course();

            Console.WriteLine("1.Add Course Details");
            Console.WriteLine("2.Remove Course Details");
            Console.WriteLine("3.Sort Course By Fee");
            Console.WriteLine("4.Exit");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the course name");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the course fee");
            int courseFee = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                course.AddCourseDetails(courseName, courseFee);
                Console.WriteLine("Course details added successfully");
            }
            else if (choice == 2)
            {

                course.RemoveCourseDetails(courseName);
                Console.WriteLine("Course details removed sucessfully");
            }
            else if (choice == 3)
            {

                course.SortCourseByFee();
            }
            else if (choice == 4)
            {

                Console.WriteLine("Thank you \n exit");
            }
            else {

                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }
        }
    }
}
