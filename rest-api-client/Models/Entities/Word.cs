using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace rest_api_client.Models
{
    public class Word
    {
 
        /// <summary>
        /// Непонятное слово
        /// </summary>
        [Display(Name = "Слово", Order = 1)]
        [UIHint("TextReadOnly")]
        public string _Word { get; set; }

        /// <summary>
        /// Непонятное слово
        /// </summary>
        [Display(Name = "Значения", Order = 2)]
        [UIHint("ListString")]
        public List<string> Defenitons { get; set; }
    }
}