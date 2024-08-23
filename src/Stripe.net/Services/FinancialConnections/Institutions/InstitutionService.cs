// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InstitutionService : Service<Institution>,
        IListable<Institution, InstitutionListOptions>,
        IRetrievable<Institution, InstitutionGetOptions>
    {
        public InstitutionService()
        {
        }

        public InstitutionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/financial_connections/institutions";

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Institution</c>.</p>.
        /// </summary>
        public virtual Institution Get(string id, InstitutionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Institution>(HttpMethod.Get, $"/v1/financial_connections/institutions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Institution</c>.</p>.
        /// </summary>
        public virtual Task<Institution> GetAsync(string id, InstitutionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Institution>(HttpMethod.Get, $"/v1/financial_connections/institutions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Institution</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Institution> List(InstitutionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Institution>>(HttpMethod.Get, $"/v1/financial_connections/institutions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Institution</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Institution>> ListAsync(InstitutionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Institution>>(HttpMethod.Get, $"/v1/financial_connections/institutions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Institution</c> objects.</p>.
        /// </summary>
        public virtual IEnumerable<Institution> ListAutoPaging(InstitutionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Institution>($"/v1/financial_connections/institutions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Institution</c> objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Institution> ListAutoPagingAsync(InstitutionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Institution>($"/v1/financial_connections/institutions", options, requestOptions, cancellationToken);
        }
    }
}
