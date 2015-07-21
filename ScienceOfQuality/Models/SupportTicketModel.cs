using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace ScienceOfQuality.Models
{
    public class SupportTicketModel
    {
        [Required]
        [Display(Name="Ticket Number")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Issue")]
        public string Issue { get; set; }

        [Display(Name="Found By")]
        public string FoundBy { get; set; }

        [Display(Name="Type")]
        public int Type { get; set; }
        public IEnumerable<SelectListItem> Types {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem() {Text = "Bug", Value = "0"},
                    new SelectListItem() {Text = "Enhancement", Value = "1"},
                    new SelectListItem() {Text = "Information Only", Value = "2"}
                };
            }
        
        }

        public IEnumerable<Severity> Severities
        {
            get
            {
                return new List<Severity>()
                {
                    new Severity() {Id = 0, Name = "Critical"},
                    new Severity() {Id = 1, Name = "High"},
                    new Severity() {Id = 2, Name = "Medium"},
                    new Severity() {Id = 3, Name = "Low"},
                };
            }
        }
        
        [Display(Name="Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name="Severity")]
        public string Severity { get; set; }
    }

    public class Severity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}