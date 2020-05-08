namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class AccountService : Service<Account>,
        ICreatable<Account, AccountCreateOptions>,
        IDeletable<Account, AccountDeleteOptions>,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account, AccountGetOptions>,
        IUpdatable<Account, AccountUpdateOptions>
    {
        public AccountService()
            : base(null)
        {
        }

        public AccountService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts";

        public virtual ListAccountCapability Capabilities(string id, AccountCapabilitiesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ListAccountCapability>(HttpMethod.Get, $"{this.InstanceUrl(id)}/capabilities", options, requestOptions);
        }

        public virtual Task<ListAccountCapability> CapabilitiesAsync(string id, AccountCapabilitiesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ListAccountCapability>(HttpMethod.Get, $"{this.InstanceUrl(id)}/capabilities", options, requestOptions, cancellationToken);
        }

        public virtual Account Create(AccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Account Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

        public virtual Task<Account> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual unknown Persons(string id, AccountPersonsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<unknown>(HttpMethod.Get, $"{this.InstanceUrl(id)}/persons", options, requestOptions);
        }

        public virtual Task<unknown> PersonsAsync(string id, AccountPersonsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<unknown>(HttpMethod.Get, $"{this.InstanceUrl(id)}/persons", options, requestOptions, cancellationToken);
        }

        public virtual Account Reject(string id, AccountRejectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/reject", options, requestOptions);
        }

        public virtual Task<Account> RejectAsync(string id, AccountRejectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/reject", options, requestOptions, cancellationToken);
        }

        public virtual Account Update(string id, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Account> UpdateAsync(string id, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
