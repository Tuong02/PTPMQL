namespace NewApp.Models
{
    public class Person
    {
        public string PersonID { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public void Nhapthongtin()
        {
            System.Console.WriteLine("PersonID = ");
            PersonID = Console.ReadLine();
            System.Console.WriteLine("Fullname = ");
            Fullname = Console.ReadLine();
            System.Console.WriteLine("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
            
        }
        public void Hienthi()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", PersonID, Fullname, Age);
        }
    }
}



