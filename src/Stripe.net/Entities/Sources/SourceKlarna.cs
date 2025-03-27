// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceKlarna : StripeEntity<SourceKlarna>
    {
        [JsonProperty("background_image_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("background_image_url")]
#endif
        public string BackgroundImageUrl { get; set; }

        [JsonProperty("client_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_token")]
#endif
        public string ClientToken { get; set; }

        [JsonProperty("first_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name")]
#endif
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name")]
#endif
        public string LastName { get; set; }

        [JsonProperty("locale")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("locale")]
#endif
        public string Locale { get; set; }

        [JsonProperty("logo_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("logo_url")]
#endif
        public string LogoUrl { get; set; }

        [JsonProperty("page_title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("page_title")]
#endif
        public string PageTitle { get; set; }

        [JsonProperty("pay_later_asset_urls_descriptive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_later_asset_urls_descriptive")]
#endif
        public string PayLaterAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_later_asset_urls_standard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_later_asset_urls_standard")]
#endif
        public string PayLaterAssetUrlsStandard { get; set; }

        [JsonProperty("pay_later_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_later_name")]
#endif
        public string PayLaterName { get; set; }

        [JsonProperty("pay_later_redirect_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_later_redirect_url")]
#endif
        public string PayLaterRedirectUrl { get; set; }

        [JsonProperty("pay_now_asset_urls_descriptive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_now_asset_urls_descriptive")]
#endif
        public string PayNowAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_now_asset_urls_standard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_now_asset_urls_standard")]
#endif
        public string PayNowAssetUrlsStandard { get; set; }

        [JsonProperty("pay_now_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_now_name")]
#endif
        public string PayNowName { get; set; }

        [JsonProperty("pay_now_redirect_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_now_redirect_url")]
#endif
        public string PayNowRedirectUrl { get; set; }

        [JsonProperty("pay_over_time_asset_urls_descriptive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_over_time_asset_urls_descriptive")]
#endif
        public string PayOverTimeAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_over_time_asset_urls_standard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_over_time_asset_urls_standard")]
#endif
        public string PayOverTimeAssetUrlsStandard { get; set; }

        [JsonProperty("pay_over_time_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_over_time_name")]
#endif
        public string PayOverTimeName { get; set; }

        [JsonProperty("pay_over_time_redirect_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_over_time_redirect_url")]
#endif
        public string PayOverTimeRedirectUrl { get; set; }

        [JsonProperty("payment_method_categories")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_categories")]
#endif
        public string PaymentMethodCategories { get; set; }

        [JsonProperty("purchase_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_country")]
#endif
        public string PurchaseCountry { get; set; }

        [JsonProperty("purchase_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_type")]
#endif
        public string PurchaseType { get; set; }

        [JsonProperty("redirect_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect_url")]
#endif
        public string RedirectUrl { get; set; }

        [JsonProperty("shipping_delay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_delay")]
#endif
        public long ShippingDelay { get; set; }

        [JsonProperty("shipping_first_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_first_name")]
#endif
        public string ShippingFirstName { get; set; }

        [JsonProperty("shipping_last_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_last_name")]
#endif
        public string ShippingLastName { get; set; }
    }
}
