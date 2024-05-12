using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lessonCalculator.Models;

namespace lessonCalculator.Controllers;

public class HomeController : Controller
{
        public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Summa(){
        return View(new Sum());
    }
    [HttpPost]
    public IActionResult Summa(Sum sum){
        sum.Operation();
        return View(sum);
    }
    public IActionResult Sub(){
        return View(new Sub());
    }
    [HttpPost]
    public IActionResult Sub(Sub sub){
        sub.Operation();
        return View(sub);
    }

    public IActionResult Mult(){
        return View(new Mult());
    }
    [HttpPost]
    public IActionResult Mult(Mult mult){
        mult.Operation();
        return View(mult);
    }

    public IActionResult Div(){
        return View(new Div());
    }
    [HttpPost]
    public IActionResult Div(Div div){
        div.Operation();
        return View(div);
    }

}
