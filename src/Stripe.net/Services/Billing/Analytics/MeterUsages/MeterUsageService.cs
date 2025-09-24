// File generated from our OpenAPI spec
namespace Stripe.Billing.Analytics
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterUsageService : Service, ISingletonRetrievable<MeterUsage>
    {
        public MeterUsageService()
        {
        }

        internal MeterUsageService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public MeterUsageService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Returns aggregated meter usage data for a customer within a specified time interval.
        /// The data can be grouped by various dimensions and can include multiple meters if
        /// specified.</p>.
        /// </summary>
        public virtual MeterUsage Get(RequestOptions requestOptions = null)
        {
            return this.Request<MeterUsage>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/analytics/meter_usage", null, requestOptions);
        }

        /// <summary>
        /// <p>Returns aggregated meter usage data for a customer within a specified time interval.
        /// The data can be grouped by various dimensions and can include multiple meters if
        /// specified.</p>.
        /// </summary>
        public virtual Task<MeterUsage> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterUsage>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/analytics/meter_usage", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns aggregated meter usage data for a customer within a specified time interval.
        /// The data can be grouped by various dimensions and can include multiple meters if
        /// specified.</p>.
        /// </summary>
        public virtual MeterUsage Get(MeterUsageGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeterUsage>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/analytics/meter_usage", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns aggregated meter usage data for a customer within a specified time interval.
        /// The data can be grouped by various dimensions and can include multiple meters if
        /// specified.</p>.
        /// </summary>
        public virtual Task<MeterUsage> GetAsync(MeterUsageGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeterUsage>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/analytics/meter_usage", options, requestOptions, cancellationToken);
        }
    }
}
