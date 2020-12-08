using Newtonsoft.Json;

namespace Techdinamics.TechShip.Dto.Response
{
	public partial class VoidShipment
	{
		[JsonProperty("Success")]
		public bool Success { get; set; }

		[JsonProperty("Error")]
		public string Error { get; set; }
	}
}
