// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferMandateCreateBacsOptions : INestedOptions
    {
        /// <summary>
        /// Optional prefix for the generated mandate reference. When nonempty, it must contain at
        /// most 10 letters, digits, or underscores. In live mode, Stripe uppercases the prefix.
        /// Prefixes beginning with DDIC or STRIPE are reserved regardless of case. In a Sandbox or
        /// test mode, set this parameter to one of the following exact, case-sensitive values to
        /// simulate a Bacs mandate outcome: - <c>ACTIVE</c>: Creates an active mandate immediately.
        /// - <c>PENDING</c>: Creates a pending mandate that does not automatically activate. -
        /// <c>FAIL</c>: Creates a canceled mandate with <c>status_details.canceled.reason</c> set
        /// to <c>refused_by_network</c>. - <c>EXPIRE</c>: Creates an expired mandate. -
        /// <c>VALIDATION_FAIL</c>: Returns an <c>inbound_mandate_cop_failed</c> error without
        /// creating a mandate. This test-only value is exempt from the normal 10-character prefix
        /// limit. If omitted, empty, or set to another valid prefix, creates an active mandate.
        /// These simulation values do not select test outcomes in live mode.
        /// </summary>
        [JsonProperty("reference_prefix")]
        [STJS.JsonPropertyName("reference_prefix")]
        public string ReferencePrefix { get; set; }
    }
}
