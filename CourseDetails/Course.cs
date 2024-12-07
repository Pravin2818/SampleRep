namespace CourseDetails //DO NOT change the namespace name
{
    public class Course //DO NOT change the class name
    {
        //Implement your code here
        //Program program = new Program();
        public void AddCourseDetails(string name, int fee)
        {
            if (!Program.CourseDetails.ContainsKey(name))
            {

                Program.CourseDetails.Add(name, fee);
                Console.WriteLine("Course details added successfully");

            }
            else
            {
                Console.WriteLine("Course already exist");
            }

            //Program.CourseDetails[name] = fee;

        }

        public void RemoveCourseDetails(string name) {

            if (Program.CourseDetails.ContainsKey(name))
            {

                Program.CourseDetails.Remove(name);
                Console.WriteLine("Course details removed sucessfully");

            }
            else
            {
                Console.WriteLine("course not found");
            }
            //Program.CourseDetails.Remove(name);
        }

        public Dictionary<string, int> SortCourseByFee() {


            var sortedCourses = Program.CourseDetails
                                        .OrderBy(course => course.Value)
                                        .ToDictionary(course => course.Key, course => course.Value);

            // Display sorted courses
            Console.WriteLine("Course Name\tFee");
            foreach (var course in sortedCourses)
            {
                Console.WriteLine($"{course.Key}\t{course.Value}");
            }

            return sortedCourses;


            //var sortedCourses = Program.CourseDetails.OrderBy(x => x.Value);

            //    //.ToDictionary(x => x.Key, x => x.Value);

            //Dictionary<string, int> result = new Dictionary<string, int>();
            //Console.WriteLine("course name\t fee");
            //foreach (var c in sortedCourses) {

            //    result.Add(c.Key, c.Value);
            //}
            //return result;
        }

    }
}
