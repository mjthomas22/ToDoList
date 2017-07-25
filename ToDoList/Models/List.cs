using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class List
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="List Name")]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<List> Lists { get; set; }
    }
}