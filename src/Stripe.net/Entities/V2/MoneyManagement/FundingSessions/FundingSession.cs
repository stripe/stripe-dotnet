// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A FundingSession is a hosted funding surface for a customer to fund a FinancialAccount.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingSession : StripeEntity<FundingSession>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the FundingSession. ID prefix: <c>fndsess</c>.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The ID of the Account that owns the FinancialAccount.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The creation timestamp of the FundingSession.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the FinancialAccount this FundingSession funds.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Per-type options used when creating the FinancialAddress.
        /// </summary>
        [JsonProperty("financial_address_options")]
        [STJS.JsonPropertyName("financial_address_options")]
        public FundingSessionFinancialAddressOptions FinancialAddressOptions { get; set; }

        /// <summary>
        /// Open Enum. The types of FinancialAddress that can be funded in this session.
        /// One of: <c>bank_account</c>, or <c>crypto_wallet</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("financial_address_types")]
        [STJS.JsonPropertyName("financial_address_types")]
        public List<string> FinancialAddressTypes { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The URL the customer is redirected to after completing (or abandoning) the funding
        /// session.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The short-lived hosted funding URL the customer visits to fund the FinancialAccount.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
