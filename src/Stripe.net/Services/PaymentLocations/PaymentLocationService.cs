// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentLocationService : Service,
        ICreatable<PaymentLocation, PaymentLocationCreateOptions>,
        IDeletable<PaymentLocation, PaymentLocationDeleteOptions>,
        IRetrievable<PaymentLocation, PaymentLocationGetOptions>,
        IUpdatable<PaymentLocation, PaymentLocationUpdateOptions>
    {
        public PaymentLocationService()
        {
        }

        internal PaymentLocationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentLocationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create a Payment Location.</p>.
        /// </summary>
        public virtual PaymentLocation Create(PaymentLocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLocation>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a Payment Location.</p>.
        /// </summary>
        public virtual Task<PaymentLocation> CreateAsync(PaymentLocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLocation>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_locations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a Payment Location.</p>.
        /// </summary>
        public virtual PaymentLocation Delete(string id, PaymentLocationDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLocation>(BaseAddress.Api, HttpMethod.Delete, $"/v1/payment_locations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a Payment Location.</p>.
        /// </summary>
        public virtual Task<PaymentLocation> DeleteAsync(string id, PaymentLocationDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLocation>(BaseAddress.Api, HttpMethod.Delete, $"/v1/payment_locations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a Payment Location.</p>.
        /// </summary>
        public virtual PaymentLocation Get(string id, PaymentLocationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLocation>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_locations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a Payment Location.</p>.
        /// </summary>
        public virtual Task<PaymentLocation> GetAsync(string id, PaymentLocationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLocation>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_locations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Update a Payment Location.</p>.
        /// </summary>
        public virtual PaymentLocation Update(string id, PaymentLocationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLocation>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_locations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Update a Payment Location.</p>.
        /// </summary>
        public virtual Task<PaymentLocation> UpdateAsync(string id, PaymentLocationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLocation>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_locations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
