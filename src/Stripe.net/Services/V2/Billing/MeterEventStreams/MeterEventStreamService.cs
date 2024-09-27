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
        /// Creates meter events. Events are processed asynchronously, including validation.
        /// Requires a meter event session for authentication. Supports up to 10,000 requests per
        /// second in livemode. For even higher rate-limits, contact sales.
        /// </summary>
        public virtual void Create(MeterEventStreamCreateOptions options, RequestOptions requestOptions = null)
        {
            this.Request<EmptyStripeEntity>(BaseAddress.MeterEvents, HttpMethod.Post, $"/v2/billing/meter_event_stream", options, requestOptions);
        }

        /// <summary>
        /// Creates meter events. Events are processed asynchronously, including validation.
        /// Requires a meter event session for authentication. Supports up to 10,000 requests per
        /// second in livemode. For even higher rate-limits, contact sales.
        /// </summary>
        public virtual Task<EmptyStripeEntity> CreateAsync(MeterEventStreamCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<EmptyStripeEntity>(BaseAddress.MeterEvents, HttpMethod.Post, $"/v2/billing/meter_event_stream", options, requestOptions, cancellationToken);
        }
    }
}
