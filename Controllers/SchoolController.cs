using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloWorldMVC.Models;

namespace HelloWorldMVC.Controllers;
public class SchoolController : Controller{

    public IActionResult Index(){
        var school = new School();
        school.FundationAt = "1962";
        school.SchoolId = Guid.NewGuid().ToString();
        school.Name = "School of the future";
        return View(school);
    }
}