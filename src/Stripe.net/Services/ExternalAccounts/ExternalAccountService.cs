namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ExternalAccountService : ServiceNested<ExternalAccount>,
        INestedCreatable<ExternalAccount, ExternalAccountCreateOptions>,
        INestedDeletable<ExternalAccount>,
        INestedListable<ExternalAccount, ExternalAccountListOptions>,
        INestedRetrievable<ExternalAccount>,
        INestedUpdatable<ExternalAccount, ExternalAccountUpdateOptions>
    {
        public ExternalAccountService()
            : base(null)
        {
        }

        public ExternalAccountService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/accounts/{PARENT_ID}/external_accounts";

        public virtual ExternalAccount Create(string accountId, ExternalAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(accountId, options, requestOptions);
        }

        public virtual Task<ExternalAccount> CreateAsync(string accountId, ExternalAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual ExternalAccount Delete(string accountId, string externalAccountId, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(accountId, externalAccountId, null, requestOptions);
        }

        public virtual Task<ExternalAccount> DeleteAsync(string accountId, string externalAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteNestedEntityAsync(accountId, externalAccountId, null, requestOptions, cancellationToken);
        }

        public virtual ExternalAccount Get(string accountId, string externalAccountId, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(accountId, externalAccountId, null, requestOptions);
        }

        public virtual Task<ExternalAccount> GetAsync(string accountId, string externalAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(accountId, externalAccountId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<ExternalAccount> List(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(accountId, options, requestOptions);
        }

        public virtual Task<StripeList<ExternalAccount>> ListAsync(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual ExternalAccount Update(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(accountId, externalAccountId, options, requestOptions);
        }

        public virtual Task<ExternalAccount> UpdateAsync(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateNestedEntityAsync(accountId, externalAccountId, options, requestOptions, cancellationToken);
        }
    }
}
