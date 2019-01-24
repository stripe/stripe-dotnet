namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ExternalAccountService : ServiceNested<IExternalAccount>,
        INestedCreatable<IExternalAccount, ExternalAccountCreateOptions>,
        INestedDeletable<IExternalAccount>,
        INestedListable<IExternalAccount, ExternalAccountListOptions>,
        INestedRetrievable<IExternalAccount>,
        INestedUpdatable<IExternalAccount, ExternalAccountUpdateOptions>
    {
        public ExternalAccountService()
            : base(null)
        {
        }

        public ExternalAccountService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/external_accounts";

        public virtual IExternalAccount Create(string accountId, ExternalAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(accountId, options, requestOptions);
        }

        public virtual Task<IExternalAccount> CreateAsync(string accountId, ExternalAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IExternalAccount Delete(string accountId, string externalAccountId, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(accountId, externalAccountId, null, requestOptions);
        }

        public virtual Task<IExternalAccount> DeleteAsync(string accountId, string externalAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteNestedEntityAsync(accountId, externalAccountId, null, requestOptions, cancellationToken);
        }

        public virtual IExternalAccount Get(string accountId, string externalAccountId, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(accountId, externalAccountId, null, requestOptions);
        }

        public virtual Task<IExternalAccount> GetAsync(string accountId, string externalAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(accountId, externalAccountId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<IExternalAccount> List(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(accountId, options, requestOptions);
        }

        public virtual Task<StripeList<IExternalAccount>> ListAsync(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<IExternalAccount> ListAutoPaging(string accountId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(accountId, options, requestOptions);
        }

        public virtual IExternalAccount Update(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(accountId, externalAccountId, options, requestOptions);
        }

        public virtual Task<IExternalAccount> UpdateAsync(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateNestedEntityAsync(accountId, externalAccountId, options, requestOptions, cancellationToken);
        }
    }
}
