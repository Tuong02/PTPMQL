using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string hoTen, decimal luongCoBan, decimal heSoLuong, decimal phuCap)
    {
        decimal luong = luongCoBan + heSoLuong + phuCap;
        string tinhLuong = hoTen + "-" + luong;
        ViewBag.thongBao = tinhLuong;
        return View();
    }
}