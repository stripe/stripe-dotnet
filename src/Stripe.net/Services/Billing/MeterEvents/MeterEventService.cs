// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterEventService : Service<MeterEvent>,
        ICreatable<MeterEvent, MeterEventCreateOptions>
    {
        public MeterEventService()
        {
        }

        public MeterEventService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/meter_events";

        /// <summary>
        /// <p>Creates a billing meter event</p>.
        /// </summary>
        public virtual MeterEvent Create(MeterEventCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeterEvent>(HttpMethod.Post, $"/v1/billing/meter_events", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a billing meter event</p>.
        /// </summary>
        public virtual Task<MeterEvent> CreateAsync(MeterEventCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterEvent>(HttpMethod.Post, $"/v1/billing/meter_events", options, requestOptions, cancellationToken);
        }
    }
}
