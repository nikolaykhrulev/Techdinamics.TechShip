using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techdinamics.TechShip.Dto.Request;

namespace Techdinamics.TechShip.Tests
{
	[TestClass]
	public class ShipmentsTest
	{
		const string apiKey = "YOUR_API_KEY";
		const string secretKey = "YOUR_SECRET_KEY";

		[TestMethod]
		public async Task RateShopShipment_Success()
		{
			var shipment = new Shipment
			{
				Sequence = 1,
				ShipToAddress1 = "123 SAMPLE STREET",
				ShipToCountry = "US",
				ShipToName = "JOHN SMITH",
				ServiceCode = "GRD",
				TransactionNumber = "TEST123456788",
				ShipToPostal = "46774",
				ShipToCity = "NEW HAVEN",
				ShipToStateProvince = "IN",
				ShipToPhone = "11111111111",
				Packages = new Dto.Request.Package[]
				{
					new Dto.Request.Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Dto.Request.Item[]
						{
							new Dto.Request.Item{
								Sku = "TST",
								LotNumber = "LT1",
								SerialNumber = "",
								Description = "TEST",
								Description2 = "",
								Quantity = 1,
								UnitPrice = 1,
								ExpirationDate = "2099-07-19T17:12:02.731Z",
								Uom = "Each",
								Supplier = "",
								CountryOfOrigin = "US"
							}
						}
					}
				},
				ClientCode = "Test",
				Terms = "SHIPPER"
			};

			var result = await new Shipments().RateShop(
				apiKey: apiKey,
				secretKey: secretKey,
				duplicateHandling: "2",
				shipment: shipment
			);

			Assert.IsNotNull(result.ShipmentId);
		}

		[TestMethod]
		public async Task CarrierShipment_Success()
		{
			var shipment = new Shipment
			{
				Sequence = 1,
				ShipToAddress1 = "123 SAMPLE STREET",
				ShipToCountry = "US",
				ShipToName = "JOHN SMITH",
				CarrierCode = "UPSN",
				ServiceCode = "STD",
				TransactionNumber = "TEST123890122",
				ShipToPostal = "46774",
				ShipToCity = "NEW HAVEN",
				ShipToStateProvince = "IN",
				ShipToPhone = "11111111111",
				Packages = new Dto.Request.Package[]
				{
					new Dto.Request.Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Dto.Request.Item[]
						{
							new Dto.Request.Item{
								Sku = "TST",
								LotNumber = "LT1",
								SerialNumber = "",
								Description = "TEST",
								Description2 = "",
								Quantity = 1,
								UnitPrice = 1,
								ExpirationDate = "2099-07-19T17:12:02.731Z",
								Uom = "Each",
								Supplier = "",
								CountryOfOrigin = "US"
							}
						}
					}
				},
				ClientCode = "Test",
				Terms = "SHIPPER"
			};

			var result = await new Shipments().Carrier(
				apiKey: apiKey,
				secretKey: secretKey,
				duplicateHandling: "2",
				cancelLabelAfter: "101",
				shipment: shipment
			);

			Assert.IsNotNull(result.ShipmentId);
		}

		[TestMethod]
		public async Task VoidShipment_Success()
		{
			var result = await new Shipments().Void(
				apiKey: apiKey,
				secretKey: secretKey,
				shipmentId: "35776482"
			);

			Assert.Equals(result.Success, true);
		}

		[TestMethod]
		public async Task GetShipment_Success()
		{
			var result = await new Shipments().Get(
				apiKey: apiKey,
				secretKey: secretKey,
				shipmentId: "35776482"
			);

			Assert.IsNotNull(result.ClientCode);
		}

		[TestMethod]
		public void RateShopBatch_Success()
		{
			var shipments = new List<Shipment>();
			foreach (var transactionNumber in Enumerable.Range(1, 100))
			{
				var shipment = new Shipment
				{
					Sequence = 1,
					ShipToAddress1 = "123 SAMPLE STREET",
					ShipToCountry = "US",
					ShipToName = "JOHN SMITH",
					ServiceCode = "GRD",
					TransactionNumber = $"TEST{transactionNumber}",
					ShipToPostal = "46774",
					ShipToCity = "NEW HAVEN",
					ShipToStateProvince = "IN",
					ShipToPhone = "11111111111",
					Packages = new Dto.Request.Package[]
					{
					new Dto.Request.Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Dto.Request.Item[]
						{
							new Dto.Request.Item{
								Sku = "TST",
								LotNumber = "LT1",
								SerialNumber = "",
								Description = "TEST",
								Description2 = "",
								Quantity = 1,
								UnitPrice = 1,
								ExpirationDate = "2099-07-19T17:12:02.731Z",
								Uom = "Each",
								Supplier = "",
								CountryOfOrigin = "US"
							}
						}
					}
					},
					ClientCode = "Test",
					Terms = "SHIPPER"
				};

				shipments.Add(shipment);
			}

			var result = new Shipments().RateShopBatch(
				apiKey: apiKey,
				secretKey: secretKey,
				duplicateHandling: "2",
				shipments: shipments.ToArray()
			);

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void CarrierBatch_Success()
		{
			var shipments = new List<Shipment>();
			foreach (var transactionNumber in Enumerable.Range(1, 100))
			{
				var shipment = new Shipment
				{
					Sequence = 1,
					ShipToAddress1 = "123 SAMPLE STREET",
					ShipToCountry = "US",
					ShipToName = "JOHN SMITH",
					ServiceCode = "GRD",
					TransactionNumber = $"TEST{transactionNumber}",
					ShipToPostal = "46774",
					ShipToCity = "NEW HAVEN",
					ShipToStateProvince = "IN",
					ShipToPhone = "11111111111",
					Packages = new Dto.Request.Package[]
					{
					new Dto.Request.Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Dto.Request.Item[]
						{
							new Dto.Request.Item{
								Sku = "TST",
								LotNumber = "LT1",
								SerialNumber = "",
								Description = "TEST",
								Description2 = "",
								Quantity = 1,
								UnitPrice = 1,
								ExpirationDate = "2099-07-19T17:12:02.731Z",
								Uom = "Each",
								Supplier = "",
								CountryOfOrigin = "US"
							}
						}
					}
					},
					ClientCode = "Test",
					Terms = "SHIPPER"
				};

				shipments.Add(shipment);
			}

			var result = new Shipments().CarrierBatch(
				apiKey: apiKey,
				secretKey: secretKey,
				cancelLabelAfter: "8",
				duplicateHandling: "2",
				shipments: shipments.ToArray()
			);

			Assert.IsNotNull(result);
		}
	}
}
