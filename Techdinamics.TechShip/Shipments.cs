using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using Techdinamics.TechShip.Dto.Request;
using Techdinamics.TechShip.Dto.Response;

namespace Techdinamics.TechShip
{
	public class Shipments
	{
		const string baseUrl = "https://test-api-us.techship.io/api/v2/shipments/";
		const int maxDegreeOfParallelism = 10;

		private readonly static JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		};

		public async Task<RateShopShipment> RateShop(
			string apiKey,
			string secretKey,
			string duplicateHandling,
			Shipment shipment)
		{
			string route = $"create?duplicateHandling={duplicateHandling}";
			var connection = GetConnection(apiKey, secretKey, route, Method.POST, shipment);

			var body = JsonConvert.SerializeObject(shipment);
			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to rate shop shipments: {body}");
			}

			var result = JsonConvert.DeserializeObject<RateShopShipment>(restResponse.Content);

			return result;
		}

		public async Task<CarrierShipment> Carrier(
			string apiKey,
			string secretKey,
			string cancelLabelAfter,
			string duplicateHandling,
			Shipment shipment)
		{
			string route = $"create?duplicateHandling={duplicateHandling}";
			var connection = GetConnection(apiKey, secretKey, route, Method.POST, shipment);
			connection.Request.AddHeader("x-cancel-label-after", cancelLabelAfter);

			var body = JsonConvert.SerializeObject(shipment);
			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to carrier shipments: {body}");
			}

			var result = JsonConvert.DeserializeObject<CarrierShipment>(restResponse.Content);

			return result;
		}

		public async Task<VoidShipment> Void(
			string apiKey,
			string secretKey,
			string shipmentId)
		{
			string route = $"{shipmentId}/delete";
			var connection = GetConnection<string>(apiKey, secretKey, route, Method.PUT);
			connection.Request.AlwaysMultipartFormData = true;

			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to void shipments");
			}

			var result = JsonConvert.DeserializeObject<VoidShipment>(restResponse.Content);

			return result;
		}

		public async Task<GetShipment> Get(
			string apiKey,
			string secretKey,
			string shipmentId)
		{
			var connection = GetConnection<string>(apiKey, secretKey, shipmentId, Method.GET);

			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to get shipments");
			}

			var result = JsonConvert.DeserializeObject<GetShipment>(restResponse.Content);

			return result;
		}

		public object RateShopBatch(
			string apiKey,
			string secretKey,
			string duplicateHandling,
			Shipment[] shipments)
		{
			Parallel.ForEach(shipments, new ParallelOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism }, async (shipment) =>
			{
				try
				{
					await RateShop(apiKey, secretKey, duplicateHandling, shipment);
				}
				catch (Exception ex)
				{
					throw new ApplicationException(ex.Message);
				}
			});

			return new
			{
				Success = true
			};
		}

		public object CarrierBatch(
			string apiKey,
			string secretKey,
			string cancelLabelAfter,
			string duplicateHandling,
			Shipment[] shipments)
		{
			Parallel.ForEach(shipments, new ParallelOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism }, async (shipment) =>
			{
				try
				{
					await Carrier(apiKey, secretKey, cancelLabelAfter, duplicateHandling, shipment);
				}
				catch (Exception ex)
				{
					throw new ApplicationException(ex.Message);
				}
			});

			return new
			{
				Success = true
			};
		}

		private TechShipConnection GetConnection<T>(
			string apiKey,
			string secretKey,
			string route,
			Method method,
			T data = default)
		{
			var client = new RestClient(baseUrl);
			var request = new RestRequest(route, method);
			request.AddHeader("x-api-key", apiKey);
			request.AddHeader("x-secret-key", secretKey);
			request.AddHeader("Content-Type", "application/json");

			if (method == Method.POST)
			{
				request.AddParameter(
					"application/json",
					JsonConvert.SerializeObject(data, _jsonSerializerSettings),
					ParameterType.RequestBody
				);
			}

			return new TechShipConnection
			{
				Client = client,
				Request = request
			};
		}
	}

	public class TechShipConnection
	{
		public RestClient Client { get; set; }
		public RestRequest Request { get; set; }
	}
}
