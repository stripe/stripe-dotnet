// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountNoticeService : Service<AccountNotice>,
        IListable<AccountNotice, AccountNoticeListOptions>,
        IRetrievable<AccountNotice, AccountNoticeGetOptions>,
        IUpdatable<AccountNotice, AccountNoticeUpdateOptions>
    {
        public AccountNoticeService()
            : base(null)
        {
        }

        public AccountNoticeService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/account_notices";

        public virtual AccountNotice Get(string id, AccountNoticeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<AccountNotice> GetAsync(string id, AccountNoticeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<AccountNotice> List(AccountNoticeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<AccountNotice>> ListAsync(AccountNoticeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<AccountNotice> ListAutoPaging(AccountNoticeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<AccountNotice> ListAutoPagingAsync(AccountNoticeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual AccountNotice Update(string id, AccountNoticeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<AccountNotice> UpdateAsync(string id, AccountNoticeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
