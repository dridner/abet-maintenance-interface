using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AMI.Model;

namespace AMI.MVC.WebApp.Models.Public
{
    public class ClassDetailModel
    {
        public Class Class{ get; set; }
        public List<Criteria> Criterias { get; set; }
    }
}