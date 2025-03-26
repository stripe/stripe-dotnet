// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerPaymentMethodService : Service,
        INestedListable<PaymentMethod, CustomerPaymentMethodListOptions>,
        INestedRetrievable<PaymentMethod, CustomerPaymentMethodGetOptions>
    {
        public CustomerPaymentMethodService()
        {
        }

        internal CustomerPaymentMethodService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerPaymentMethodService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a PaymentMethod object for a given Customer.</p>.
        /// </summary>
        public virtual PaymentMethod Get(string parentId, string id, CustomerPaymentMethodGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/payment_methods/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a PaymentMethod object for a given Customer.</p>.
        /// </summary>
        public virtual Task<PaymentMethod> GetAsync(string parentId, string id, CustomerPaymentMethodGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/payment_methods/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        public virtual StripeList<PaymentMethod> List(string parentId, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethod>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/payment_methods", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentMethod>> ListAsync(string parentId, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethod>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/payment_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        public virtual IEnumerable<PaymentMethod> ListAutoPaging(string parentId, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethod>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/payment_methods", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentMethod> ListAutoPagingAsync(string parentId, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethod>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/payment_methods", options, requestOptions, cancellationToken);
        }
    }
}
