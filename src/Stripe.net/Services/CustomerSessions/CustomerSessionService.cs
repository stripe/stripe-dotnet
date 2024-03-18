// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerSessionService : Service<CustomerSession>,
        ICreatable<CustomerSession, CustomerSessionCreateOptions>
    {
        public CustomerSessionService()
        {
        }

        public CustomerSessionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/customer_sessions";

        /// <summary>
        /// <p>Creates a customer session object that includes a single-use client secret that you
        /// can use on your front-end to grant client-side API access for certain customer
        /// resources.</p>.
        /// </summary>
        public virtual CustomerSession Create(CustomerSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerSession>(HttpMethod.Post, $"/v1/customer_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a customer session object that includes a single-use client secret that you
        /// can use on your front-end to grant client-side API access for certain customer
        /// resources.</p>.
        /// </summary>
        public virtual Task<CustomerSession> CreateAsync(CustomerSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerSession>(HttpMethod.Post, $"/v1/customer_sessions", options, requestOptions, cancellationToken);
        }
    }
}
