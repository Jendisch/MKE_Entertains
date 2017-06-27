using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MKEntertains.Models
{
    public class Schedule
    {

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Key, ForeignKey("ApplicationUser")]
        public string Id { get; set; }

        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? MKEntertainDate { get; set; }

        [Display(Name = "Food/Drink Choice:")]
        public string FoodDrinkChoice { get; set; }

        [Display(Name = "Entertainment Choice:")]
        public string EntertainmentChoice { get; set; }



    }
}