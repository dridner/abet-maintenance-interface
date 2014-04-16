using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AMI.Model;

namespace AMI.MVC.WebApp.Models.Classes
{
    public class ClassListModel
    {
        public List<Class> Classes { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Prefix { get; set; }
    }
}