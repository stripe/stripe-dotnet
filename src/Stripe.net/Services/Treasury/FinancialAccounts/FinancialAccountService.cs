// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class FinancialAccountService : Service,
        ICreatable<FinancialAccount, FinancialAccountCreateOptions>,
        IListable<FinancialAccount, FinancialAccountListOptions>,
        IRetrievable<FinancialAccount, FinancialAccountGetOptions>,
        IUpdatable<FinancialAccount, FinancialAccountUpdateOptions>
    {
        private FinancialAccountFeaturesService features;

        public FinancialAccountService()
        {
        }

        internal FinancialAccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FinancialAccountService(IStripeClient client)
            : base(client)
        {
        }

        public virtual FinancialAccountFeaturesService Features => this.features ??= new FinancialAccountFeaturesService(
            this.Requestor);

        /// <summary>
        /// <p>Closes a FinancialAccount. A FinancialAccount can only be closed if it has a zero
        /// balance, has no pending InboundTransfers, and has canceled all attached Issuing
        /// cards.</p>.
        /// </summary>
        public virtual FinancialAccount Close(string id, FinancialAccountCloseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(id)}/close", options, requestOptions);
        }

        /// <summary>
        /// <p>Closes a FinancialAccount. A FinancialAccount can only be closed if it has a zero
        /// balance, has no pending InboundTransfers, and has canceled all attached Issuing
        /// cards.</p>.
        /// </summary>
        public virtual Task<FinancialAccount> CloseAsync(string id, FinancialAccountCloseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(id)}/close", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a new FinancialAccount. Each connected account can have up to three
        /// FinancialAccounts by default.</p>.
        /// </summary>
        public virtual FinancialAccount Create(FinancialAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new FinancialAccount. Each connected account can have up to three
        /// FinancialAccounts by default.</p>.
        /// </summary>
        public virtual Task<FinancialAccount> CreateAsync(FinancialAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccount Get(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccount> GetAsync(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of FinancialAccounts.</p>.
        /// </summary>
        public virtual StripeList<FinancialAccount> List(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FinancialAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of FinancialAccounts.</p>.
        /// </summary>
        public virtual Task<StripeList<FinancialAccount>> ListAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FinancialAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of FinancialAccounts.</p>.
        /// </summary>
        public virtual IEnumerable<FinancialAccount> ListAutoPaging(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FinancialAccount>($"/v1/treasury/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of FinancialAccounts.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<FinancialAccount> ListAutoPagingAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FinancialAccount>($"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccount Update(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccount> UpdateAsync(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
