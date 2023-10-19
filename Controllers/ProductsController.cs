using RelationalCRUD.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RelationalCRUD.Controllers
{
    public class ProductsController : Controller
    {
        //Making an object of the database using entity framework
        db_RelationalTablesEntities db = new db_RelationalTablesEntities();

        // GET: Products
        public ActionResult Products(tbl_Products model)
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult AddProducts(tbl_Products model)
        {
            tbl_Products obj = new tbl_Products();
            obj.ProductsID = model.ProductsID;
            obj.ProductsName = model.ProductsName;
            obj.ProductsPrice = model.ProductsPrice;
            obj.CatID = model.CatID;

            if(model.ProductsID == 0)
            {
                db.tbl_Products.Add(obj);

                db.SaveChanges();
            }
            else
            {
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            ModelState.Clear();

            var list = db.tbl_Products.ToList();

            return View("ProductsList", list);
        }

        public ActionResult ProductsList()
        {
            var res = db.tbl_Products.ToList();
            return View(res);
        }

        public ActionResult DeleteProducts(int id)
        {
            var res = db.tbl_Products.Where(x => x.ProductsID == id).First();
            db.tbl_Products.Remove(res);
            db.SaveChanges();

            var list = db.tbl_Products.ToList();

            return View("ProductsList", list);
        }



    }
}