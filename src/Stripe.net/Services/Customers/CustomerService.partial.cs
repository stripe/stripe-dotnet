namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class CustomerService
    {
        /// <summary>
        /// <p>Retrieve funding instructions for a customer cash balance. If funding instructions do
        /// not yet exist for the customer, new funding instructions will be created. If funding
        /// instructions have already been created for a given customer, the same funding
        /// instructions will be retrieved. In other words, we will return the same funding
        /// instructions each time.</p>.
        /// </summary>
        [Obsolete("Use CustomerFundingInstructionsService.CreateAsync instead.")]
        public virtual FundingInstructions CreateFundingInstructions(string id, CustomerFundingInstructionsCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FundingInstructions>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{id}/funding_instructions", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve funding instructions for a customer cash balance. If funding instructions do
        /// not yet exist for the customer, new funding instructions will be created. If funding
        /// instructions have already been created for a given customer, the same funding
        /// instructions will be retrieved. In other words, we will return the same funding
        /// instructions each time.</p>.
        /// </summary>
        [Obsolete("Use CustomerFundingInstructionsService.CreateAsync instead.")]
        public virtual Task<FundingInstructions> CreateFundingInstructionsAsync(string id, CustomerFundingInstructionsCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingInstructions>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{id}/funding_instructions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        [Obsolete("Use CustomerPaymentMethodService.List instead.")]
        public virtual StripeList<PaymentMethod> ListPaymentMethods(string id, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethod>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{id}/payment_methods", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        [Obsolete("Use CustomerPaymentMethodService.ListAsync instead.")]
        public virtual Task<StripeList<PaymentMethod>> ListPaymentMethodsAsync(string id, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethod>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{id}/payment_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        [Obsolete("Use CustomerPaymentMethodService.ListAutoPaging instead.")]
        public virtual IEnumerable<PaymentMethod> ListPaymentMethodsAutoPaging(string id, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethod>($"/v1/customers/{id}/payment_methods", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for a given Customer</p>.
        /// </summary>
        [Obsolete("Use CustomerPaymentMethodService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<PaymentMethod> ListPaymentMethodsAutoPagingAsync(string id, CustomerPaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethod>($"/v1/customers/{id}/payment_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a PaymentMethod object for a given Customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerPaymentMethodService.Retrieve instead.")]
        public virtual PaymentMethod RetrievePaymentMethod(string parentId, string id, CustomerPaymentMethodGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/payment_methods/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a PaymentMethod object for a given Customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerPaymentMethodService.RetrieveAsync instead.")]
        public virtual Task<PaymentMethod> RetrievePaymentMethodAsync(string parentId, string id, CustomerPaymentMethodGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/payment_methods/{id}", options, requestOptions, cancellationToken);
        }
    }
}
