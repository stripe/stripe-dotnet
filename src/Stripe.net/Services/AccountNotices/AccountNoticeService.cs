// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
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
            return this.Request<AccountNotice>(HttpMethod.Get, $"/v1/account_notices/{id}", options, requestOptions);
        }

        public virtual Task<AccountNotice> GetAsync(string id, AccountNoticeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountNotice>(HttpMethod.Get, $"/v1/account_notices/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<AccountNotice> List(AccountNoticeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountNotice>>(HttpMethod.Get, $"/v1/account_notices", options, requestOptions);
        }

        public virtual Task<StripeList<AccountNotice>> ListAsync(AccountNoticeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountNotice>>(HttpMethod.Get, $"/v1/account_notices", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<AccountNotice> ListAutoPaging(AccountNoticeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountNotice>($"/v1/account_notices", options, requestOptions);
        }

        public virtual IAsyncEnumerable<AccountNotice> ListAutoPagingAsync(AccountNoticeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountNotice>($"/v1/account_notices", options, requestOptions, cancellationToken);
        }

        public virtual AccountNotice Update(string id, AccountNoticeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountNotice>(HttpMethod.Post, $"/v1/account_notices/{id}", options, requestOptions);
        }

        public virtual Task<AccountNotice> UpdateAsync(string id, AccountNoticeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountNotice>(HttpMethod.Post, $"/v1/account_notices/{id}", options, requestOptions, cancellationToken);
        }
    }
}
