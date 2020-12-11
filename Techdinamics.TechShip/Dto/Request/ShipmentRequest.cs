using Newtonsoft.Json;
using Techdinamics.TechShip.Dto.Enum;

namespace Techdinamics.TechShip.Dto.Request
{
	public partial class ShipmentRequest
	{
		[JsonProperty("BatchNumber")]
		public string BatchNumber { get; set; }

		[JsonProperty("PackageDescription")]
		public string PackageDescription { get; set; }

		[JsonProperty("ManifestId")]
		public string ManifestId { get; set; }

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

		[JsonProperty("PickupDateTime")]
		public string PickupDateTime { get; set; }

		[JsonProperty("DeliveryDateTime")]
		public string DeliveryDateTime { get; set; }

		[JsonProperty("Terms")]
		public string Terms { get; set; }

		[JsonProperty("Sequence")]
		public int? Sequence { get; set; }

		[JsonProperty("ShipToName")]
		public string ShipToName { get; set; }

		[JsonProperty("ShipToCompany")]
		public string ShipToCompany { get; set; }

		[JsonProperty("ShipToAddress1")]
		public string ShipToAddress1 { get; set; }

		[JsonProperty("ShipToAddress2")]
		public string ShipToAddress2 { get; set; }

		[JsonProperty("ShipToAddress3")]
		public string ShipToAddress3 { get; set; }

		[JsonProperty("ShipToCity")]
		public string ShipToCity { get; set; }

		[JsonProperty("ShipToStateProvince")]
		public string ShipToStateProvince { get; set; }

		[JsonProperty("ShipToPostal")]
		public string ShipToPostal { get; set; }

		[JsonProperty("ShipToCountry")]
		public string ShipToCountry { get; set; }

		[JsonProperty("ShipToPhone")]
		public string ShipToPhone { get; set; }

		[JsonProperty("ShipToEmail")]
		public string ShipToEmail { get; set; }

		[JsonProperty("Tax1Type")]
		public string Tax1Type { get; set; }

		[JsonProperty("Tax1Amount")]
		public double? Tax1Amount { get; set; }

		[JsonProperty("Tax2Type")]
		public string Tax2Type { get; set; }

		[JsonProperty("Tax2Amount")]
		public double? Tax2Amount { get; set; }

		[JsonProperty("Tax3Type")]
		public string Tax3Type { get; set; }

		[JsonProperty("Tax3Amount")]
		public double? Tax3Amount { get; set; }

		[JsonProperty("ShippingCharge")]
		public double? ShippingCharge { get; set; }

		[JsonProperty("ShippingChargeTotal")]
		public double? ShippingChargeTotal { get; set; }

		[JsonProperty("FuelSurcharge")]
		public double? FuelSurcharge { get; set; }

		[JsonProperty("FeeMarkup")]
		public double? FeeMarkup { get; set; }

		[JsonProperty("ThirdPartyBillingAccount")]
		public string ThirdPartyBillingAccount { get; set; }

		[JsonProperty("ThirdPartyBillingPostal")]
		public string ThirdPartyBillingPostal { get; set; }

		[JsonProperty("ThirdPartyBillingCountryCode")]
		public string ThirdPartyBillingCountryCode { get; set; }

		[JsonProperty("FreightPaymentTerms")]
		public FreightPaymentTerms FreightPaymentTerms { get; set; }

		[JsonProperty("SignatureRequired")]
		public bool? SignatureRequired { get; set; }

		[JsonProperty("HoldForPickupIndicator")]
		public bool? HoldForPickupIndicator { get; set; }

		[JsonProperty("PostOfficeId")]
		public string PostOfficeId { get; set; }

		[JsonProperty("HasBillToAddress")]
		public bool? HasBillToAddress { get; set; }

		[JsonProperty("BillToName")]
		public string BillToName { get; set; }

		[JsonProperty("BillToCompany")]
		public string BillToCompany { get; set; }

		[JsonProperty("BillToAddress1")]
		public string BillToAddress1 { get; set; }

		[JsonProperty("BillToAddress2")]
		public string BillToAddress2 { get; set; }

