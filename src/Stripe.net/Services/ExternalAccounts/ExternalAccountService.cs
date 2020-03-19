namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ExternalAccountService : ServiceNested<IExternalAccount>,
        INestedCreatable<IExternalAccount, ExternalAccountCreateOptions>,
        INestedDeletable<IExternalAccount, ExternalAccountDeleteOptions>,
        INestedListable<IExternalAccount, ExternalAccountListOptions>,
        INestedRetrievable<IExternalAccount, ExternalAccountGetOptions>,
        INestedUpdatable<IExternalAccount, ExternalAccountUpdateOptions>
    {
        public ExternalAccountService()
            : base(null)
        {
        }

        public ExternalAccountService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/external_accounts";

        public virtual IExternalAccount Create(string accountId, ExternalAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(accountId, options, requestOptions);
        }

        public virtual Task<IExternalAccount> CreateAsync(string accountId, ExternalAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IExternalAccount Delete(string accountId, string externalAccountId, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(accountId, externalAccountId, options, requestOptions);
        }

        public virtual Task<IExternalAccount> DeleteAsync(string accountId, string externalAccountId, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteNestedEntityAsync(accountId, externalAccountId, options, requestOptions, cancellationToken);
        }

        public virtual IExternalAccount Get(string accountId, string externalAccountId, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(accountId, externalAccountId, options, requestOptions);
        }

        public virtual Task<IExternalAccount> GetAsync(string accountId, string externalAccountId, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(accountId, externalAccountId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<IExternalAccount> List(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(accountId, options, requestOptions);
        }

        public virtual Task<StripeList<IExternalAccount>> ListAsync(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<IExternalAccount> ListAutoPaging(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(accountId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<IExternalAccount> ListAutoPagingAsync(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(accountId, options, requestOptions, cancellationToken);
        }
#endif

        public virtual IExternalAccount Update(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(accountId, externalAccountId, options, requestOptions);
        }

        public virtual Task<IExternalAccount> UpdateAsync(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(accountId, externalAccountId, options, requestOptions, cancellationToken);
        }
    }
}
