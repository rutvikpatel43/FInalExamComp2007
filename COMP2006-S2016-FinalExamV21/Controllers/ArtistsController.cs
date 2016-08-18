using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV21.Models;

/**
 * Name Rutvik Patel
 * Date: 18 August 2016
 * File Description: Genres Controller to show the list of the Artists
 */
namespace COMP2006_S2016_FinalExamV21.Controllers
{
    public class ArtistsController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Artists
        public async Task<ActionResult> Index()
        {
            return View(await db.Artists.ToListAsync());
        }

        
    }
}
