// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentLocationService : Service,
        ICreatable<PaymentLocation, PaymentLocationCreateOptions>
    {
        public PaymentLocationService()
        {
        }

        internal PaymentLocationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentLocationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create a Payment Location.</p>.
        /// </summary>
        public virtual PaymentLocation Create(PaymentLocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLocation>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a Payment Location.</p>.
        /// </summary>
        public virtual Task<PaymentLocation> CreateAsync(PaymentLocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLocation>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_locations", options, requestOptions, cancellationToken);
        }
    }
}
