using Newtonsoft.Json;
using System;

namespace Techdinamics.TechShip.Dto.Response
{
	public partial class GetShipment
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

		[JsonProperty("Terms")]
		public string Terms { get; set; }

		[JsonProperty("Sequence")]
		public string Sequence { get; set; }

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

		[JsonProperty("PickupDateTime")]
		public string PickupDateTime { get; set; }

		[JsonProperty("DeliveryDateTime")]
		public string DeliveryDateTime { get; set; }

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

		[JsonProperty("ThirdPartyBillingAccount")]
		public string ThirdPartyBillingAccount { get; set; }

		[JsonProperty("ThirdPartyBillingPostal")]
		public string ThirdPartyBillingPostal { get; set; }

		[JsonProperty("ThirdPartyBillingCountryCode")]
		public string ThirdPartyBillingCountryCode { get; set; }

		[JsonProperty("SignatureRequired")]
		public bool SignatureRequired { get; set; }

		[JsonProperty("PostOfficeId")]
		public string PostOfficeId { get; set; }

		[JsonProperty("HoldForPickupIndicator")]
		public bool HoldForPickupIndicator { get; set; }

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

		[JsonProperty("BillToPostal")]
		public string BillToPostal { get; set; }

		[JsonProperty("BillToCountry")]
		public string BillToCountry { get; set; }

		[JsonProperty("BillToPhone")]
		public string BillToPhone { get; set; }

		[JsonProperty("BillToEmail")]
		public string BillToEmail { get; set; }

		[JsonProperty("HasBillToAddress")]
		public string HasBillToAddress { get; set; }

		[JsonProperty("ShipFromName")]
		public string ShipFromName { get; set; }

		[JsonProperty("ShipFromCompany")]
		public string ShipFromCompany { get; set; }

		[JsonProperty("ShipFromAddress1")]
		public string ShipFromAddress1 { get; set; }

		[JsonProperty("ShipFromAddress2")]
		public string ShipFromAddress2 { get; set; }

		[JsonProperty("ShipFromAddress3")]
		public string ShipFromAddress3 { get; set; }

		[JsonProperty("ShipFromCity")]
		public string ShipFromCity { get; set; }

		[JsonProperty("ShipFromStateProvince")]
		public string ShipFromStateProvince { get; set; }

		[JsonProperty("ShipFromPostal")]
		public string ShipFromPostal { get; set; }

		[JsonProperty("ShipFromCountry")]
		public string ShipFromCountry { get; set; }

		[JsonProperty("ShipFromPhone")]
		public string ShipFromPhone { get; set; }

		[JsonProperty("ShipFromEmail")]
		public string ShipFromEmail { get; set; }

		[JsonProperty("HasShipFromAddress")]
		public string HasShipFromAddress { get; set; }

		[JsonProperty("LabelName")]
		public string LabelName { get; set; }

		[JsonProperty("LabelCompany")]
		public string LabelCompany { get; set; }

		[JsonProperty("LabelAddress1")]
		public string LabelAddress1 { get; set; }

		[JsonProperty("LabelAddress2")]
		public string LabelAddress2 { get; set; }

		[JsonProperty("LabelAddress3")]
		public string LabelAddress3 { get; set; }

		[JsonProperty("LabelCity")]
		public string LabelCity { get; set; }

		[JsonProperty("LabelStateProvince")]
		public string LabelStateProvince { get; set; }

		[JsonProperty("LabelPostal")]
		public string LabelPostal { get; set; }

		[JsonProperty("LabelCountry")]
		public string LabelCountry { get; set; }

		[JsonProperty("LabelPhone")]
		public string LabelPhone { get; set; }

		[JsonProperty("LabelEmail")]
		public string LabelEmail { get; set; }

		[JsonProperty("HasLabelAddress")]
		public string HasLabelAddress { get; set; }

		[JsonProperty("FreightPaymentTerms")]
		public string FreightPaymentTerms { get; set; }

		[JsonProperty("FreightClass")]
		public string FreightClass { get; set; }

		[JsonProperty("FreightNMFCClass")]
		public string FreightNmfcClass { get; set; }

		[JsonProperty("RateShoppingGroup")]
		public string RateShoppingGroup { get; set; }

		[JsonProperty("SkipAddressValidation")]
		public bool SkipAddressValidation { get; set; }

		[JsonProperty("SignatureAdult")]
		public bool SignatureAdult { get; set; }

		[JsonProperty("SaturdayPickup")]
		public bool SaturdayPickup { get; set; }

		[JsonProperty("SaturdayDelivery")]
		public bool SaturdayDelivery { get; set; }

		[JsonProperty("HoldAtLocation")]
		public bool HoldAtLocation { get; set; }

		[JsonProperty("AppointmentDelivery")]
		public bool AppointmentDelivery { get; set; }

		[JsonProperty("DryIce")]
		public bool DryIce { get; set; }

		[JsonProperty("SpecialHandling")]
		public bool SpecialHandling { get; set; }

		[JsonProperty("CustomFields")]
		public string[] CustomFields { get; set; }

		[JsonProperty("Packages")]
		public Package[] Packages { get; set; }

		[JsonProperty("Id")]
		public string Id { get; set; }
	}

	public partial class Package
	{
		[JsonProperty("ShippingCharge")]
		public string ShippingCharge { get; set; }

		[JsonProperty("ShippingChargeTotal")]
		public string ShippingChargeTotal { get; set; }

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

		[JsonProperty("FuelSurcharge")]
		public string FuelSurcharge { get; set; }

		[JsonProperty("TrackingNumber")]
		public string TrackingNumber { get; set; }

		[JsonProperty("SSCC")]
		public string Sscc { get; set; }

		[JsonProperty("Weight")]
		public string Weight { get; set; }

		[JsonProperty("BoxWidth")]
		public string BoxWidth { get; set; }

		[JsonProperty("BoxHeight")]
		public string BoxHeight { get; set; }

		[JsonProperty("BoxLength")]
		public string BoxLength { get; set; }

		[JsonProperty("CustomerSKU")]
		public string CustomerSku { get; set; }

		[JsonProperty("WarehouseSKU")]
		public string WarehouseSku { get; set; }

		[JsonProperty("DeclaredValue")]
		public string DeclaredValue { get; set; }

		[JsonProperty("Items")]
		public Item[] Items { get; set; }

		[JsonProperty("Labels")]
		public Label[] Labels { get; set; }

		[JsonProperty("PackingSlips")]
		public Label[] PackingSlips { get; set; }

		[JsonProperty("Description")]
		public string Description { get; set; }

		[JsonProperty("FreightClass")]
		public string FreightClass { get; set; }

		[JsonProperty("Id")]
		public string Id { get; set; }
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
		public string Quantity { get; set; }

		[JsonProperty("UnitPrice")]
		public string UnitPrice { get; set; }

		[JsonProperty("ExpirationDate")]
		public DateTimeOffset ExpirationDate { get; set; }

		[JsonProperty("UOM")]
		public string Uom { get; set; }

		[JsonProperty("Supplier")]
		public string Supplier { get; set; }

		[JsonProperty("CountryOfOrigin")]
		public string CountryOfOrigin { get; set; }

		[JsonProperty("HarmonizedCode")]
		public string HarmonizedCode { get; set; }

		[JsonProperty("Id")]
		public string Id { get; set; }
	}

	public partial class Label
	{
		[JsonProperty("Type")]
		public string Type { get; set; }

		[JsonProperty("Label")]
		public string LabelLabel { get; set; }

		[JsonProperty("Purpose")]
		public string Purpose { get; set; }
	}
}
