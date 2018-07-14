namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeLoginLinkService : StripeBasicService<StripeLoginLink>
    {
        public StripeLoginLinkService()
            : base(null)
        {
        }

        public StripeLoginLinkService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeLoginLink Create(string accountId, StripeLoginLinkCreateOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/accounts/{accountId}/login_links", requestOptions, options);
        }

        public virtual Task<StripeLoginLink> CreateAsync(string accountId, StripeLoginLinkCreateOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/login_links", requestOptions, cancellationToken, options);
        }
    }
}
