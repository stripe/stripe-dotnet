// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterEventAdjustmentService : Service<MeterEventAdjustment>,
        ICreatable<MeterEventAdjustment, MeterEventAdjustmentCreateOptions>
    {
        public MeterEventAdjustmentService()
        {
        }

        public MeterEventAdjustmentService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/meter_event_adjustments";

        /// <summary>
        /// <p>Creates a billing meter event adjustment</p>.
        /// </summary>
        public virtual MeterEventAdjustment Create(MeterEventAdjustmentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeterEventAdjustment>(HttpMethod.Post, $"/v1/billing/meter_event_adjustments", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a billing meter event adjustment</p>.
        /// </summary>
        public virtual Task<MeterEventAdjustment> CreateAsync(MeterEventAdjustmentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterEventAdjustment>(HttpMethod.Post, $"/v1/billing/meter_event_adjustments", options, requestOptions, cancellationToken);
        }
    }
}
