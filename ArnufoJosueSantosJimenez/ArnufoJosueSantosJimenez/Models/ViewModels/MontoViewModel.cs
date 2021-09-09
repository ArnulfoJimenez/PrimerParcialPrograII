using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArnufoJosueSantosJimenez.Models.ViewModels
{
    public class MontoViewModel
    {

        [Display(Name = "Cantidad")]
        [Range(0, int.MaxValue, ErrorMessage = "Campo requirido")]
        public int Cantidad { get; set; }
    }
}