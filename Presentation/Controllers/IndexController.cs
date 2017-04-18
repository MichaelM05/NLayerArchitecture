using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Domain;

namespace Presentation.Controllers
{
    public class IndexController : Controller
    {

        PersonBusiness pb = new PersonBusiness();
        // GET: Index
        public ActionResult Index()
        {
            return View(pb.getAllPerson());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(pb.getPersonId(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Index/Create
        [HttpPost]
        public ActionResult Create(Domain.Entities.Person person)
        {
            try
            {
                // TODO: Add insert logic here
                pb.addPerson(person);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            
            return View(pb.getPersonId(id));
        }

        // POST: Index/Edit/5
        [HttpPost]
        public ActionResult Edit(Domain.Entities.Person person)
        {
            try
            {
                pb.modifyPerson(person);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            pb.removePerson(pb.getPersonId(id));
            return RedirectToAction("Index");
        }

        // POST: Index/Delete/5
        [HttpPost]
        public ActionResult Delete(Domain.Entities.Person person)
        {
            try
            {
                pb.removePerson(person);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
