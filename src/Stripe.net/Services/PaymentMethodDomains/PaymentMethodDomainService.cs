// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodDomainService : Service,
        ICreatable<PaymentMethodDomain, PaymentMethodDomainCreateOptions>,
        IListable<PaymentMethodDomain, PaymentMethodDomainListOptions>,
        IRetrievable<PaymentMethodDomain, PaymentMethodDomainGetOptions>,
        IUpdatable<PaymentMethodDomain, PaymentMethodDomainUpdateOptions>
    {
        public PaymentMethodDomainService()
        {
        }

        internal PaymentMethodDomainService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentMethodDomainService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a payment method domain.</p>.
        /// </summary>
        public virtual PaymentMethodDomain Create(PaymentMethodDomainCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_domains", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a payment method domain.</p>.
        /// </summary>
        public virtual Task<PaymentMethodDomain> CreateAsync(PaymentMethodDomainCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_domains", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing payment method domain.</p>.
        /// </summary>
        public virtual PaymentMethodDomain Get(string id, PaymentMethodDomainGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_domains/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing payment method domain.</p>.
        /// </summary>
        public virtual Task<PaymentMethodDomain> GetAsync(string id, PaymentMethodDomainGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_domains/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists the details of existing payment method domains.</p>.
        /// </summary>
        public virtual StripeList<PaymentMethodDomain> List(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethodDomain>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_domains", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the details of existing payment method domains.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentMethodDomain>> ListAsync(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethodDomain>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_method_domains", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists the details of existing payment method domains.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentMethodDomain> ListAutoPaging(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethodDomain>($"/v1/payment_method_domains", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the details of existing payment method domains.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentMethodDomain> ListAutoPagingAsync(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethodDomain>($"/v1/payment_method_domains", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing payment method domain.</p>.
        /// </summary>
        public virtual PaymentMethodDomain Update(string id, PaymentMethodDomainUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_domains/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing payment method domain.</p>.
        /// </summary>
        public virtual Task<PaymentMethodDomain> UpdateAsync(string id, PaymentMethodDomainUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_domains/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Some payment methods such as Apple Pay require additional steps to verify a domain.
        /// If the requirements weren’t satisfied when the domain was created, the payment method
        /// will be inactive on the domain. The payment method doesn’t appear in Elements for this
        /// domain until it is active.</p>.
        ///
        /// <p>To activate a payment method on an existing payment method domain, complete the
        /// required validation steps specific to the payment method, and then validate the payment
        /// method domain with this endpoint.</p>.
        ///
        /// <p>Related guides: <a
        /// href="https://stripe.com/docs/payments/payment-methods/pmd-registration">Payment method
        /// domains</a>.</p>.
        /// </summary>
        public virtual PaymentMethodDomain Validate(string id, PaymentMethodDomainValidateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_domains/{WebUtility.UrlEncode(id)}/validate", options, requestOptions);
        }

        /// <summary>
        /// <p>Some payment methods such as Apple Pay require additional steps to verify a domain.
        /// If the requirements weren’t satisfied when the domain was created, the payment method
        /// will be inactive on the domain. The payment method doesn’t appear in Elements for this
        /// domain until it is active.</p>.
        ///
        /// <p>To activate a payment method on an existing payment method domain, complete the
        /// required validation steps specific to the payment method, and then validate the payment
        /// method domain with this endpoint.</p>.
        ///
        /// <p>Related guides: <a
        /// href="https://stripe.com/docs/payments/payment-methods/pmd-registration">Payment method
        /// domains</a>.</p>.
        /// </summary>
        public virtual Task<PaymentMethodDomain> ValidateAsync(string id, PaymentMethodDomainValidateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_method_domains/{WebUtility.UrlEncode(id)}/validate", options, requestOptions, cancellationToken);
        }
    }
}
