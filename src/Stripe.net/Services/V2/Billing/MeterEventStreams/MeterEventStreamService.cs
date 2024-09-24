// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterEventStreamService : Service
    {
        internal MeterEventStreamService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MeterEventStreamService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Sends a meter event for asynchronous processing. Supports higher rate limits. Requires a
        /// meter event session for authentication.
        /// </summary>
        public virtual void Create(MeterEventStreamCreateOptions options, RequestOptions requestOptions = null)
        {
            this.Request<EmptyStripeEntity>(BaseAddress.MeterEvents, HttpMethod.Post, $"/v2/billing/meter_event_stream", options, requestOptions);
        }

        /// <summary>
        /// Sends a meter event for asynchronous processing. Supports higher rate limits. Requires a
        /// meter event session for authentication.
        /// </summary>
        public virtual Task<EmptyStripeEntity> CreateAsync(MeterEventStreamCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<EmptyStripeEntity>(BaseAddress.MeterEvents, HttpMethod.Post, $"/v2/billing/meter_event_stream", options, requestOptions, cancellationToken);
        }
    }
}
