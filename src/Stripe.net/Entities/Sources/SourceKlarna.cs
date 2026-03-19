// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceKlarna : StripeEntity<SourceKlarna>
    {
        [JsonProperty("background_image_url")]
        [STJS.JsonPropertyName("background_image_url")]
        public string BackgroundImageUrl { get; set; }

        [JsonProperty("client_token")]
        [STJS.JsonPropertyName("client_token")]
        public string ClientToken { get; set; }

        [JsonProperty("first_name")]
        [STJS.JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        [STJS.JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonProperty("locale")]
        [STJS.JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonProperty("logo_url")]
        [STJS.JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("page_title")]
        [STJS.JsonPropertyName("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("pay_later_asset_urls_descriptive")]
        [STJS.JsonPropertyName("pay_later_asset_urls_descriptive")]
        public string PayLaterAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_later_asset_urls_standard")]
        [STJS.JsonPropertyName("pay_later_asset_urls_standard")]
        public string PayLaterAssetUrlsStandard { get; set; }

        [JsonProperty("pay_later_name")]
        [STJS.JsonPropertyName("pay_later_name")]
        public string PayLaterName { get; set; }

        [JsonProperty("pay_later_redirect_url")]
        [STJS.JsonPropertyName("pay_later_redirect_url")]
        public string PayLaterRedirectUrl { get; set; }

        [JsonProperty("pay_now_asset_urls_descriptive")]
        [STJS.JsonPropertyName("pay_now_asset_urls_descriptive")]
        public string PayNowAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_now_asset_urls_standard")]
        [STJS.JsonPropertyName("pay_now_asset_urls_standard")]
        public string PayNowAssetUrlsStandard { get; set; }

        [JsonProperty("pay_now_name")]
        [STJS.JsonPropertyName("pay_now_name")]
        public string PayNowName { get; set; }

        [JsonProperty("pay_now_redirect_url")]
        [STJS.JsonPropertyName("pay_now_redirect_url")]
        public string PayNowRedirectUrl { get; set; }

        [JsonProperty("pay_over_time_asset_urls_descriptive")]
        [STJS.JsonPropertyName("pay_over_time_asset_urls_descriptive")]
        public string PayOverTimeAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_over_time_asset_urls_standard")]
        [STJS.JsonPropertyName("pay_over_time_asset_urls_standard")]
        public string PayOverTimeAssetUrlsStandard { get; set; }

        [JsonProperty("pay_over_time_name")]
        [STJS.JsonPropertyName("pay_over_time_name")]
        public string PayOverTimeName { get; set; }

        [JsonProperty("pay_over_time_redirect_url")]
        [STJS.JsonPropertyName("pay_over_time_redirect_url")]
        public string PayOverTimeRedirectUrl { get; set; }

        [JsonProperty("payment_method_categories")]
        [STJS.JsonPropertyName("payment_method_categories")]
        public string PaymentMethodCategories { get; set; }

        [JsonProperty("purchase_country")]
        [STJS.JsonPropertyName("purchase_country")]
        public string PurchaseCountry { get; set; }

        [JsonProperty("purchase_type")]
        [STJS.JsonPropertyName("purchase_type")]
        public string PurchaseType { get; set; }

        [JsonProperty("redirect_url")]
        [STJS.JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("shipping_delay")]
        [STJS.JsonPropertyName("shipping_delay")]
        public long ShippingDelay { get; set; }

        [JsonProperty("shipping_first_name")]
        [STJS.JsonPropertyName("shipping_first_name")]
        public string ShippingFirstName { get; set; }

        [JsonProperty("shipping_last_name")]
        [STJS.JsonPropertyName("shipping_last_name")]
        public string ShippingLastName { get; set; }
    }
}
