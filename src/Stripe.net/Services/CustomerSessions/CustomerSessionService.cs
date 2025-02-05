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

        internal CustomerSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a Customer Session object that includes a single-use client secret that you
        /// can use on your front-end to grant client-side API access for certain customer
        /// resources.</p>.
        /// </summary>
        public virtual CustomerSession Create(CustomerSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/customer_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a Customer Session object that includes a single-use client secret that you
        /// can use on your front-end to grant client-side API access for certain customer
        /// resources.</p>.
        /// </summary>
        public virtual Task<CustomerSession> CreateAsync(CustomerSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/customer_sessions", options, requestOptions, cancellationToken);
        }
    }
}
