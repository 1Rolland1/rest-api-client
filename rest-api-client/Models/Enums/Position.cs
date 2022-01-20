using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rest_api_client.Models.Enums
{
	public enum Position
	{
		[Display(Name = "Профессор")]
		Professor = 1,

		[Display(Name = "Старший преподаватель")]
		SeniorLecturer = 2,

		[Display(Name = "Доцент")]
		AssistantProfessor = 3,
	}
}