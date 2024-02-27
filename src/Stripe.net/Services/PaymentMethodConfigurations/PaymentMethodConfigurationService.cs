// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodConfigurationService : Service<PaymentMethodConfiguration>,
        ICreatable<PaymentMethodConfiguration, PaymentMethodConfigurationCreateOptions>,
        IListable<PaymentMethodConfiguration, PaymentMethodConfigurationListOptions>,
        IRetrievable<PaymentMethodConfiguration, PaymentMethodConfigurationGetOptions>,
        IUpdatable<PaymentMethodConfiguration, PaymentMethodConfigurationUpdateOptions>
    {
        public PaymentMethodConfigurationService()
            : base(null)
        {
        }

        public PaymentMethodConfigurationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/payment_method_configurations";

        public virtual PaymentMethodConfiguration Create(PaymentMethodConfigurationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodConfiguration>(HttpMethod.Post, $"/v1/payment_method_configurations", options, requestOptions);
        }

        public virtual Task<PaymentMethodConfiguration> CreateAsync(PaymentMethodConfigurationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodConfiguration>(HttpMethod.Post, $"/v1/payment_method_configurations", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethodConfiguration Get(string id, PaymentMethodConfigurationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodConfiguration>(HttpMethod.Get, $"/v1/payment_method_configurations/{id}", options, requestOptions);
        }

        public virtual Task<PaymentMethodConfiguration> GetAsync(string id, PaymentMethodConfigurationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodConfiguration>(HttpMethod.Get, $"/v1/payment_method_configurations/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentMethodConfiguration> List(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethodConfiguration>>(HttpMethod.Get, $"/v1/payment_method_configurations", options, requestOptions);
        }

        public virtual Task<StripeList<PaymentMethodConfiguration>> ListAsync(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethodConfiguration>>(HttpMethod.Get, $"/v1/payment_method_configurations", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentMethodConfiguration> ListAutoPaging(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethodConfiguration>($"/v1/payment_method_configurations", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PaymentMethodConfiguration> ListAutoPagingAsync(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethodConfiguration>($"/v1/payment_method_configurations", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethodConfiguration Update(string id, PaymentMethodConfigurationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodConfiguration>(HttpMethod.Post, $"/v1/payment_method_configurations/{id}", options, requestOptions);
        }

        public virtual Task<PaymentMethodConfiguration> UpdateAsync(string id, PaymentMethodConfigurationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodConfiguration>(HttpMethod.Post, $"/v1/payment_method_configurations/{id}", options, requestOptions, cancellationToken);
        }
    }
}
