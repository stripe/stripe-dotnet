// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EarlyFraudWarningService : Service<EarlyFraudWarning>,
        IListable<EarlyFraudWarning, EarlyFraudWarningListOptions>,
        IRetrievable<EarlyFraudWarning, EarlyFraudWarningGetOptions>
    {
        public EarlyFraudWarningService()
            : base(null)
        {
        }

        public EarlyFraudWarningService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/radar/early_fraud_warnings";

        public virtual EarlyFraudWarning Get(string id, EarlyFraudWarningGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<EarlyFraudWarning>(HttpMethod.Get, $"/v1/radar/early_fraud_warnings/{id}", options, requestOptions);
        }

        public virtual Task<EarlyFraudWarning> GetAsync(string id, EarlyFraudWarningGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<EarlyFraudWarning>(HttpMethod.Get, $"/v1/radar/early_fraud_warnings/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<EarlyFraudWarning> List(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<EarlyFraudWarning>>(HttpMethod.Get, $"/v1/radar/early_fraud_warnings", options, requestOptions);
        }

        public virtual Task<StripeList<EarlyFraudWarning>> ListAsync(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<EarlyFraudWarning>>(HttpMethod.Get, $"/v1/radar/early_fraud_warnings", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<EarlyFraudWarning> ListAutoPaging(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<EarlyFraudWarning>($"/v1/radar/early_fraud_warnings", options, requestOptions);
        }

        public virtual IAsyncEnumerable<EarlyFraudWarning> ListAutoPagingAsync(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<EarlyFraudWarning>($"/v1/radar/early_fraud_warnings", options, requestOptions, cancellationToken);
        }
    }
}
