// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class GiftCardOperationService : Service,
        IRetrievable<GiftCardOperation, GiftCardOperationGetOptions>
    {
        public GiftCardOperationService()
        {
        }

        internal GiftCardOperationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public GiftCardOperationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a third-party gift card operation object.</p>.
        /// </summary>
        public virtual GiftCardOperation Get(string id, GiftCardOperationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCardOperation>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_card_operations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a third-party gift card operation object.</p>.
        /// </summary>
        public virtual Task<GiftCardOperation> GetAsync(string id, GiftCardOperationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCardOperation>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_card_operations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
