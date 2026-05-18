// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentLocationCapabilityService : Service,
        IRetrievable<PaymentLocationCapability, PaymentLocationCapabilityGetOptions>,
        IUpdatable<PaymentLocationCapability, PaymentLocationCapabilityUpdateOptions>
    {
        public PaymentLocationCapabilityService()
        {
        }

        internal PaymentLocationCapabilityService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentLocationCapabilityService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves information about the specified Payment Location Capability.</p>.
        /// </summary>
        public virtual PaymentLocationCapability Get(string id, PaymentLocationCapabilityGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLocationCapability>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_location_capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves information about the specified Payment Location Capability.</p>.
        /// </summary>
        public virtual Task<PaymentLocationCapability> GetAsync(string id, PaymentLocationCapabilityGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLocationCapability>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_location_capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>PaymentLocationCapability</c> objects associated with the
        /// location.</p>.
        /// </summary>
        public virtual StripeList<PaymentLocationCapability> List(PaymentLocationCapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentLocationCapability>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_location_capabilities", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>PaymentLocationCapability</c> objects associated with the
        /// location.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentLocationCapability>> ListAsync(PaymentLocationCapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentLocationCapability>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_location_capabilities", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a specified Payment Location Capability. Request or remove a payment location
        /// capability by updating its <c>requested</c> parameter.</p>.
        /// </summary>
        public virtual PaymentLocationCapability Update(string id, PaymentLocationCapabilityUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLocationCapability>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_location_capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a specified Payment Location Capability. Request or remove a payment location
        /// capability by updating its <c>requested</c> parameter.</p>.
        /// </summary>
        public virtual Task<PaymentLocationCapability> UpdateAsync(string id, PaymentLocationCapabilityUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLocationCapability>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_location_capabilities/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
