using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public virtual StripeBalanceTransaction GetBalanceTransaction(string balanceTransactionItemId)
		{
			var url = string.Format("{0}/{1}", Urls.BalanceTransaction, balanceTransactionItemId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeBalanceTransaction>.MapFromJson(response);
		}
        public virtual List<StripeBalanceTransaction> List(int count = 10, int offset = 0, string sourceChargeId = null,string transactionType = null)
		{
			var url = Urls.BalanceTransaction;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			if (!string.IsNullOrEmpty(sourceChargeId))
				url = ParameterBuilder.ApplyParameterToUrl(url, "source", sourceChargeId);
            if (!string.IsNullOrEmpty(transactionType))
				url = ParameterBuilder.ApplyParameterToUrl(url, "type", transactionType);
			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeBalanceTransaction>.MapCollectionFromJson(response);
		}
    }
}
