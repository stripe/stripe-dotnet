namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("line_items")]
        public List<SessionLineItemOptions> LineItems { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("payment_intent_data")]
        public SessionPaymentIntentDataOptions PaymentIntentData { get; set; }

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("setup_intent_data")]
        public SessionSetupIntentDataOptions SetupIntentData { get; set; }

        [JsonProperty("shipping_address_collection")]
        public SessionShippingAddressCollectionOptions ShippingAddressCollection { get; set; }

        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        [JsonProperty("subscription_data")]
        public SessionSubscriptionDataOptions SubscriptionData { get; set; }

        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }
    }
}
