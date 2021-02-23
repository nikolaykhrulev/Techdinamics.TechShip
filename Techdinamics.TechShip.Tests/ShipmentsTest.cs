using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techdinamics.TechShip.Dto.Request;

namespace Techdinamics.TechShip.Tests
{
	[TestClass]
	public class ShipmentsTest
	{
		const string _apiKey = "YOUR_API_KEY";
		const string _secretKey = "YOUR_SECRET_KEY";
		
		[TestMethod]
		public async Task RateShopShipment_Success()
		{
			var shipment = new ShipmentRequest
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
				Packages = new Package[]
				{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			var result = await new Shipments(_apiKey, _secretKey).RateShop(
				duplicateHandling: "2",
				shipment: shipment
			);

			Assert.IsNotNull(result.ShipmentId);
		}

		[TestMethod]
		public void RateShopShipment_BadRequest()
		{
			var shipment = new ShipmentRequest
			{
				Sequence = 1,
				ShipToAddress1 = "123 SAMPLE STREET",
				ShipToCountry = "US",
				ShipToName = "JOHN SMITH",
				ServiceCode = "GRD",
				TransactionNumber = "123456789098765432101234567890987654321012345678909876543210123456789098765432101234567890987654321012345678909876543210123456789098765432101234567890987654321012345678909876543210123456789098765432101234567890987654321012345678909876543210123456789098765",
				ShipToPostal = "46774",
				ShipToCity = "NEW HAVEN",
				ShipToStateProvince = "IN",
				ShipToPhone = "11111111111",
				Packages = new Package[]
				{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).RateShop(
					duplicateHandling: "2",
					shipment: shipment
				)
			);
		}

		[TestMethod]
		public void RateShopShipment_WithoutRequiredProp()
		{
			var shipment = new ShipmentRequest
			{
				Sequence = 1,
				ShipToAddress1 = "123 SAMPLE STREET",
				ShipToCountry = "US",
				ShipToName = "JOHN SMITH",
				ServiceCode = "GRD",
				ShipToPostal = "46774",
				ShipToCity = "NEW HAVEN",
				ShipToStateProvince = "IN",
				ShipToPhone = "11111111111",
				Packages = new Package[]
				{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).RateShop(
					duplicateHandling: "2",
					shipment: shipment
				)
			);
		}

		[TestMethod]
		public void RateShopShipment_RequestIsNull()
		{
			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).RateShop(
					duplicateHandling: "2",
					shipment: null
				)
			);
		}

		[TestMethod]
		public async Task CarrierShipment_Success()
		{
			var shipment = new ShipmentRequest
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
				Packages = new Package[]
				{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			var result = await new Shipments(_apiKey, _secretKey).Carrier(
				duplicateHandling: "2",
				shipment: shipment
			);

			Assert.IsNotNull(result.ShipmentId);
		}

		[TestMethod]
		public void CarrierShipment_BadRequest()
		{
			var shipment = new ShipmentRequest
			{
				Sequence = 1,
				ShipToAddress1 = "123 SAMPLE STREET",
				ShipToCountry = "US",
				ShipToName = "JOHN SMITH",
				CarrierCode = "UPSN",
				ServiceCode = "STD",
				TransactionNumber = "987654321012345678909876543210123456789098765432101234567890987654321012345678909876543210123456789098765432101234567890987654321012345678909876543210123456789098765432101234567890987654321012345678909876543210123456789098765432101234567890987654321012345",
				ShipToPostal = "46774",
				ShipToCity = "NEW HAVEN",
				ShipToStateProvince = "IN",
				ShipToPhone = "11111111111",
				Packages = new Package[]
				{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).Carrier(
					duplicateHandling: "2",
					shipment: shipment
				)
			);
		}

		[TestMethod]
		public void CarrierShipment_WithoutRequiredProp()
		{
			var shipment = new ShipmentRequest
			{
				Sequence = 1,
				ShipToAddress1 = "123 SAMPLE STREET",
				ShipToCountry = "US",
				ShipToName = "JOHN SMITH",
				CarrierCode = "UPSN",
				ServiceCode = "STD",
				ShipToPostal = "46774",
				ShipToCity = "NEW HAVEN",
				ShipToStateProvince = "IN",
				ShipToPhone = "11111111111",
				Packages = new Package[]
				{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).Carrier(
					duplicateHandling: "2",
					shipment: shipment
				)
			);
		}

		[TestMethod]
		public void CarrierShipment_RequestIsNull()
		{
			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).Carrier(
					duplicateHandling: "2",
					shipment: null
				)
			);
		}

		[TestMethod]
		public async Task VoidShipment_Success()
		{
			var result = await new Shipments(_apiKey, _secretKey).Void(shipmentId: "35776482");

			Assert.Equals(result.Success, true);
		}

		[TestMethod]
		public void VoidShipment_Error()
		{
			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).Get(shipmentId: "-1")
			);
		}

		[TestMethod]
		public async Task GetShipment_Success()
		{
			var result = await new Shipments(_apiKey, _secretKey).Get(shipmentId: "35776482");

			Assert.IsNotNull(result.ClientCode);
		}

		[TestMethod]
		public void GetShipment_Error()
		{
			Assert.ThrowsExceptionAsync<ApplicationException>(
				async () => await new Shipments(_apiKey, _secretKey).Get(shipmentId: "0")
			);
		}

		[TestMethod]
		public void RateShopBatch_Success()
		{
			var shipments = new List<ShipmentRequest>();
			foreach (var transactionNumber in Enumerable.Range(1, 100))
			{
				var shipment = new ShipmentRequest
				{
					Sequence = 1,
					ShipToAddress1 = "123 SAMPLE STREET",
					ShipToCountry = "US",
					ShipToName = "JOHN SMITH",
					ServiceCode = "GRD",
					TransactionNumber = $"TEST {Guid.NewGuid()} {transactionNumber}",
					ShipToPostal = "46774",
					ShipToCity = "NEW HAVEN",
					ShipToStateProvince = "IN",
					ShipToPhone = "11111111111",
					Packages = new Package[]
					{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			var result = new Shipments(_apiKey, _secretKey).RateShopBatch(
				duplicateHandling: "2",
				shipments: shipments.ToArray()
			);

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void CarrierBatch_Success()
		{
			var shipments = new List<ShipmentRequest>();
			foreach (var transactionNumber in Enumerable.Range(1, 100))
			{
				var shipment = new ShipmentRequest
				{
					Sequence = 1,
					ShipToAddress1 = "123 SAMPLE STREET",
					ShipToCountry = "US",
					ShipToName = "JOHN SMITH",
					ServiceCode = "GRD",
					TransactionNumber = $"TEST {Guid.NewGuid()} {transactionNumber}",
					ShipToPostal = "46774",
					ShipToCity = "NEW HAVEN",
					ShipToStateProvince = "IN",
					ShipToPhone = "11111111111",
					Packages = new Package[]
					{
					new Package {
						Weight = 2,
						BoxHeight = 1,
						BoxLength = 12,
						BoxWidth = 9,
						Items = new Item[]
						{
							new Item{
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

			var result = new Shipments(_apiKey, _secretKey).CarrierBatch(
				duplicateHandling: "2",
				shipments: shipments.ToArray()
			);

			Assert.IsNotNull(result);
		}
	}
}
