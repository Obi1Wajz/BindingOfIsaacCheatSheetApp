using BindingOfIsaacCheatSheetApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BindingOfIsaacCheatSheetApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["DailySeed"] = DailySeedGenerator.GenerateDailySeed();
            ViewData["CharacterCheatSheets"] = CheatSheet.characterCheatSheets;
            ViewData["ActiveItemCheatSheets"] = CheatSheet.activeItemCheatSheets;
            ViewData["CoinsCheatSheet"] = CheatSheet.coinsCheatSheet;
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
