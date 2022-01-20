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
        /// Gets or Sets _Word
        /// </summary>
        [Required]
        public string _Word { get; set; }

        public string Phon { get; set; }

        /// <summary>
        /// Gets or Sets Phonetics
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public List<Phonetics> Phonetics { get; set; }

        /// <summary>
        /// Gets or Sets Meanings
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public List<Meanings> Meanings { get; set; }

    }
}