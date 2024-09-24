// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterEventAdjustmentService : Service
    {
        internal MeterEventAdjustmentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MeterEventAdjustmentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a meter event adjustment to cancel a previously sent meter event.
        /// </summary>
        public virtual MeterEventAdjustmentV2 Create(MeterEventAdjustmentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeterEventAdjustmentV2>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_event_adjustments", options, requestOptions);
        }

        /// <summary>
        /// Creates a meter event adjustment to cancel a previously sent meter event.
        /// </summary>
        public virtual Task<MeterEventAdjustmentV2> CreateAsync(MeterEventAdjustmentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterEventAdjustmentV2>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_event_adjustments", options, requestOptions, cancellationToken);
        }
    }
}
