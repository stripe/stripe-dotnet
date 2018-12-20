namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CheckoutSessionService : Service<CheckoutSession>,
        ICreatable<CheckoutSession, CheckoutSessionCreateOptions>
    {
        public CheckoutSessionService()
            : base(null)
        {
        }

        public CheckoutSessionService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/checkout_sessions";

        public virtual CheckoutSession Create(CheckoutSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<CheckoutSession> CreateAsync(CheckoutSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}
