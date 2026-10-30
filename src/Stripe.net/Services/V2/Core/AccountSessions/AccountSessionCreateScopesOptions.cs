// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionCreateScopesOptions : INestedOptions
    {
        /// <summary>
        /// The Stripe App IDs allowed in the enabled app components.
        /// </summary>
        [JsonProperty("allowed_stripe_app_ids")]
        [STJS.JsonPropertyName("allowed_stripe_app_ids")]
        public List<string> AllowedStripeAppIds { get; set; }

        /// <summary>
        /// Whether to allow capturing payments.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("capture_payments")]
        [STJS.JsonPropertyName("capture_payments")]
        public string CapturePayments { get; set; }

        /// <summary>
        /// Controls whether creating instant payouts is enabled, disabled, or determined by
        /// Dashboard rules.
        /// One of: <c>disabled</c>, <c>enabled</c>, or <c>use_dashboard_rules</c>.
        /// </summary>
        [JsonProperty("create_instant_payouts")]
        [STJS.JsonPropertyName("create_instant_payouts")]
        public string CreateInstantPayouts { get; set; }

        /// <summary>
        /// Whether to allow creating outbound payments.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_outbound_payments")]
        [STJS.JsonPropertyName("create_outbound_payments")]
        public string CreateOutboundPayments { get; set; }

        /// <summary>
        /// Whether to allow changing the payout schedule.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_payout_schedule")]
        [STJS.JsonPropertyName("create_payout_schedule")]
        public string CreatePayoutSchedule { get; set; }

        /// <summary>
        /// Whether to allow creating standard payouts.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_standard_payouts")]
        [STJS.JsonPropertyName("create_standard_payouts")]
        public string CreateStandardPayouts { get; set; }

        /// <summary>
        /// Whether to allow creating US paper checks on the application.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_us_paper_check_on_application")]
        [STJS.JsonPropertyName("create_us_paper_check_on_application")]
        public string CreateUsPaperCheckOnApplication { get; set; }

        /// <summary>
        /// Whether to disable Stripe user authentication in the enabled components.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public string DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow managing bills.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_bills")]
        [STJS.JsonPropertyName("manage_bills")]
        public string ManageBills { get; set; }

        /// <summary>
        /// Whether to allow managing destination and on-behalf-of charges.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_destination_on_behalf_of_charges")]
        [STJS.JsonPropertyName("manage_destination_on_behalf_of_charges")]
        public string ManageDestinationOnBehalfOfCharges { get; set; }

        /// <summary>
        /// Whether to allow managing Issuing cardholders.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_cardholders")]
        [STJS.JsonPropertyName("manage_issuing_cardholders")]
        public string ManageIssuingCardholders { get; set; }

        /// <summary>
        /// Whether to allow managing Issuing cards.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_cards")]
        [STJS.JsonPropertyName("manage_issuing_cards")]
        public string ManageIssuingCards { get; set; }

        /// <summary>
        /// Whether to allow managing Issuing disputes.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_disputes")]
        [STJS.JsonPropertyName("manage_issuing_disputes")]
        public string ManageIssuingDisputes { get; set; }

        /// <summary>
        /// Whether to allow managing Issuing spending controls.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_spending_controls")]
        [STJS.JsonPropertyName("manage_issuing_spending_controls")]
        public string ManageIssuingSpendingControls { get; set; }

        /// <summary>
        /// Whether to allow managing payment disputes.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_payment_disputes")]
        [STJS.JsonPropertyName("manage_payment_disputes")]
        public string ManagePaymentDisputes { get; set; }

        /// <summary>
        /// Whether to allow managing payout methods.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_payout_methods")]
        [STJS.JsonPropertyName("manage_payout_methods")]
        public string ManagePayoutMethods { get; set; }

        /// <summary>
        /// Whether to allow refunding payments.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_refund_payments")]
        [STJS.JsonPropertyName("manage_refund_payments")]
        public string ManageRefundPayments { get; set; }

        /// <summary>
        /// Whether to allow managing Smart Disputes.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_smart_disputes")]
        [STJS.JsonPropertyName("manage_smart_disputes")]
        public string ManageSmartDisputes { get; set; }
    }
}
