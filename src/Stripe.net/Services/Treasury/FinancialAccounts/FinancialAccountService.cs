// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
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
            : base(null)
        {
        }

        public FinancialAccountService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/financial_accounts";

        public virtual FinancialAccount Create(FinancialAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts", options, requestOptions);
        }

        public virtual Task<FinancialAccount> CreateAsync(FinancialAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
        }

        public virtual FinancialAccount Get(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}", options, requestOptions);
        }

        public virtual Task<FinancialAccount> GetAsync(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<FinancialAccount> List(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FinancialAccount>>(HttpMethod.Get, $"/v1/treasury/financial_accounts", options, requestOptions);
        }

        public virtual Task<StripeList<FinancialAccount>> ListAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FinancialAccount>>(HttpMethod.Get, $"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<FinancialAccount> ListAutoPaging(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FinancialAccount>($"/v1/treasury/financial_accounts", options, requestOptions);
        }

        public virtual IAsyncEnumerable<FinancialAccount> ListAutoPagingAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FinancialAccount>($"/v1/treasury/financial_accounts", options, requestOptions, cancellationToken);
        }

        public virtual FinancialAccountFeatures RetrieveFeatures(string id, FinancialAccountRetrieveFeaturesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions);
        }

        public virtual Task<FinancialAccountFeatures> RetrieveFeaturesAsync(string id, FinancialAccountRetrieveFeaturesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions, cancellationToken);
        }

        public virtual FinancialAccount Update(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}", options, requestOptions);
        }

        public virtual Task<FinancialAccount> UpdateAsync(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual FinancialAccountFeatures UpdateFeatures(string id, FinancialAccountUpdateFeaturesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions);
        }

        public virtual Task<FinancialAccountFeatures> UpdateFeaturesAsync(string id, FinancialAccountUpdateFeaturesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions, cancellationToken);
        }
    }
}
