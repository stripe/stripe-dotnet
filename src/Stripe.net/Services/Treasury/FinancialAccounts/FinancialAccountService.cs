// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancialAccountService : Service<FinancialAccount>,
        ICreatable<FinancialAccount, FinancialAccountCreateOptions>,
        IListable<FinancialAccount, FinancialAccountListOptions>,
        IRetrievable<FinancialAccount, FinancialAccountGetOptions>,
        IUpdatable<FinancialAccount, FinancialAccountUpdateOptions>
    {
        public FinancialAccountService()
        {
        }

        public FinancialAccountService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/financial_accounts";

        /// <summary>
        /// <p>Creates a new FinancialAccount. For now, each connected account can only have one
        /// FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccount Create(FinancialAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new FinancialAccount. For now, each connected account can only have one
        /// FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccount> CreateAsync(FinancialAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccount Get(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccount> GetAsync(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of FinancialAccounts.</p>.
        /// </summary>
        public virtual StripeList<FinancialAccount> List(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FinancialAccount>>(HttpMethod.Get, $"/v1/treasury/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of FinancialAccounts.</p>.
        /// </summary>
        public virtual Task<StripeList<FinancialAccount>> ListAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FinancialAccount>>(HttpMethod.Get, $"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
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
        /// <p>Retrieves Features information associated with the FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccountFeatures RetrieveFeatures(string id, FinancialAccountRetrieveFeaturesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves Features information associated with the FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccountFeatures> RetrieveFeaturesAsync(string id, FinancialAccountRetrieveFeaturesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccount Update(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the details of a FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccount> UpdateAsync(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the Features associated with a FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccountFeatures UpdateFeatures(string id, FinancialAccountUpdateFeaturesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the Features associated with a FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccountFeatures> UpdateFeaturesAsync(string id, FinancialAccountUpdateFeaturesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions, cancellationToken);
        }
    }
}
