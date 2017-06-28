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

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        
        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? MKEntertainDate { get; set; }

        [Required]
        [Display(Name = "Food/Drink Location:")]
        public string FoodDrinkChoice { get; set; }

        [Required]
        [Display(Name = "Entertainment Location:")]
        public string EntertainmentChoice { get; set; }

        [Display(Name = "Description (optional):")]
        public string Description { get; set; }



    }
}