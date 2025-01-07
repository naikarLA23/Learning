namespace AbstractFactoryPattern.Products.ProductA
{
    internal class BackendCourse : ICourse
    {
        public string GetCourseDuration() => "12 Months";

        public string GetCourseFee() => "5,000";

        public string GetCourseName() => "C#, Java, Python, SQL";
    }
}
