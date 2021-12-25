using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameHubRentals.Models;

namespace GameHubRentals.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Random()
        {
            var game = new Game() {Id = 1, Name = "Vangaurd" };
            return View(game);
        }
    }
}