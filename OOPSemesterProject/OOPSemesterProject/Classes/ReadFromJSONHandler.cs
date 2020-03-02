using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OOPSemesterProject
{
	class ReadFromJSONHandler
	{
		public Classes.PartsList readJSON()
		{
			string strResultCarPart = String.Empty;
			strResultCarPart = File.ReadAllText($@"FullPartsList.json");
			Classes.PartsList result = JsonConvert.DeserializeObject<Classes.PartsList>(strResultCarPart);
			return result;
		}
	}

}
