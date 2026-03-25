// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public class PromotionCodeService : Service,
        ICreatable<PromotionCode, PromotionCodeCreateOptions>,
        IListable<PromotionCode, PromotionCodeListOptions>,
        IRetrievable<PromotionCode, PromotionCodeGetOptions>,
        IUpdatable<PromotionCode, PromotionCodeUpdateOptions>
    {
        public PromotionCodeService()
        {
        }

        internal PromotionCodeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PromotionCodeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>A promotion code points to an underlying promotion. You can optionally restrict the
        /// code to a specific customer, redemption limit, and expiration date.</p>.
        /// </summary>
        public virtual PromotionCode Create(PromotionCodeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(BaseAddress.Api, HttpMethod.Post, $"/v1/promotion_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>A promotion code points to an underlying promotion. You can optionally restrict the
        /// code to a specific customer, redemption limit, and expiration date.</p>.
        /// </summary>
        public virtual Task<PromotionCode> CreateAsync(PromotionCodeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(BaseAddress.Api, HttpMethod.Post, $"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the promotion code with the given ID. In order to retrieve a promotion code
        /// by the customer-facing <c>code</c> use <a
        /// href="https://stripe.com/docs/api/promotion_codes/list">list</a> with the desired
        /// <c>code</c>.</p>.
        /// </summary>
        public virtual PromotionCode Get(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(BaseAddress.Api, HttpMethod.Get, $"/v1/promotion_codes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the promotion code with the given ID. In order to retrieve a promotion code
        /// by the customer-facing <c>code</c> use <a
        /// href="https://stripe.com/docs/api/promotion_codes/list">list</a> with the desired
        /// <c>code</c>.</p>.
        /// </summary>
        public virtual Task<PromotionCode> GetAsync(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(BaseAddress.Api, HttpMethod.Get, $"/v1/promotion_codes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual StripeList<PromotionCode> List(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PromotionCode>>(BaseAddress.Api, HttpMethod.Get, $"/v1/promotion_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual Task<StripeList<PromotionCode>> ListAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PromotionCode>>(BaseAddress.Api, HttpMethod.Get, $"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual IEnumerable<PromotionCode> ListAutoPaging(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PromotionCode>($"/v1/promotion_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PromotionCode> ListAutoPagingAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PromotionCode>($"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes a PromotionCode create request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchCreate(PromotionCodeCreateOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", null },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(item, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// Serializes a PromotionCode update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchUpdate(string promotionCode, PromotionCodeUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", new Dictionary<string, string> { { "promotion_code", promotionCode } } },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(item, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// <p>Updates the specified promotion code by setting the values of the parameters passed.
        /// Most fields are, by design, not editable.</p>.
        /// </summary>
        public virtual PromotionCode Update(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(BaseAddress.Api, HttpMethod.Post, $"/v1/promotion_codes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified promotion code by setting the values of the parameters passed.
        /// Most fields are, by design, not editable.</p>.
        /// </summary>
        public virtual Task<PromotionCode> UpdateAsync(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(BaseAddress.Api, HttpMethod.Post, $"/v1/promotion_codes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
