using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rest_api_client.Models
{
    public partial class Phonetics : IEquatable<Phonetics>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public string Audio { get; set; }

        public override bool Equals(object input)
        {
            return this.Equals(input as Phonetics);
        }

        /// <summary>
        /// Returns true if Phonetics instances are equal
        /// </summary>
        /// <param name="input">Instance of Phonetics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Phonetics input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) &&
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                return hashCode;
            }
        }

        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}