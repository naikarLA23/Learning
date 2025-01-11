using AbstractFactoryPattern.Factory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISourceCourseFactory sourceCourseFactory = new OfflineSourceCourseFactory();
            var sourceType = "Front End";
            PrintDetails(sourceCourseFactory, sourceType);


            sourceCourseFactory = new OnlineSourceCourseFactory();
            sourceType = "Back End";
            PrintDetails(sourceCourseFactory, sourceType);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press Any Key to exit...............");
            Console.ReadKey();
        }

        private static void PrintDetails(ISourceCourseFactory sourceCourseFactory, string sourceType)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(".................................................................");
            var course = sourceCourseFactory.GetCourse();
            Console.WriteLine($"{sourceType} Course and Source Details");
            Console.WriteLine($"Course Covered : {course.GetCourseName()}");
            Console.WriteLine($"Course Fee : Rs {course.GetCourseFee()}");
            Console.WriteLine($"Course Duration : {course.GetCourseDuration()}");
        }
    }
}
