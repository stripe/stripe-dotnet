using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeLoginLinkService : StripeService
    {
        public StripeLoginLinkService(string apiKey = null) : base(apiKey) { }

        //Sync
        public virtual StripeLoginLink Create(string accountId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeLoginLink>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(null, $"{Urls.BaseUrl}/accounts/{accountId}/login_links", false),
                SetupRequestOptions(requestOptions))
            );
        }
    }
}
