// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/account_notices";

        /// <summary>
        /// <p>Retrieves an <c>AccountNotice</c> object.</p>.
        /// </summary>
        public virtual AccountNotice Get(string id, AccountNoticeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AccountNotice>(HttpMethod.Get, $"/v1/account_notices/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an <c>AccountNotice</c> object.</p>.
        /// </summary>
        public virtual Task<AccountNotice> GetAsync(string id, AccountNoticeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountNotice>(HttpMethod.Get, $"/v1/account_notices/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>AccountNotice</c> objects. The objects are sorted in
        /// descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<AccountNotice> List(AccountNoticeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountNotice>>(HttpMethod.Get, $"/v1/account_notices", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>AccountNotice</c> objects. The objects are sorted in
        /// descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<AccountNotice>> ListAsync(AccountNoticeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountNotice>>(HttpMethod.Get, $"/v1/account_notices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>AccountNotice</c> objects. The objects are sorted in
        /// descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<AccountNotice> ListAutoPaging(AccountNoticeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountNotice>($"/v1/account_notices", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>AccountNotice</c> objects. The objects are sorted in
        /// descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<AccountNotice> ListAutoPagingAsync(AccountNoticeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountNotice>($"/v1/account_notices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an <c>AccountNotice</c> object.</p>.
        /// </summary>
        public virtual AccountNotice Update(string id, AccountNoticeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountNotice>(HttpMethod.Post, $"/v1/account_notices/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an <c>AccountNotice</c> object.</p>.
        /// </summary>
        public virtual Task<AccountNotice> UpdateAsync(string id, AccountNoticeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountNotice>(HttpMethod.Post, $"/v1/account_notices/{id}", options, requestOptions, cancellationToken);
        }
    }
}
