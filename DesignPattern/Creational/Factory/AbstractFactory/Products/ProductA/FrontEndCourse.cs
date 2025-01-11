namespace AbstractFactoryPattern.Products.ProductA
{
    internal class FrontEndCourse : ICourse
    {
        public string GetCourseDuration() => "6 Months";

        public string GetCourseFee() => "2,000";

        public string GetCourseName() => "HTML, CSS, and Bootstrap";
    }
}
