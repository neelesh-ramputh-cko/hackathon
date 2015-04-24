using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;

namespace Twitter.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index()
        {
            var accessToken = "CAAFo3KVnsXwBAGP1muyB0A9QMZBpybQFcE6zpMTdbcJ7o7IySF6i13WcsTggS6oGZB4iHRYGzkA8rJqmv52djdWDH3yzqElrGDLlAZAxZAVXo9BActdRaZCmNFr25rpwRvV3CiwtDnnbWb1cQpMXZAhY5xcBlCcLLaCBpWD2gLvdDXE03yrg4tKTgWUFoCOZBOXIbrudO11hxwPZASyMVSyC";
            var client = new FacebookClient(accessToken);
            dynamic me = client.Get("MauritiusSoftwareCraftsmanshipCommunity/statuses");

           
            // https://www.facebook.com/hashtag/devconmru


            var status = me.message;

            var s = me.feed;

            string aboutMe = me.about;

            return View();
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