		[JsonProperty("BillToAddress3")]
		public string BillToAddress3 { get; set; }

		[JsonProperty("BillToCity")]
		public string BillToCity { get; set; }

		[JsonProperty("BillToState")]
		public string BillToState { get; set; }

		[JsonProperty("BillToZip")]
		public string BillToZip { get; set; }

		[JsonProperty("BillToCountry")]
		public string BillToCountry { get; set; }

		[JsonProperty("BillToPhone")]
		public string BillToPhone { get; set; }

		[JsonProperty("BillToEmail")]
		public string BillToEmail { get; set; }

		[JsonProperty("SkipAddressValidation")]
		public bool? SkipAddressValidation { get; set; }

		[JsonProperty("RateShoppingGroup")]
		public string RateShoppingGroup { get; set; }

		[JsonProperty("CustomFields")]
		public CustomField[] CustomFields { get; set; }

		[JsonProperty("Packages")]
		public Package[] Packages { get; set; }

		[JsonProperty("Id")]
		public int? Id { get; set; }
	}

	public partial class CustomField
	{
		[JsonProperty("Code")]
		public string Code { get; set; }

		[JsonProperty("Value")]
		public string Value { get; set; }
	}

	public partial class Package
	{
		[JsonProperty("ShippingCharge")]
		public double? ShippingCharge { get; set; }

		[JsonProperty("ShippingChargeTotal")]
		public double? ShippingChargeTotal { get; set; }

		[JsonProperty("Tax1Type")]
		public string Tax1Type { get; set; }

		[JsonProperty("Tax1Amount")]
		public double? Tax1Amount { get; set; }

		[JsonProperty("Tax2Type")]
		public string Tax2Type { get; set; }

		[JsonProperty("Tax2Amount")]
		public double? Tax2Amount { get; set; }

		[JsonProperty("Tax3Type")]
		public string Tax3Type { get; set; }

		[JsonProperty("Tax3Amount")]
		public double? Tax3Amount { get; set; }

		[JsonProperty("FuelSurcharge")]
		public double? FuelSurcharge { get; set; }

		[JsonProperty("TrackingNumber")]
		public string TrackingNumber { get; set; }

		[JsonProperty("SSCC")]
		public string Sscc { get; set; }

		[JsonProperty("Weight")]
		public double? Weight { get; set; }

		[JsonProperty("BoxWidth")]
		public double? BoxWidth { get; set; }

		[JsonProperty("BoxHeight")]
		public double? BoxHeight { get; set; }

		[JsonProperty("BoxLength")]
		public double? BoxLength { get; set; }

		[JsonProperty("CustomerSKU")]
		public string CustomerSku { get; set; }

		[JsonProperty("WarehouseSKU")]
		public string WarehouseSku { get; set; }

		[JsonProperty("Description")]
		public string Description { get; set; }

		[JsonProperty("Items")]
		public Item[] Items { get; set; }

		[JsonProperty("Labels")]
		public Label[] Labels { get; set; }

		[JsonProperty("PackingSlips")]
		public Label[] PackingSlips { get; set; }

		[JsonProperty("Id")]
		public int? Id { get; set; }
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
		public double? Quantity { get; set; }

		[JsonProperty("UnitPrice")]
		public double? UnitPrice { get; set; }

		[JsonProperty("ExpirationDate")]
		public string ExpirationDate { get; set; }

		[JsonProperty("UOM")]
		public string Uom { get; set; }

		[JsonProperty("Supplier")]
		public string Supplier { get; set; }

		[JsonProperty("CountryOfOrigin")]
		public string CountryOfOrigin { get; set; }

		[JsonProperty("HarmonizedCode")]
		public string HarmonizedCode { get; set; }

		[JsonProperty("Id")]
		public int? Id { get; set; }
	}

	public partial class Label
	{
		[JsonProperty("Type")]
		public Type Type { get; set; }

		[JsonProperty("Purpose")]
		public string Purpose { get; set; }

		[JsonProperty("Label")]
		public string LabelLabel { get; set; }
	}
}
