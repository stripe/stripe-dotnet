namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CustomerService : Service<Customer>,
        ICreatable<Customer, CustomerCreateOptions>,
        IDeletable<Customer>,
        IListable<Customer, CustomerListOptions>,
        IRetrievable<Customer>,
        IUpdatable<Customer, CustomerUpdateOptions>
    {
        public CustomerService()
            : base(null)
        {
        }

        public CustomerService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandDefaultSource { get; set; }

        public bool ExpandDefaultCustomerBankAccount { get; set; }

        public virtual Customer Create(CustomerCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers", requestOptions, options);
        }

        public virtual Customer Delete(string customerId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/customers/{customerId}", requestOptions);
        }

        public virtual Customer Get(string customerId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/customers/{customerId}", requestOptions);
        }

        public virtual StripeList<Customer> List(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/customers", requestOptions, options);
        }

        public virtual Customer Update(string customerId, CustomerUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}", requestOptions, options);
        }

        public virtual Task<Customer> CreateAsync(CustomerCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers", requestOptions, cancellationToken, options);
        }

        public virtual Task<Customer> DeleteAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/customers/{customerId}", requestOptions, cancellationToken);
        }

        public virtual Task<Customer> GetAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/customers/{customerId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Customer>> ListAsync(CustomerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/customers", requestOptions, cancellationToken, options);
        }

        public virtual Task<Customer> UpdateAsync(string customerId, CustomerUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}", requestOptions, cancellationToken, options);
        }
    }
}
