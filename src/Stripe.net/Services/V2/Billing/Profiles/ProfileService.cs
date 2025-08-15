// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProfileService : Service
    {
        internal ProfileService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProfileService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a BillingProfile object.
        /// </summary>
        public virtual Profile Create(ProfileCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Profile>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/profiles", options, requestOptions);
        }

        /// <summary>
        /// Create a BillingProfile object.
        /// </summary>
        public virtual Task<Profile> CreateAsync(ProfileCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Profile>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/profiles", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a BillingProfile object.
        /// </summary>
        public virtual Profile Get(string id, ProfileGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Profile>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/profiles/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a BillingProfile object.
        /// </summary>
        public virtual Task<Profile> GetAsync(string id, ProfileGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Profile>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/profiles/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Billing Profiles.
        /// </summary>
        public virtual V2.StripeList<Profile> List(ProfileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Profile>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/profiles", options, requestOptions);
        }

        /// <summary>
        /// List Billing Profiles.
        /// </summary>
        public virtual Task<V2.StripeList<Profile>> ListAsync(ProfileListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Profile>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/profiles", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Billing Profiles.
        /// </summary>
        public virtual IEnumerable<Profile> ListAutoPaging(ProfileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Profile>($"/v2/billing/profiles", options, requestOptions);
        }

        /// <summary>
        /// List Billing Profiles.
        /// </summary>
        public virtual IAsyncEnumerable<Profile> ListAutoPagingAsync(ProfileListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Profile>($"/v2/billing/profiles", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a BillingProfile object.
        /// </summary>
        public virtual Profile Update(string id, ProfileUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Profile>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/profiles/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a BillingProfile object.
        /// </summary>
        public virtual Task<Profile> UpdateAsync(string id, ProfileUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Profile>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/profiles/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
