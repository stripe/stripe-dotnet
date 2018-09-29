namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class BankAccountService : Service<BankAccount>,
        INestedCreatable<BankAccount, BankAccountCreateOptions>,
        INestedDeletable<BankAccount>,
        INestedListable<BankAccount, BankAccountListOptions>,
        INestedRetrievable<BankAccount>,
        INestedUpdatable<BankAccount, BankAccountUpdateOptions>
    {
        public BankAccountService()
            : base(null)
        {
        }

        public BankAccountService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public virtual BankAccount Create(string customerId, BankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, options);
        }

        public virtual BankAccount Delete(string customerId, string bankAccountId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions);
        }

        public virtual BankAccount Get(string customerId, string bankAccountId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions);
        }

        public virtual StripeList<BankAccount> List(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, options);
        }

        public virtual BankAccount Update(string customerId, string bankAccountId, BankAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, options);
        }

        public virtual BankAccount Verify(string customerId, string bankAccountId, BankAccountVerifyOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}/verify", requestOptions, options);
        }

        public virtual Task<BankAccount> CreateAsync(string customerId, BankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Task<BankAccount> DeleteAsync(string customerId, string bankAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, cancellationToken);
        }

        public virtual Task<BankAccount> GetAsync(string customerId, string bankAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<BankAccount>> ListAsync(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Task<BankAccount> UpdateAsync(string customerId, string bankAccountId, BankAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<BankAccount> VerifyAsync(string customerId, string bankAccountId, BankAccountVerifyOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources/{bankAccountId}/verify", requestOptions, cancellationToken, options);
        }
    }
}
