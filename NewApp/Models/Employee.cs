namespace NewApp.Models
{
    public class Employee
    {
        public int Manhanvien { get; set; }
        public string Tennhanvien { get; set; }
        public int Age { get; set; }
        public Double  Luong { get; set; }
        public void Nhapthongtin()
        {
            System.Console.WriteLine("Ma nhan vien = ");
            Manhanvien = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Ten nhan vien = ");
            Tennhanvien = Console.ReadLine();
            System.Console.WriteLine("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Luong = ");
            Luong = Convert.ToDouble(Console.ReadLine());
            
        }
        public void Hienthi()
        {
            System.Console.WriteLine("{0} - {1} - {2} - {3} VND", Manhanvien, Tennhanvien, Age, Luong);
        }
    }
}




