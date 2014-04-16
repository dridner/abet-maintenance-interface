using System.Collections.Generic;
using AMI.Model;

namespace AMI.MVC.WebApp.Models.SLO
{
    public class OutcomeToSloModel
    {
        public int SLOID { get; set; }
        public List<Outcome> AllOutcomes { get; set; }
    }
}