using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Buying
    {
       [Key]public int BuyId { get; set; }

        public string FIO { get; set; }

        public DateTime DateTime { get; set; }

        public string Addres { get; set; }

        public string Email { get; set; }

        public int ActorId { get; set; }
    }
}