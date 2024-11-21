// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentTransferData : StripeEntity<PaymentIntentTransferData>
    {
        /// <summary>
        /// Amount intended to be collected by this PaymentIntent. A positive integer representing
        /// how much to charge in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum
        /// amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long Amount { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) that the payment is attributed to for tax reporting, and where
        /// funds from the payment are transferred to after payment success.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// The account (if any) that the payment is attributed to for tax reporting, and where
        /// funds from the payment are transferred to after payment success.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif

        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
