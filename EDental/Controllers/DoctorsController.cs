
using Microsoft.AspNetCore.Mvc;

public class DoctorsController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}