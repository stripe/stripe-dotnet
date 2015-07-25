using System.Collections.Generic;

namespace Stripe
{
    public class StripeBalanceService : StripeService
    {
        public StripeBalanceService(string apiKey = null) : base(apiKey) { }

        public virtual StripeBalance Get(StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var response = Requestor.GetString(Urls.Balance, requestOptions);
            
            return Mapper<StripeBalance>.MapFromJson(response);
        }

        public virtual StripeBalanceTransaction Get(string id, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.SpecificBalanceTransaction, id);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeBalanceTransaction>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeBalanceTransaction> List(StripeBalanceTransactionListOptions options = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.BalanceTransactions;
            url = this.ApplyAllParameters(options, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeBalanceTransaction>.MapCollectionFromJson(response);
        }
    }
}
