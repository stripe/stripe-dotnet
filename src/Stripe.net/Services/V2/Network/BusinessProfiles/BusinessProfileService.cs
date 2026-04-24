// File generated from our OpenAPI spec
namespace Stripe.V2.Network
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BusinessProfileService : Service
    {
        internal BusinessProfileService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal BusinessProfileService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a Stripe profile by its Network ID.
        /// </summary>
        public virtual BusinessProfile Get(string id, BusinessProfileGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BusinessProfile>(BaseAddress.Api, HttpMethod.Get, $"/v2/network/business_profiles/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Stripe profile by its Network ID.
        /// </summary>
        public virtual Task<BusinessProfile> GetAsync(string id, BusinessProfileGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BusinessProfile>(BaseAddress.Api, HttpMethod.Get, $"/v2/network/business_profiles/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve the Stripe profile associated with the requesting merchant and livemode.
        /// </summary>
        public virtual BusinessProfile Me(BusinessProfileMeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BusinessProfile>(BaseAddress.Api, HttpMethod.Get, $"/v2/network/business_profiles/me", options, requestOptions);
        }

        /// <summary>
        /// Retrieve the Stripe profile associated with the requesting merchant and livemode.
        /// </summary>
        public virtual Task<BusinessProfile> MeAsync(BusinessProfileMeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BusinessProfile>(BaseAddress.Api, HttpMethod.Get, $"/v2/network/business_profiles/me", options, requestOptions, cancellationToken);
        }
    }
}
