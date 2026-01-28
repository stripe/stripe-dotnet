// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AuthorizationService : Service,
        IRetrievable<Authorization, AuthorizationGetOptions>
    {
        public AuthorizationService()
        {
        }

        internal AuthorizationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AuthorizationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the details of an Financial Connections <c>Authorization</c>.</p>.
        /// </summary>
        public virtual Authorization Get(string id, AuthorizationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/authorizations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an Financial Connections <c>Authorization</c>.</p>.
        /// </summary>
        public virtual Task<Authorization> GetAsync(string id, AuthorizationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/authorizations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
