using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rest_api_client.Models
{
    public class Definitions
    {
        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public string Definition { get; set; }

        /// <summary>
        /// Gets or Sets Example
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public string Example { get; set; }

        /// <summary>
        /// Gets or Sets Synonyms
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public List<string> Synonyms { get; set; }

        /// <summary>
        /// Gets or Sets Antonyms
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public List<string> Antonyms { get; set; }
    }
}