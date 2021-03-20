using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RokanRaiders.Models
{
    public class Event
    {
        //Properties
        public int EventID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("Datum & Tid")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Plats")]
        public string Location { get; set; }

        public string Info { get; set; }

        public Event()
        {
        }
    }
}
