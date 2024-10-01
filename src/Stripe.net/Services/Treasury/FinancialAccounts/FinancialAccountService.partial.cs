namespace Stripe.Treasury
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class FinancialAccountService
    {
        /// <summary>
        /// <p>Retrieves Features information associated with the FinancialAccount.</p>.
        /// </summary>
        [Obsolete("Use FinancialAccountFeaturesService.Get instead.")]
        public virtual FinancialAccountFeatures RetrieveFeatures(string id, FinancialAccountFeaturesGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves Features information associated with the FinancialAccount.</p>.
        /// </summary>
        [Obsolete("Use FinancialAccountFeaturesService.GetAsync instead.")]
        public virtual Task<FinancialAccountFeatures> RetrieveFeaturesAsync(string id, FinancialAccountFeaturesGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the Features associated with a FinancialAccount.</p>.
        /// </summary>
        [Obsolete("Use FinancialAccountFeaturesService.Update instead.")]
        public virtual FinancialAccountFeatures UpdateFeatures(string id, FinancialAccountFeaturesUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the Features associated with a FinancialAccount.</p>.
        /// </summary>
        [Obsolete("Use FinancialAccountFeaturesService.UpdateAsync instead.")]
        public virtual Task<FinancialAccountFeatures> UpdateFeaturesAsync(string id, FinancialAccountFeaturesUpdateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{id}/features", options, requestOptions, cancellationToken);
        }
    }
}
