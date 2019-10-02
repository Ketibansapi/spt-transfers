using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsTransfer.Models;
using SportsTransfer.ViewModels;

namespace SportsTransfer.Controllers
{
    public class TransfersController : Controller
    {
        // GET: Transfers/Random
        public ActionResult Random()
        {
            var transfer = new Transfer() { Name = "Eriksen" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomTransferViewModel
            {
                Transfer = transfer,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}