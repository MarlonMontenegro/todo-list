﻿using Microsoft.AspNetCore.Mvc;

namespace TodoListApp.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




    }
}
