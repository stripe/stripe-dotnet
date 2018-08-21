namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class LoginLinkService : BasicService<StripeLoginLink>
    {
        public LoginLinkService()
            : base(null)
        {
        }

        public LoginLinkService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeLoginLink Create(string accountId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/accounts/{accountId}/login_links", requestOptions, options);
        }

        public virtual Task<StripeLoginLink> CreateAsync(string accountId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/login_links", requestOptions, cancellationToken, options);
        }
    }
}
