using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMI.MVC.WebApp.Models.SLO
{
    public class SLOModel
    {
        public int ID { get; set; }
        public int ClassID { get; set; }
        public string Text { get; set; }
        public List<int> SupportedOutcomeIDs { get; set; }
    }
}