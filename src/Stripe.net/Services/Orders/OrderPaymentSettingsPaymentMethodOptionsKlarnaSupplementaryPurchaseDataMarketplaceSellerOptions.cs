// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions : INestedOptions
    {
        /// <summary>
        /// The references to line items for purchases with multiple associated sub-sellers.
        /// </summary>
        [JsonProperty("line_item_references")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_item_references")]
#endif
        public List<string> LineItemReferences { get; set; }

        /// <summary>
        /// The address of the selling or delivering merchant.
        /// </summary>
        [JsonProperty("marketplace_seller_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketplace_seller_address")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerMarketplaceSellerAddressOptions MarketplaceSellerAddress { get; set; }

        /// <summary>
        /// The name of the marketplace seller.
        /// </summary>
        [JsonProperty("marketplace_seller_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketplace_seller_name")]
#endif
        public string MarketplaceSellerName { get; set; }

        /// <summary>
        /// The unique identifier for the marketplace seller.
        /// </summary>
        [JsonProperty("marketplace_seller_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketplace_seller_reference")]
#endif
        public string MarketplaceSellerReference { get; set; }

        /// <summary>
        /// The number of transactions the sub-seller completed in the last 12 months.
        /// </summary>
        [JsonProperty("number_of_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number_of_transactions")]
#endif
        public long? NumberOfTransactions { get; set; }

        /// <summary>
        /// The category of the product.
        /// One of: <c>accessories</c>, <c>appliances</c>, <c>apps_and_games</c>,
        /// <c>arts_crafts_and_sewing</c>, <c>automotive</c>, <c>baby</c>, <c>baby_clothing</c>,
        /// <c>bags_and_purses</c>, <c>beauty</c>, <c>books</c>, <c>cds_and_vinyl</c>,
        /// <c>cell_phones_and_accessories</c>, <c>collectibles_and_fine_arts</c>,
        /// <c>digital_music</c>, <c>electronics</c>, <c>grocery_and_gourmet_food</c>,
        /// <c>handmade</c>, <c>health_and_personal_care</c>, <c>home_and_kitchen</c>,
        /// <c>industrial_and_scientific</c>, <c>luggage_and_travel_gear</c>,
        /// <c>magazine_subscriptions</c>, <c>men_clothing</c>, <c>musical_instruments</c>,
        /// <c>office_products</c>, <c>patio_lawn_and_garden</c>, <c>pet_supplies</c>, <c>shoes</c>,
        /// <c>software</c>, <c>sports_and_outdoors</c>, <c>tools_and_home_improvement</c>,
        /// <c>toys_and_games</c>, <c>video_games</c>, or <c>women_clothing</c>.
        /// </summary>
        [JsonProperty("product_category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_category")]
#endif
        public string ProductCategory { get; set; }

        /// <summary>
        /// The date when the seller's account with the marketplace was last logged in.
        /// </summary>
        [JsonProperty("seller_last_login_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("seller_last_login_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SellerLastLoginAt { get; set; }

        /// <summary>
        /// The current rating of the marketplace seller. If the marketplace uses numeric ranking,
        /// map these to the enum values.
        /// One of: <c>high</c>, <c>low</c>, <c>medium</c>, <c>very_high</c>, or <c>very_low</c>.
        /// </summary>
        [JsonProperty("seller_rating")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("seller_rating")]
#endif
        public string SellerRating { get; set; }

        /// <summary>
        /// The date when the seller's account with the marketplace was created.
        /// </summary>
        [JsonProperty("seller_registered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("seller_registered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SellerRegisteredAt { get; set; }

        /// <summary>
        /// The date when the seller's account with the marketplace was last updated.
        /// </summary>
        [JsonProperty("seller_updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("seller_updated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SellerUpdatedAt { get; set; }

        /// <summary>
        /// The references to shipping addresses for purchases with multiple associated sub-sellers.
        /// </summary>
        [JsonProperty("shipping_references")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_references")]
#endif
        public List<string> ShippingReferences { get; set; }

        /// <summary>
        /// The accumulated amount of sales transactions made by the sub-merchant or sub-seller
        /// within the past 12 months in the payment currency. These transactions are in minor
        /// currency units.
        /// </summary>
        [JsonProperty("volume_of_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("volume_of_transactions")]
#endif
        public long? VolumeOfTransactions { get; set; }
    }
}
