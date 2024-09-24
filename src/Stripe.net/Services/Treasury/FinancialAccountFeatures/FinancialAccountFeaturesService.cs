// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancialAccountFeaturesService : ServiceNested<FinancialAccountFeatures>
    {
        public FinancialAccountFeaturesService()
        {
        }

        internal FinancialAccountFeaturesService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FinancialAccountFeaturesService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves Features information associated with the FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccountFeatures Get(string parentId, FinancialAccountFeaturesGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves Features information associated with the FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccountFeatures> GetAsync(string parentId, FinancialAccountFeaturesGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the Features associated with a FinancialAccount.</p>.
        /// </summary>
        public virtual FinancialAccountFeatures Update(string parentId, FinancialAccountFeaturesUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the Features associated with a FinancialAccount.</p>.
        /// </summary>
        public virtual Task<FinancialAccountFeatures> UpdateAsync(string parentId, FinancialAccountFeaturesUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccountFeatures>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/financial_accounts/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions, cancellationToken);
        }
    }
}
