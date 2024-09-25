// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterEventService : Service
    {
        internal MeterEventService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MeterEventService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a meter event. Events are validated synchronously, but are processed
        /// asynchronously. Supports up to 1,000 events per second in livemode. For higher
        /// rate-limits, please use meter event streams instead.
        /// </summary>
        public virtual MeterEvent Create(MeterEventCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeterEvent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_events", options, requestOptions);
        }

        /// <summary>
        /// Creates a meter event. Events are validated synchronously, but are processed
        /// asynchronously. Supports up to 1,000 events per second in livemode. For higher
        /// rate-limits, please use meter event streams instead.
        /// </summary>
        public virtual Task<MeterEvent> CreateAsync(MeterEventCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterEvent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_events", options, requestOptions, cancellationToken);
        }
    }
}
