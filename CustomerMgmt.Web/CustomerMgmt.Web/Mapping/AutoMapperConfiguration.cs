using AutoMapper;
using CustomerMgmt.Models.Model;
using CustomerMgmt.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMgmt.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CustomerViewModel, Customer>();

            });

        }
    }
}