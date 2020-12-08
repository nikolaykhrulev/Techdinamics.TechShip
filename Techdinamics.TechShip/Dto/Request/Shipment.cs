using Newtonsoft.Json;

namespace Techdinamics.TechShip.Dto.Request
{
	public partial class Shipment
	{
		[JsonProperty("Sequence")]
		public long Sequence { get; set; }

		[JsonProperty("ShipToAddress1")]
		public string ShipToAddress1 { get; set; }

		[JsonProperty("ShipToCountry")]
		public string ShipToCountry { get; set; }

		[JsonProperty("ShipToName")]
		public string ShipToName { get; set; }

		[JsonProperty("CarrierCode")]
		public string CarrierCode { get; set; }

		[JsonProperty("ServiceCode")]
		public string ServiceCode { get; set; }

		[JsonProperty("TransactionNumber")]
		public string TransactionNumber { get; set; }

		[JsonProperty("ShipToPostal")]
		public string ShipToPostal { get; set; }

		[JsonProperty("ShipToCity")]
		public string ShipToCity { get; set; }

		[JsonProperty("ShipToStateProvince")]
		public string ShipToStateProvince { get; set; }

		[JsonProperty("ShipToPhone")]
		public string ShipToPhone { get; set; }

		[JsonProperty("Packages")]
		public Package[] Packages { get; set; }

		[JsonProperty("ClientCode")]
		public string ClientCode { get; set; }

		[JsonProperty("Terms")]
		public string Terms { get; set; }
	}

	public partial class Package
	{
		[JsonProperty("Weight")]
		public decimal? Weight { get; set; }

		[JsonProperty("BoxHeight")]
		public decimal? BoxHeight { get; set; }

		[JsonProperty("BoxLength")]
		public decimal? BoxLength { get; set; }

		[JsonProperty("BoxWidth")]
		public decimal? BoxWidth { get; set; }

		[JsonProperty("Items")]
		public Item[] Items { get; set; }
	}

	public partial class Item
	{
		[JsonProperty("SKU")]
		public string Sku { get; set; }

		[JsonProperty("LotNumber")]
		public string LotNumber { get; set; }

		[JsonProperty("SerialNumber")]
		public string SerialNumber { get; set; }

		[JsonProperty("Description")]
		public string Description { get; set; }

		[JsonProperty("Description2")]
		public string Description2 { get; set; }

		[JsonProperty("Quantity")]
		public int? Quantity { get; set; }

		[JsonProperty("UnitPrice")]
		public decimal? UnitPrice { get; set; }

		[JsonProperty("ExpirationDate")]
		public string ExpirationDate { get; set; }

		[JsonProperty("UOM")]
		public string Uom { get; set; }

		[JsonProperty("Supplier")]
		public string Supplier { get; set; }

		[JsonProperty("CountryOfOrigin")]
		public string CountryOfOrigin { get; set; }
	}
}
