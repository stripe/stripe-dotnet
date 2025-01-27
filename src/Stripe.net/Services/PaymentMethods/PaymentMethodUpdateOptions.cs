// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow. The
        /// field defaults to <c>unspecified</c>.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        public string AllowRedisplay { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public PaymentMethodBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is a <c>card</c> PaymentMethod, this hash contains the user's card details.
        /// </summary>
        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        /// <summary>
        /// If this is an <c>Link</c> PaymentMethod, this hash contains details about the Link
        /// payment method.
        /// </summary>
        [JsonProperty("link")]
        public PaymentMethodLinkOptions Link { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is a <c>naver_pay</c> PaymentMethod, this hash contains details about the Naver
        /// Pay payment method.
        /// </summary>
        [JsonProperty("naver_pay")]
        public PaymentMethodNaverPayOptions NaverPay { get; set; }

        /// <summary>
        /// If this is a <c>pay_by_bank</c> PaymentMethod, this hash contains details about the
        /// PayByBank payment method.
        /// </summary>
        [JsonProperty("pay_by_bank")]
        public PaymentMethodPayByBankOptions PayByBank { get; set; }

        /// <summary>
        /// If this is an <c>us_bank_account</c> PaymentMethod, this hash contains details about the
        /// US bank account payment method.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public PaymentMethodUsBankAccountOptions UsBankAccount { get; set; }
    }
}
