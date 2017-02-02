﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMgmt.Web.ViewModels
{
    public class CustomerViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
    }
}