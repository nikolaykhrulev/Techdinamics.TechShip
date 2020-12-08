using Newtonsoft.Json;

namespace Techdinamics.TechShip.Dto.Response
{
	public partial class RateShopShipment
	{
		[JsonProperty("BatchId")]
		public long BatchId { get; set; }

		[JsonProperty("ShipmentId")]
		public long ShipmentId { get; set; }

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
		public object CustomerOrder { get; set; }

		[JsonProperty("CustomerPO")]
		public object CustomerPo { get; set; }

		[JsonProperty("CustomerNumber")]
		public object CustomerNumber { get; set; }

		[JsonProperty("Sequence")]
		public long Sequence { get; set; }

		[JsonProperty("ProcessingErrors")]
		public object ProcessingErrors { get; set; }

		[JsonProperty("HasErrors")]
		public bool HasErrors { get; set; }

		[JsonProperty("Labels")]
		public RateShopLabel[] Labels { get; set; }

		[JsonProperty("Tax1Type")]
		public string Tax1Type { get; set; }

		[JsonProperty("Tax1Amount")]
		public object Tax1Amount { get; set; }

		[JsonProperty("Tax2Type")]
		public string Tax2Type { get; set; }

		[JsonProperty("Tax2Amount")]
		public object Tax2Amount { get; set; }

		[JsonProperty("Tax3Type")]
		public string Tax3Type { get; set; }

		[JsonProperty("Tax3Amount")]
		public object Tax3Amount { get; set; }

		[JsonProperty("ShippingCharge")]
		public double ShippingCharge { get; set; }

		[JsonProperty("ShippingChargeTotal")]
		public double ShippingChargeTotal { get; set; }

		[JsonProperty("FuelSurcharge")]
		public object FuelSurcharge { get; set; }

		[JsonProperty("FeeMarkup")]
		public long FeeMarkup { get; set; }

		[JsonProperty("Rates")]
		public Rate[] Rates { get; set; }
	}

	public partial class RateShopLabel
	{
		[JsonProperty("TrackingNumber")]
		public string TrackingNumber { get; set; }

		[JsonProperty("PackageId")]
		public long PackageId { get; set; }

		[JsonProperty("RequestPackageId")]
		public object RequestPackageId { get; set; }

		[JsonProperty("SSCC")]
		public object Sscc { get; set; }

		[JsonProperty("PackageShippingCharge")]
		public double? PackageShippingCharge { get; set; }

		[JsonProperty("PackageShippingChargeTotal")]
		public double? PackageShippingChargeTotal { get; set; }

		[JsonProperty("PackageTax1Type")]
		public object PackageTax1Type { get; set; }

		[JsonProperty("PackageTax1Amount")]
		public object PackageTax1Amount { get; set; }

		[JsonProperty("PackageTax2Type")]
		public object PackageTax2Type { get; set; }

		[JsonProperty("PackageTax2Amount")]
		public object PackageTax2Amount { get; set; }

		[JsonProperty("PackageTax3Type")]
		public object PackageTax3Type { get; set; }

		[JsonProperty("PackageTax3Amount")]
		public object PackageTax3Amount { get; set; }

		[JsonProperty("PackageFuelSurcharge")]
		public object PackageFuelSurcharge { get; set; }

		[JsonProperty("Type")]
		public long Type { get; set; }

		[JsonProperty("Label")]
		public string LabelLabel { get; set; }

		[JsonProperty("Purpose")]
		public string Purpose { get; set; }
	}

	public partial class Rate
	{
		[JsonProperty("ServiceCode")]
		public string ServiceCode { get; set; }

		[JsonProperty("ServiceName")]
		public string ServiceName { get; set; }

		[JsonProperty("Amount")]
		public double Amount { get; set; }

		[JsonProperty("TaxAmount")]
		public long TaxAmount { get; set; }

		[JsonProperty("ZoneSkipping")]
		public long ZoneSkipping { get; set; }

		[JsonProperty("FeeMarkup")]
		public long FeeMarkup { get; set; }

		[JsonProperty("TotalAmount")]
		public double TotalAmount { get; set; }

		[JsonProperty("AlternateAmount")]
		public object AlternateAmount { get; set; }

		[JsonProperty("AlternateTotalAmount")]
		public object AlternateTotalAmount { get; set; }

		[JsonProperty("AlternateRateShoppingAmount")]
		public object AlternateRateShoppingAmount { get; set; }

		[JsonProperty("UseAlternateRate")]
		public object UseAlternateRate { get; set; }

		[JsonProperty("RateShoppingAmount")]
		public double RateShoppingAmount { get; set; }

		[JsonProperty("BillingAccountClientId")]
		public long BillingAccountClientId { get; set; }

		[JsonProperty("BillingAccountId")]
		public long BillingAccountId { get; set; }

		[JsonProperty("CarrierId")]
		public long CarrierId { get; set; }

		[JsonProperty("BillingAccountClientName")]
		public string BillingAccountClientName { get; set; }

		[JsonProperty("BillingAccountName")]
		public string BillingAccountName { get; set; }

		[JsonProperty("CarrierName")]
		public string CarrierName { get; set; }

		[JsonProperty("SCAC")]
		public string Scac { get; set; }

		[JsonProperty("ShippingServiceOfferIds")]
		public object ShippingServiceOfferIds { get; set; }

		[JsonProperty("AmazonCarrierName")]
		public object AmazonCarrierName { get; set; }

		[JsonProperty("QuoteId")]
		public object QuoteId { get; set; }
	}
}
