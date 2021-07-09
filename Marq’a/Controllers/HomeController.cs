using Application.Interfaces.Amazon_APIGateway;
using Domain.Entities;
using Marq_a.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Marq_a.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public async Task Index()
        {
            Person person = new Person();
            person._id = 0;
            person.first_names = "Paz";
            person.last_names = "Cesto Perez";
            person.date_of_birth = "2000-06-12";
            person.gender = "masculino";
            person.email = "adolfoap@gmail.com";
            person.password = "1234567";
            person.tutor = "0";

            IAmazon_APIGateway_Service iAmazon_APIGateway_Service = new IAmazon_APIGateway_Service();

            await iAmazon_APIGateway_Service.RegisterAParent(person);
            //using (var client = new HttpClient())
            //{
            //    var response = await client.PostAsJsonAsync("https://g78z22rva3.execute-api.us-east-1.amazonaws.com/Dev/person", person);
            //    return true;
            //}

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
