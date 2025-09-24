// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ServiceActionService : Service
    {
        internal ServiceActionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ServiceActionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a Service Action object.
        /// </summary>
        public virtual ServiceAction Create(ServiceActionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ServiceAction>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/service_actions", options, requestOptions);
        }

        /// <summary>
        /// Create a Service Action object.
        /// </summary>
        public virtual Task<ServiceAction> CreateAsync(ServiceActionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ServiceAction>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/service_actions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Service Action object.
        /// </summary>
        public virtual ServiceAction Get(string id, ServiceActionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ServiceAction>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/service_actions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Service Action object.
        /// </summary>
        public virtual Task<ServiceAction> GetAsync(string id, ServiceActionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ServiceAction>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/service_actions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a ServiceAction object.
        /// </summary>
        public virtual ServiceAction Update(string id, ServiceActionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ServiceAction>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/service_actions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a ServiceAction object.
        /// </summary>
        public virtual Task<ServiceAction> UpdateAsync(string id, ServiceActionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ServiceAction>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/service_actions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
