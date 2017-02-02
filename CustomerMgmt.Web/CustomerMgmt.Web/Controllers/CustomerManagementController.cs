using CustomerMgmt.Models.Model;
using CustomerMgmt.Service.IService;
using CustomerMgmt.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerMgmt.Web.Controllers
{
    public class CustomerManagementController : Controller
    {
        public ICustomerService _customerService;

        //constructor DI
        public CustomerManagementController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: CustomerManagement
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(CustomerViewModel customerViewModel)
        {
            try
            {
                _customerService.createCustomer(AutoMapper.Mapper.Map<Customer>(customerViewModel));
                return View();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}