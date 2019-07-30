using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebClient.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangBo()
        {
            return View();
        }
        public IActionResult ChiBo()
        {
            return View();
        }
        public IActionResult DonVi()
        {
            return View();
        }
        public IActionResult DangVien()
        {
            return View();
        }
        public IActionResult File()
        {
            return View();
        }

    }
}