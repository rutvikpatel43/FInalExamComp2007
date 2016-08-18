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
 * File Description: Genres Controller to show the list of the Albums
 */
namespace COMP2006_S2016_FinalExamV21.Controllers
{
    public class AlbumsController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Albums
        public async Task<ActionResult> Index()
        {
            var albums = db.Albums.Include(a => a.Artist).Include(a => a.Genre);
            return View(await albums.ToListAsync());
        }

    }
}
