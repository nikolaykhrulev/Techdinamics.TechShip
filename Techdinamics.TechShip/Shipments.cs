using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techdinamics.TechShip.Dto.Enum;
using Techdinamics.TechShip.Dto.Request;
using Techdinamics.TechShip.Dto.Response;

namespace Techdinamics.TechShip
{
	public class Shipments
	{
		readonly string _apiKey;
		readonly string _secretKey;
		const int _maxDegreeOfParallelism = 10;
		readonly string _baseUrl = "https://test-api-us.techship.io/api/v2/shipments/";

		private readonly static JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		};

		public Shipments(string apiKey, string secretKey)
		{
			_apiKey = apiKey;
			_secretKey = secretKey;
		}

		public async Task<ShipmentResponse> RateShop(DuplicateHandling duplicateHandling, ShipmentRequest shipment)
		{
			var connection = GetConnection("create", Method.POST, shipment);
			int duplicateHanlde = (int)duplicateHandling;
			connection.Request.AddQueryParameter("duplicateHandling", duplicateHanlde.ToString());

			var body = JsonConvert.SerializeObject(shipment);
			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to rate shop shipments: {body}");
			}

			var result = JsonConvert.DeserializeObject<ShipmentResponse>(restResponse.Content);

			return result;
		}

		public async Task<ShipmentResponse> Carrier(DuplicateHandling duplicateHandling, ShipmentRequest shipment)
		{
			var connection = GetConnection("create", Method.POST, shipment);
			int duplicateHanlde = (int)duplicateHandling;
			connection.Request.AddQueryParameter("duplicateHandling", duplicateHanlde.ToString());

			var body = JsonConvert.SerializeObject(shipment);
			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to carrier shipments: {body}");
			}

			var result = JsonConvert.DeserializeObject<ShipmentResponse>(restResponse.Content);

			return result;
		}

		public async Task<VoidShipment> Void(long shipmentId)
		{
			string route = $"{shipmentId}/delete";
			var connection = GetConnection<string>(route, Method.PUT);
			connection.Request.AlwaysMultipartFormData = true;

			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to void shipments");
			}

			var result = JsonConvert.DeserializeObject<VoidShipment>(restResponse.Content);

			return result;
		}

		public async Task<GetShipment> Get(string shipmentId)
		{
			var connection = GetConnection<string>(shipmentId, Method.GET);

			var restResponse = await connection.Client.ExecuteAsync(connection.Request);

			if (!restResponse.IsSuccessful)
			{
				throw new ApplicationException($"Server response: {restResponse.Content} ; failed to get shipments");
			}

			var result = JsonConvert.DeserializeObject<GetShipment>(restResponse.Content);

			return result;
		}

		public List<ShipmentResponse> RateShopBatch(DuplicateHandling duplicateHandling, ShipmentRequest[] shipments)
		{
			try
			{
				var result = new List<ShipmentResponse>();
				Parallel.ForEach(shipments, new ParallelOptions { MaxDegreeOfParallelism = _maxDegreeOfParallelism }, async (shipment) =>
				{
					result.Add(await RateShop(duplicateHandling, shipment));
				});

				return result;
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.ToString());
			}
		}

		public List<ShipmentResponse> CarrierBatch(DuplicateHandling duplicateHandling, ShipmentRequest[] shipments)
		{
			try
			{
				var result = new List<ShipmentResponse>();
				Parallel.ForEach(shipments, new ParallelOptions { MaxDegreeOfParallelism = _maxDegreeOfParallelism }, async (shipment) =>
				{
					result.Add(await Carrier(duplicateHandling, shipment));
				});

				return result;
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.ToString());
			}
		}

		private TechShipConnection GetConnection<T>(string route, Method method, T data = default)
		{
			var client = new RestClient(_baseUrl);
			var request = new RestRequest(route, method);
			request.AddHeader("x-api-key", _apiKey);
			request.AddHeader("x-secret-key", _secretKey);
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
