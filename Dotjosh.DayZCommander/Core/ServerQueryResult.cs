using System.Collections.Generic;

namespace Dotjosh.DayZCommander.Core
{
	public class ServerQueryResult
	{
		public long Ping { get; set; }
		public SortedDictionary<string, string> Settings { get; set; }
		public List<Player> Players { get; set; }
	}
}