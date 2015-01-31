using System.Collections.Generic;

namespace Stripe
{
    public class StripeBalanceService : StripeService
    {
        public StripeBalanceService(string apiKey = null) : base(apiKey) { }

        public virtual StripeBalance Get()
        {
            var response = Requestor.GetString(Urls.Balance, ApiKey);
            
            return Mapper<StripeBalance>.MapFromJson(response);
        }

        public virtual StripeBalanceTransaction Get(string id)
        {
            var url = string.Format(Urls.SpecificBalanceTransaction, id);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeBalanceTransaction>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeBalanceTransaction> List(StripeBalanceTransactionListOptions options = null)
        {
            var url = Urls.BalanceTransactions;
            url = this.ApplyAllParameters(options, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeBalanceTransaction>.MapCollectionFromJson(response);
        }
    }
}
