using Newtonsoft.Json;

namespace Techdinamics.TechShip.Dto.Response
{
	public partial class CarrierShipment
	{
		[JsonProperty("BatchId")]
		public string BatchId { get; set; }

		[JsonProperty("ShipmentId")]
		public string ShipmentId { get; set; }

		[JsonProperty("ManifestId")]
		public string ManifestId { get; set; }

		[JsonProperty("BatchNumber")]
		public string BatchNumber { get; set; }

		[JsonProperty("ClientCode")]
		public string ClientCode { get; set; }

		[JsonProperty("CarrierCode")]
		public string CarrierCode { get; set; }

		[JsonProperty("ServiceCode")]
		public string ServiceCode { get; set; }

		[JsonProperty("TransactionNumber")]
		public string TransactionNumber { get; set; }

		[JsonProperty("CustomerOrder")]
		public string CustomerOrder { get; set; }

		[JsonProperty("CustomerPO")]
		public string CustomerPo { get; set; }

		[JsonProperty("CustomerNumber")]
		public string CustomerNumber { get; set; }

		[JsonProperty("Sequence")]
		public string Sequence { get; set; }

		[JsonProperty("ProcessingErrors")]
		public string ProcessingErrors { get; set; }

		[JsonProperty("HasErrors")]
		public bool HasErrors { get; set; }

		[JsonProperty("Labels")]
		public CarrierLabel[] Labels { get; set; }

		[JsonProperty("Tax1Type")]
		public string Tax1Type { get; set; }

		[JsonProperty("Tax1Amount")]
		public string Tax1Amount { get; set; }

		[JsonProperty("Tax2Type")]
		public string Tax2Type { get; set; }

		[JsonProperty("Tax2Amount")]
		public string Tax2Amount { get; set; }

		[JsonProperty("Tax3Type")]
		public string Tax3Type { get; set; }

		[JsonProperty("Tax3Amount")]
		public string Tax3Amount { get; set; }

		[JsonProperty("ShippingCharge")]
		public string ShippingCharge { get; set; }

		[JsonProperty("ShippingChargeTotal")]
		public string ShippingChargeTotal { get; set; }

		[JsonProperty("FuelSurcharge")]
		public string FuelSurcharge { get; set; }

		[JsonProperty("FeeMarkup")]
		public string FeeMarkup { get; set; }

		[JsonProperty("Rates")]
		public string Rates { get; set; }
	}

	public partial class CarrierLabel
	{
		[JsonProperty("TrackingNumber")]
		public string TrackingNumber { get; set; }

		[JsonProperty("PackageId")]
		public string PackageId { get; set; }

		[JsonProperty("RequestPackageId")]
		public string RequestPackageId { get; set; }

		[JsonProperty("SSCC")]
		public string Sscc { get; set; }

		[JsonProperty("PackageShippingCharge")]
		public string PackageShippingCharge { get; set; }

		[JsonProperty("PackageShippingChargeTotal")]
		public string PackageShippingChargeTotal { get; set; }

		[JsonProperty("PackageTax1Type")]
		public string PackageTax1Type { get; set; }

		[JsonProperty("PackageTax1Amount")]
		public string PackageTax1Amount { get; set; }

		[JsonProperty("PackageTax2Type")]
		public string PackageTax2Type { get; set; }

		[JsonProperty("PackageTax2Amount")]
		public string PackageTax2Amount { get; set; }

		[JsonProperty("PackageTax3Type")]
		public string PackageTax3Type { get; set; }

		[JsonProperty("PackageTax3Amount")]
		public string PackageTax3Amount { get; set; }

		[JsonProperty("PackageFuelSurcharge")]
		public string PackageFuelSurcharge { get; set; }

		[JsonProperty("Type")]
		public string Type { get; set; }

		[JsonProperty("Label")]
		public string LabelLabel { get; set; }

		[JsonProperty("Purpose")]
		public string Purpose { get; set; }
	}
}
