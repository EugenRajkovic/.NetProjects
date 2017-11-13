using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadatak31.Models
{
    public class Grad
    {
        public Guid IDGrad { get; set; }
        public string Naziv { get; set; }

        public Grad()
        {
            IDGrad = Guid.NewGuid();
        }
    }
}