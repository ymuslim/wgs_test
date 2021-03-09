using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WgsTestMvc.Models;

namespace WgsTestMvc.Controllers
{
    public class InvoiceController : Controller
    {
        public string ConnectionString = "Data Source=DESKTOP-BL4AC44\\SQLEXPRESS;Initial Catalog=WGS_DB;Integrated Security=True";
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dtInvoice = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter sdaInvoice = new SqlDataAdapter("SELECT * FROM TRX_INVOICE",conn);
                sdaInvoice.Fill(dtInvoice);
            }
                return View(dtInvoice);
        }

        // GET: Invoice/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Invoice/Create
        [HttpGet]
        public ActionResult Create()
        {
            //ViewBag.DivStyle = "display:block";
            ViewBag.ShowErrorDiv = false;

            return View(new InvoiceModel());
        }

        // POST: Invoice/Create
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

        // GET: Invoice/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Invoice/Edit/5
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

        // GET: Invoice/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Invoice/Delete/5
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
