namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CustomerService : Service<Customer>,
        ICreatable<Customer, CustomerCreateOptions>,
        IDeletable<Customer, CustomerDeleteOptions>,
        IListable<Customer, CustomerListOptions>,
        IRetrievable<Customer, CustomerGetOptions>,
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

        public override string BasePath => "/v1/customers";

        public virtual CustomerBalanceTransactionList BalanceTransactions(string id, CustomerBalanceTransactionsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerBalanceTransactionList>(HttpMethod.Get, $"{this.InstanceUrl(id)}/balance_transactions", options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransactionList> BalanceTransactionsAsync(string id, CustomerBalanceTransactionsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerBalanceTransactionList>(HttpMethod.Get, $"{this.InstanceUrl(id)}/balance_transactions", options, requestOptions, cancellationToken);
        }

        public virtual Customer Create(CustomerCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Customer> CreateAsync(CustomerCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Customer Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

        public virtual Task<Customer> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual DeletedDiscount DeleteDiscount(string id, CustomerDeleteDiscountOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<DeletedDiscount>(HttpMethod.Delete, $"{this.InstanceUrl(id)}/discount", options, requestOptions);
        }

        public virtual Task<DeletedDiscount> DeleteDiscountAsync(string id, CustomerDeleteDiscountOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DeletedDiscount>(HttpMethod.Delete, $"{this.InstanceUrl(id)}/discount", options, requestOptions, cancellationToken);
        }

        public virtual Customer Get(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Customer> GetAsync(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Customer> List(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Customer>> ListAsync(CustomerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Customer> ListAutoPaging(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Customer Update(string id, CustomerUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Customer> UpdateAsync(string id, CustomerUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
