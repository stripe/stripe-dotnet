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
        /// Creates a meter event. Validates the event synchronously.
        /// </summary>
        public virtual MeterEventV2 Create(MeterEventCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeterEventV2>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_events", options, requestOptions);
        }

        /// <summary>
        /// Creates a meter event. Validates the event synchronously.
        /// </summary>
        public virtual Task<MeterEventV2> CreateAsync(MeterEventCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterEventV2>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_events", options, requestOptions, cancellationToken);
        }
    }
}
