using Newtonsoft.Json;
using System.Collections.Generic;

namespace NullableReferenceTypes
{
#nullable enable
	internal class PersonDto_WithWarnings
	{
		public string FirstName { get; set; } // could be filled automatically e.g. by framework so these warnings are actually not necessary
		public string? MiddleName { get; set; }
		public string LastName { get; set; }
	}

	internal class PersonDto
	{
		public string FirstName { get; set; } = null!; 
		public string? MiddleName { get; set; }
		public string LastName { get; set; } = null!;
	}

	internal class NullForgivingOperator
	{
		public void JsonDeserialize()
		{
			string json = 
				@"{
					'FirstName':'Karel',
					'MiddleName':'Pepa',
					'LastName':'Novak'
				}	";

			var personDto = JsonConvert.DeserializeObject<PersonDto>(json);

			var middleName1 = personDto.MiddleName.ToUpper();
			//var middleName1 = personDto.MiddleName!.ToUpper();
		}
	}
}
