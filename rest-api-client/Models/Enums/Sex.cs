using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rest_api_client.Models.Enums
{
	public enum Sex
	{
		[Display(Name = "Женский")]
		Female = 1,

		[Display(Name = "Мужской")]
		Male = 2,
	}
}