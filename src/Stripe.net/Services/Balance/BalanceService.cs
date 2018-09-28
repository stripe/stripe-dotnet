namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class BalanceService : StripeService,
        ISingletonRetrievable<Balance>
    {
        private static string classUrl = Urls.BaseUrl + "/balance";

        public BalanceService()
            : base(null)
        {
        }

        public BalanceService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return Mapper<Balance>.MapFromJson(
                Requestor.GetString(classUrl, this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Balance>.MapFromJson(
                await Requestor.GetStringAsync(classUrl, this.SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false));
        }
    }
}
