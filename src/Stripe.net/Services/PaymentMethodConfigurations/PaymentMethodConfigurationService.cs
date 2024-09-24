// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
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
        {
        }

        internal PaymentMethodConfigurationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentMethodConfigurationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a payment method configuration</p>.
        /// </summary>
        public virtual PaymentMethodConfiguration Create(PaymentMethodConfigurationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodConfiguration>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_configurations", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a payment method configuration</p>.
        /// </summary>
        public virtual Task<PaymentMethodConfiguration> CreateAsync(PaymentMethodConfigurationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodConfiguration>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_configurations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve payment method configuration</p>.
        /// </summary>
        public virtual PaymentMethodConfiguration Get(string id, PaymentMethodConfigurationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodConfiguration>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_configurations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve payment method configuration</p>.
        /// </summary>
        public virtual Task<PaymentMethodConfiguration> GetAsync(string id, PaymentMethodConfigurationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodConfiguration>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_configurations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List payment method configurations</p>.
        /// </summary>
        public virtual StripeList<PaymentMethodConfiguration> List(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethodConfiguration>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_configurations", options, requestOptions);
        }

        /// <summary>
        /// <p>List payment method configurations</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentMethodConfiguration>> ListAsync(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethodConfiguration>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_configurations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List payment method configurations</p>.
        /// </summary>
        public virtual IEnumerable<PaymentMethodConfiguration> ListAutoPaging(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethodConfiguration>($"/v1/payment_method_configurations", options, requestOptions);
        }

        /// <summary>
        /// <p>List payment method configurations</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentMethodConfiguration> ListAutoPagingAsync(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethodConfiguration>($"/v1/payment_method_configurations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Update payment method configuration</p>.
        /// </summary>
        public virtual PaymentMethodConfiguration Update(string id, PaymentMethodConfigurationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodConfiguration>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_configurations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Update payment method configuration</p>.
        /// </summary>
        public virtual Task<PaymentMethodConfiguration> UpdateAsync(string id, PaymentMethodConfigurationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodConfiguration>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_configurations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
