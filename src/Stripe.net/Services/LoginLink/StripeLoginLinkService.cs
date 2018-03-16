using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeLoginLinkService : StripeBasicService<StripeLoginLink>
    {
        public StripeLoginLinkService() : base(null) { }
        public StripeLoginLinkService(string apiKey) : base(apiKey) { }



        //Sync
        public virtual StripeLoginLink Create(string accountId, StripeLoginLinkCreateOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/accounts/{accountId}/login_links", requestOptions, options);
        }



        // Async
        public virtual Task<StripeLoginLink> CreateAsync(string accountId, StripeLoginLinkCreateOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/login_links", requestOptions, cancellationToken, options);
        }
    }
}
