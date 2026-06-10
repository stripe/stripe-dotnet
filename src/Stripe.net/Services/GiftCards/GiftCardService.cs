// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class GiftCardService : Service,
        ICreatable<GiftCard, GiftCardCreateOptions>,
        IRetrievable<GiftCard, GiftCardGetOptions>
    {
        public GiftCardService()
        {
        }

        internal GiftCardService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public GiftCardService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Activates a third-party gift card and optionally sets its balance.</p>.
        /// </summary>
        public virtual GiftCardOperation Activate(string id, GiftCardActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/activate", options, requestOptions);
        }

        /// <summary>
        /// <p>Activates a third-party gift card and optionally sets its balance.</p>.
        /// </summary>
        public virtual Task<GiftCardOperation> ActivateAsync(string id, GiftCardActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/activate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Cashout a third-party gift card by zeroing its balance.</p>.
        /// </summary>
        public virtual GiftCardOperation Cashout(string id, GiftCardCashoutOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/cashout", options, requestOptions);
        }

        /// <summary>
        /// <p>Cashout a third-party gift card by zeroing its balance.</p>.
        /// </summary>
        public virtual Task<GiftCardOperation> CashoutAsync(string id, GiftCardCashoutOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/cashout", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Checks the balance of a third-party gift card.</p>.
        /// </summary>
        public virtual GiftCardOperation CheckBalance(string id, GiftCardCheckBalanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/check_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Checks the balance of a third-party gift card.</p>.
        /// </summary>
        public virtual Task<GiftCardOperation> CheckBalanceAsync(string id, GiftCardCheckBalanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/check_balance", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a gift card object.</p>.
        /// </summary>
        public virtual GiftCard Create(GiftCardCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCard>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a gift card object.</p>.
        /// </summary>
        public virtual Task<GiftCard> CreateAsync(GiftCardCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCard>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a third-party gift card object.</p>.
        /// </summary>
        public virtual GiftCard Get(string id, GiftCardGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCard>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a third-party gift card object.</p>.
        /// </summary>
        public virtual Task<GiftCard> GetAsync(string id, GiftCardGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCard>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Reloads a third-party gift card by adding the specified amount to its balance.</p>.
        /// </summary>
        public virtual GiftCardOperation Reload(string id, GiftCardReloadOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/reload", options, requestOptions);
        }

        /// <summary>
        /// <p>Reloads a third-party gift card by adding the specified amount to its balance.</p>.
        /// </summary>
        public virtual Task<GiftCardOperation> ReloadAsync(string id, GiftCardReloadOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/reload", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Voids a previously performed gift card operation.</p>.
        /// </summary>
        public virtual GiftCardOperation VoidOperation(string id, GiftCardVoidOperationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/void_operation", options, requestOptions);
        }

        /// <summary>
        /// <p>Voids a previously performed gift card operation.</p>.
        /// </summary>
        public virtual Task<GiftCardOperation> VoidOperationAsync(string id, GiftCardVoidOperationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GiftCardOperation>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/{WebUtility.UrlEncode(id)}/void_operation", options, requestOptions, cancellationToken);
        }
    }
}
