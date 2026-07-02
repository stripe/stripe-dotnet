// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A read-only representation of a user's PaymentMethod for use in Crypto On Ramp
    /// transactions.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerPaymentToken : StripeEntity<CustomerPaymentToken>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A <c>card</c> PaymentToken, this hash contains details of the card PaymentToken.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public CustomerPaymentTokenCard Card { get; set; }

        /// <summary>
        /// Type of the Payment Token.
        /// One of: <c>card</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// A <c>us_bank_account</c> PaymentToken, this hash contains details of the US bank account
        /// PaymentToken.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public CustomerPaymentTokenUsBankAccount UsBankAccount { get; set; }
    }
}
