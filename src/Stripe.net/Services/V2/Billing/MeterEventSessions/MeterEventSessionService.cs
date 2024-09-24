// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterEventSessionService : Service
    {
        internal MeterEventSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MeterEventSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a meter event session to send usage on the high-throughput meter event stream.
        /// </summary>
        public virtual MeterEventSession Create(MeterEventSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeterEventSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_event_session", options, requestOptions);
        }

        /// <summary>
        /// Creates a meter event session to send usage on the high-throughput meter event stream.
        /// </summary>
        public virtual Task<MeterEventSession> CreateAsync(MeterEventSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterEventSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/meter_event_session", options, requestOptions, cancellationToken);
        }
    }
}
