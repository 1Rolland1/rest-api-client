using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rest_api_client.Models
{
    public class Meanings
    {
        /// <summary>
        /// Gets or Sets PartOfSpeech
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public string PartOfSpeech { get; set; }

        /// <summary>
        /// Gets or Sets Definitions
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public List<Definitions> Definitions { get; set; }
    }
}