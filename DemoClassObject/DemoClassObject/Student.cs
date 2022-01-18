namespace DemoClassObject
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}