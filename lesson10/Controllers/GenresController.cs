﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lesson10.Models;

namespace lesson10.Controllers
{
    public class GenresController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Genres
        public ActionResult Index()
        {
            return View(db.Genres.ToList());
        }

        // GET: Genres/Details/5
        public ActionResult Details(int? id = 1)
        {

            Genre genre = db.Genres.Find(id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }



    }
}
