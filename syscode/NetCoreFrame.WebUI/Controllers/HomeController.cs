using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using NetCoreFrame.Service;
using NetCoreFrame.WebUI.Extensions;
using NetCoreFrame.WebUI.Models;
using NetCoreFrame.WebUI.Views.Hubs;

namespace NetCoreFrame.WebUI.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHubContext<SignalrHubs> _countHub;
        private readonly productionstationService _productionstationService;
        public HomeController(
            ILogger<HomeController> logger, 
            IHubContext<SignalrHubs>  countHub,
            productionstationService productionstationService)
        {
            _logger = logger;
            _countHub = countHub;
            _productionstationService = productionstationService;
        }

        public async Task Send(string msg, string id)
        {
            await _countHub.Clients.All.SendAsync("AddMsg", $"{id}：{msg}");
            await _countHub.Clients.User("22").SendAsync("", "");
        }

        public IActionResult Index()
        {
             
            ViewBag.UserName = CurrentUser.UserName;
            ViewBag.UserID = CurrentUser.ID;
            ViewBag.RoleID = CurrentUser.RoleID;
            return View();
        }

        public IActionResult ImagesView()
        {
           
            ViewBag.ImgList = _productionstationService.GetProductionImgList(CurrentUser.UserName);
            ViewBag.ID = CurrentUser.UserName;
            return View();
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
