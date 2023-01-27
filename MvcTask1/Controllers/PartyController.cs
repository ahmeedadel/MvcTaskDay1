using Microsoft.AspNetCore.Mvc;
using MvcTask1.Models;


namespace MvcTask1.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult Index()
        {
            return View("GetAllAttends");
        }

        public IActionResult allfriend()
        {

            var p = sampledata.Attends.Where(x => x.attend == "yes").ToList();


            return View("GetAllAttends", p);
        }


        public IActionResult addfriend()
        {




            return View("RegisterForm");
        }

        public IActionResult adddata(Party po)
        {
            sampledata.Add(po);
            List<Party> p = sampledata.Attends.Where(x => x.attend == "yes").ToList();
            if (po.attend == "no")
            {
                return View("NotAttend");

            }
            else
            {


                return View("Thanks");
            }



        }
    }
}
