using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameLibrary.Models
{
	public class Game
	{
		public int GameID { get; set; }
		[Required]
		public string Title { get; set; }
		public string Genre { get; set; }
		public string Rating { get; set; }
		[Required]
		public string Director { get; set; }
		public string Composer { get; set; }
		public string Artist { get; set; }
		[Required]
		public string Company { get; set; }
		[Range(0, 9999)]
		public string Year { get; set; }
		public string Console { get; set; }

	}
}