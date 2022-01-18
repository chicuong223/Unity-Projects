namespace DemoClassObject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student
            {
                Id = "SE150676",
                Name = "Tang Chi-Cuong",
                Address = "7 Nguyen-Thai-Binh, P. Nguyen-Thai-Binh, Saigon"
            };
            System.Console.WriteLine($"ID: {student.Id}\nName: {student.Name}\nAddress: {student.Address}");
        }
    }
}