// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConsentService : Service,
        ICreatable<Consent, ConsentCreateOptions>,
        IRetrievable<Consent, ConsentGetOptions>
    {
        public ConsentService()
        {
        }

        internal ConsentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ConsentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a Financial Connections <c>Consent</c> object for an account holder.</p>.
        /// </summary>
        public virtual Consent Create(ConsentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Consent>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/consents", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a Financial Connections <c>Consent</c> object for an account holder.</p>.
        /// </summary>
        public virtual Task<Consent> CreateAsync(ConsentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Consent>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/consents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Consent</c>.</p>.
        /// </summary>
        public virtual Consent Get(string id, ConsentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Consent>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/consents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Consent</c>.</p>.
        /// </summary>
        public virtual Task<Consent> GetAsync(string id, ConsentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Consent>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/consents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
