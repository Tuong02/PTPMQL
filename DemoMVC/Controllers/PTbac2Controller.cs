using Microsoft.AspNetCore.Mvc;

public class PTbac2Controller : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(PTbac2 model){
        double delta = model.b * model.b - 4 * model.a *model.c;
        if(delta<0)
        {
            ViewData["Result"] = "Phuong Trinh vo nghiem";
        }
        else if(delta ==0)
        {
            model.x1 = -model.b / (2*model.a);
            ViewData["Result"] = "Phuong trinh co nghiem kep:" + model.x1;
        }
        else
        {
            model.x1 =(-model.b + Math.Sqrt(delta)) / (2*model.a);
            model.x2 = (-model.b - Math.Sqrt(delta)) / (2*model.a);
            ViewData["Result"] = "Phuong trinh co 2 nghiem: x1 =" +model.x1 + ", x2 = " +model.x2;
        }
        return View();
    }
}