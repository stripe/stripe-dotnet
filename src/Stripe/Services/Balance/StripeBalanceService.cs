using System;
using System.Collections.Generic;

namespace Stripe
{
	public class StripeBalanceService
	{
		private string ApiKey { get; set; }

		public StripeBalanceService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeBalance Get()
		{
			var response = Requestor.GetString(Urls.Balance, ApiKey);

			return Mapper<StripeBalance>.MapFromJson(response);
		}

		public virtual StripeBalanceTransaction Get(string id)
		{
			var response = Requestor.GetString(Urls.BalanceTransactions + "/" + id, ApiKey);

			return Mapper<StripeBalanceTransaction>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeBalanceTransaction> List(StripeBalanceTransactionListOptions options = null)
		{
			var url = Urls.BalanceTransactions;
			if (options != null)
			{
				url = ParameterBuilder.ApplyAllParameters(options, url);
			}

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeBalanceTransaction>.MapCollectionFromJson(response);
		}
	}
}
