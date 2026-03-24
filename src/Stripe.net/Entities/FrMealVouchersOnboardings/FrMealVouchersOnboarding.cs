// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>French Meal Vouchers Onboarding</c> resource encapsulates the onboarding status
    /// and other related information for a single restaurant (SIRET number) in the context of
    /// the French Meal Vouchers program.
    ///
    /// To onboard a restaurant for the French Meal Vouchers program, you create a <c>French
    /// Meal Vouchers Onboarding</c> object. You can retrieve individual objects, list all such
    /// objects, or update objects to correct the postal code of the restaurant. We identify
    /// <c>French Meal Vouchers Onboarding</c> objects with a unique, random ID.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/payments/meal-vouchers/fr-meal-vouchers/set-up-restaurant">Set
    /// up a restaurant for titres-restaurant payments</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FrMealVouchersOnboarding : StripeEntity<FrMealVouchersOnboarding>, IHasId, IHasMetadata, IHasObject
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
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Name of the restaurant.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Postal code of the restaurant.
        /// </summary>
        [JsonProperty("postal_code")]
        [STJS.JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// This represents the onboarding state of the restaurant on different providers.
        /// </summary>
        [JsonProperty("providers")]
        [STJS.JsonPropertyName("providers")]
        public FrMealVouchersOnboardingProviders Providers { get; set; }

        /// <summary>
        /// SIRET number associated with the restaurant.
        /// </summary>
        [JsonProperty("siret")]
        [STJS.JsonPropertyName("siret")]
        public string Siret { get; set; }
    }
}
