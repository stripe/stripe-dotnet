// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferMandateCreateOptions : BaseOptions
    {
        /// <summary>
        /// Optional Australian BECS-specific parameters.
        /// </summary>
        [JsonProperty("au_becs")]
        [STJS.JsonPropertyName("au_becs")]
        public InboundTransferMandateCreateAuBecsOptions AuBecs { get; set; }

        /// <summary>
        /// Optional Bacs-specific parameters.
        /// </summary>
        [JsonProperty("bacs")]
        [STJS.JsonPropertyName("bacs")]
        public InboundTransferMandateCreateBacsOptions Bacs { get; set; }

        /// <summary>
        /// The v2 credential (GB Bank Account or equivalent) this mandate is created for. Must
        /// belong to the authenticated compartment.
        /// </summary>
        [JsonProperty("credential")]
        [STJS.JsonPropertyName("credential")]
        public string Credential { get; set; }

        /// <summary>
        /// The mandate scheme type.
        /// One of: <c>au_becs</c>, <c>bacs</c>, <c>nz_becs</c>, or <c>sepa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Acceptance evidence collected from the account holder. Required when a platform creates
        /// a mandate for a connected account. Include that account's ID in the <a
        /// href="https://stripe.com/context">Stripe-Context header</a>, and provide accepted_at,
        /// online.ip_address, and online.user_agent. Direct account calls can omit details that
        /// Stripe derives from request metadata.
        /// </summary>
        [JsonProperty("user_accepted_details")]
        [STJS.JsonPropertyName("user_accepted_details")]
        public InboundTransferMandateCreateUserAcceptedDetailsOptions UserAcceptedDetails { get; set; }
    }
}
