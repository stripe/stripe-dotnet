// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FormService : Service
    {
        internal FormService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FormService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves a risk Form by ID.
        /// </summary>
        public virtual Form Get(string id, FormGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Form>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a risk Form by ID.
        /// </summary>
        public virtual Task<Form> GetAsync(string id, FormGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Form>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Submits a response to a risk Form.
        /// </summary>
        public virtual Form Update(string id, FormUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Form>(BaseAddress.Api, HttpMethod.Post, $"/v2/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Submits a response to a risk Form.
        /// </summary>
        public virtual Task<Form> UpdateAsync(string id, FormUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Form>(BaseAddress.Api, HttpMethod.Post, $"/v2/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
