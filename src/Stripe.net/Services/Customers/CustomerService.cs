// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerService : Service<Customer>,
        ICreatable<Customer, CustomerCreateOptions>,
        IDeletable<Customer, CustomerDeleteOptions>,
        IListable<Customer, CustomerListOptions>,
        IRetrievable<Customer, CustomerGetOptions>,
        ISearchable<Customer, CustomerSearchOptions>,
        IUpdatable<Customer, CustomerUpdateOptions>
    {
        public CustomerService()
            : base(null)
        {
        }

        public CustomerService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/customers";

        public virtual Customer Create(CustomerCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(HttpMethod.Post, $"/v1/customers", options, requestOptions);
        }

        public virtual Task<Customer> CreateAsync(CustomerCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(HttpMethod.Post, $"/v1/customers", options, requestOptions, cancellationToken);
        }

        public virtual FundingInstructions CreateFundingInstructions(string id, CustomerCreateFundingInstructionsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FundingInstructions>(HttpMethod.Post, $"/v1/customers/{id}/funding_instructions", options, requestOptions);
        }

        public virtual Task<FundingInstructions> CreateFundingInstructionsAsync(string id, CustomerCreateFundingInstructionsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingInstructions>(HttpMethod.Post, $"/v1/customers/{id}/funding_instructions", options, requestOptions, cancellationToken);
        }

        public virtual Customer Delete(string id, CustomerDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(HttpMethod.Delete, $"/v1/customers/{id}", options, requestOptions);
        }

        public virtual Task<Customer> DeleteAsync(string id, CustomerDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(HttpMethod.Delete, $"/v1/customers/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Customer Get(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(HttpMethod.Get, $"/v1/customers/{id}", options, requestOptions);
        }

        public virtual Task<Customer> GetAsync(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(HttpMethod.Get, $"/v1/customers/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Customer> List(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Customer>>(HttpMethod.Get, $"/v1/customers", options, requestOptions);
        }

        public virtual Task<StripeList<Customer>> ListAsync(CustomerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Customer>>(HttpMethod.Get, $"/v1/customers", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Customer> ListAutoPaging(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Customer>($"/v1/customers", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Customer> ListAutoPagingAsync(CustomerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Customer>($"/v1/customers", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentMethod> ListPaymentMethods(string id, CustomerListPaymentMethodsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethod>>(HttpMethod.Get, $"/v1/customers/{id}/payment_methods", options, requestOptions);
        }

        public virtual Task<StripeList<PaymentMethod>> ListPaymentMethodsAsync(string id, CustomerListPaymentMethodsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethod>>(HttpMethod.Get, $"/v1/customers/{id}/payment_methods", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentMethod> ListPaymentMethodsAutoPaging(string id, CustomerListPaymentMethodsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethod>($"/v1/customers/{id}/payment_methods", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PaymentMethod> ListPaymentMethodsAutoPagingAsync(string id, CustomerListPaymentMethodsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethod>($"/v1/customers/{id}/payment_methods", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethod RetrievePaymentMethod(string parentId, string id, CustomerRetrievePaymentMethodOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(HttpMethod.Get, $"/v1/customers/{parentId}/payment_methods/{id}", options, requestOptions);
        }

        public virtual Task<PaymentMethod> RetrievePaymentMethodAsync(string parentId, string id, CustomerRetrievePaymentMethodOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(HttpMethod.Get, $"/v1/customers/{parentId}/payment_methods/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeSearchResult<Customer> Search(CustomerSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Customer>>(HttpMethod.Get, $"/v1/customers/search", options, requestOptions);
        }

        public virtual Task<StripeSearchResult<Customer>> SearchAsync(CustomerSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Customer>>(HttpMethod.Get, $"/v1/customers/search", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Customer> SearchAutoPaging(CustomerSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Customer>($"/v1/customers/search", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Customer> SearchAutoPagingAsync(CustomerSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Customer>($"/v1/customers/search", options, requestOptions, cancellationToken);
        }

        public virtual Customer Update(string id, CustomerUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(HttpMethod.Post, $"/v1/customers/{id}", options, requestOptions);
        }

        public virtual Task<Customer> UpdateAsync(string id, CustomerUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(HttpMethod.Post, $"/v1/customers/{id}", options, requestOptions, cancellationToken);
        }
    }
}
