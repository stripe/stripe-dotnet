using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeTransferService : BaseStripeService
	{
		public StripeTransferService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeTransfer> Create(StripeTransferCreateOptions createOptions)
		{
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(Urls.Transfers, data, ApiKey);

			return Mapper<StripeTransfer>.MapFromJson(response);
		}

		public virtual async Task<StripeTransfer> Get(string transferId)
		{
			var url = string.Format("{0}/{1}", Urls.Transfers, transferId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeTransfer>.MapFromJson(response);
		}

		public virtual async Task<StripeTransfer> Cancel(string transferId)
		{
			var url = string.Format("{0}/{1}/cancel", Urls.Transfers, transferId);
		    var data = new List<KeyValuePair<string, string>>();
			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeTransfer>.MapFromJson(response);
		}

		public virtual async Task<List<StripeTransfer>> List(int count = 10, int offset = 0, string recipientId = null, string status = null)
		{
            var data = new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    };

            if (!string.IsNullOrEmpty(recipientId))
                data.Add(new KeyValuePair<string, string>("recipient", recipientId));

            if (!string.IsNullOrEmpty(status))
               data.Add(new KeyValuePair<string, string>("status", status));

			var url = ParameterBuilder.ApplyDataToUrl(Urls.Transfers, data);
            
			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeTransfer>.MapCollectionFromJson(response);
		}
	}
}