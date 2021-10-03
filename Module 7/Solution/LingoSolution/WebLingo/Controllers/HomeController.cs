using LingoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLingo.Models;

namespace WebLingo.Controllers
{
    public class HomeController : Controller
    {
        static string[] wordlist = {"appel", "actie", "breed", "blind", "cadet", "creme", 
                                    "deren", "dweil", "elven", "engel", "feest", "flora", "grote", 
                                    "gebak", "hamer", "hoofd", "index", "icoon", "jawel", "japon",
                                    "kraan", "kleur", "licht", "laser", "motor", "markt", "nodig", "neven",
                                    "oases", "onwel", "polis", "preek", "quota", "quark", "ruzie", "schat",
                                    "treur", "typen", "uniek", "ultra", "vloer", "vorst", "wreed", "wazig",
                                    "xenon", "yacht", "yucca", "zomer", "zagen"};

        // GET: Home
        public ActionResult Index()
        {
            LingoModel model = new LingoModel();
            model.WordToBeGuessed = GenerateWord();
            model.Guesses = new List<LingoWord>();
            model.Finished = false;
            model.Attempt = 1;
            Session["game"] = model;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string guess)
        {
            LingoModel model = Session["game"] as LingoModel;
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            
            LingoWord theguess = new LingoWord(guess);
            theguess = LingoWord.Examine(model.WordToBeGuessed, theguess);
            model.Guesses.Add(theguess);
            
            if (theguess.IsGuessed() || model.Attempt >= 5)
            {
                IQ iq = (IQ)model.Attempt;
                model.YourIQ = iq.ToString();
                model.Finished = true;
            }
            model.Attempt++;
            Session["game"] = model;
            return View(model);
        }
        private static LingoWord GenerateWord()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int idx = rnd.Next(0, wordlist.Length);
            return new LingoWord(wordlist[idx]);
        }
    }
}