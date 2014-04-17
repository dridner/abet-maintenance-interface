using System.Collections.Generic;
using AMI.Model;

namespace AMI.MVC.WebApp.Models.SLO
{
    public class SLOModel
    {
        public SLOModel()
        {
            this.SupportedOutcomes = new List<Outcome>();
        }

        public int ID { get; set; }
        public int ClassID { get; set; }
        public string Text { get; set; }
        public List<Outcome> SupportedOutcomes { get; set; }
    }
}