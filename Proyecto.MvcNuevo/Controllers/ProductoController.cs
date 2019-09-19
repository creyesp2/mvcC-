using Proyecto.MvcNuevo.Context;
using Proyecto.MvcNuevo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.MvcNuevo.Controllers
{
    public class ProductoController : Controller
    {
        private TiendaContext db = new TiendaContext();
        //
        // GET: /Producto/
        public ActionResult Index()
        {
            return View(db.Productos.ToList());
        }

        //
        // GET: /Producto/Details/5
        public ActionResult Details(int ? id)
        {
            if(id==null){
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var producto = db.Productos.Find(id);
            if(producto==null){
                return HttpNotFound();
            }
            
            return View(producto);
        }

        //
        // GET: /Producto/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Producto/Create
        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid){
                    db.Productos.Add(producto);
                    db.SaveChanges();
                return RedirectToAction("Index");
                }
                return View(producto);
            }
            catch
            {
                return View(producto);
            }
        }

        //
        // GET: /Producto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }

            return View(producto);
        }

        //
        // POST: /Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            try
            {
                // TODO: Add update logic here
                if(ModelState.IsValid){
                    db.Entry(producto).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(producto);
            }
            catch
            {
                return View(producto);
            }
        }

        //
        // GET: /Producto/Delete/5
        public ActionResult Delete(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }

            return View(producto);
            
        }

        //
        // POST: /Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Producto producto)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    producto = db.Productos.Find(id);
                    if (producto == null)
                    {
                        return HttpNotFound();
                    }
                    db.Productos.Remove(producto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(producto);
            }
            catch
            {
                return View();
            }
        }
    }
}
