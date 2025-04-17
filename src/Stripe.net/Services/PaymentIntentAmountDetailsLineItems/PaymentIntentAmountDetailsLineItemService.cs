// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentIntentAmountDetailsLineItemService : Service,
        INestedListable<PaymentIntentAmountDetailsLineItem, PaymentIntentAmountDetailsLineItemListOptions>
    {
        public PaymentIntentAmountDetailsLineItemService()
        {
        }

        internal PaymentIntentAmountDetailsLineItemService(
            ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentIntentAmountDetailsLineItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists all LineItems of a given PaymentIntent.</p>.
        /// </summary>
        public virtual StripeList<PaymentIntentAmountDetailsLineItem> List(string parentId, PaymentIntentAmountDetailsLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentIntentAmountDetailsLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_intents/{WebUtility.UrlEncode(parentId)}/amount_details_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all LineItems of a given PaymentIntent.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentIntentAmountDetailsLineItem>> ListAsync(string parentId, PaymentIntentAmountDetailsLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentIntentAmountDetailsLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_intents/{WebUtility.UrlEncode(parentId)}/amount_details_line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all LineItems of a given PaymentIntent.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentIntentAmountDetailsLineItem> ListAutoPaging(string parentId, PaymentIntentAmountDetailsLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentIntentAmountDetailsLineItem>($"/v1/payment_intents/{WebUtility.UrlEncode(parentId)}/amount_details_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all LineItems of a given PaymentIntent.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentIntentAmountDetailsLineItem> ListAutoPagingAsync(string parentId, PaymentIntentAmountDetailsLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentIntentAmountDetailsLineItem>($"/v1/payment_intents/{WebUtility.UrlEncode(parentId)}/amount_details_line_items", options, requestOptions, cancellationToken);
        }
    }
}
