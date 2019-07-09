using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homeworks.Models.ViewModels
{
    public class AccountViewModel
    {
        public string Type { get; set; }
        public DateTime CostDate { get; set; }
        public int Cost { get; set; }
    }
}