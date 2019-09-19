namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceKlarna : StripeEntity<SourceKlarna>
    {
        [JsonProperty("background_image_url")]
        public string BackgroundImageUrl { get; set; }

        [JsonProperty("client_token")]
        public string ClientToken { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("pay_later_asset_urls_descriptive")]
        public string PayLaterAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_later_asset_urls_standard")]
        public string PayLaterAssetUrlsStandard { get; set; }

        [JsonProperty("pay_later_name")]
        public string PayLaterName { get; set; }

        [JsonProperty("pay_later_redirect_url")]
        public string PayLaterRedirectUrl { get; set; }

        [JsonProperty("pay_now_asset_urls_descriptive")]
        public string PayNowAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_now_asset_urls_standard")]
        public string PayNowAssetUrlsStandard { get; set; }

        [JsonProperty("pay_now_name")]
        public string PayNowName { get; set; }

        [JsonProperty("pay_now_redirect_url")]
        public string PayNowRedirectUrl { get; set; }

        [JsonProperty("pay_over_time_asset_urls_descriptive")]
        public string PayOverTimeAssetUrlsDescriptive { get; set; }

        [JsonProperty("pay_over_time_asset_urls_standard")]
        public string PayOverTimeAssetUrlsStandard { get; set; }

        [JsonProperty("pay_over_time_name")]
        public string PayOverTimeName { get; set; }

        [JsonProperty("pay_over_time_redirect_url")]
        public string PayOverTimeRedirectUrl { get; set; }

        [JsonProperty("payment_method_categories")]
        public string PaymentMethodCategories { get; set; }

        [JsonProperty("purchase_country")]
        public string PurchaseCountry { get; set; }

        [JsonProperty("purchase_type")]
        public string PurchaseType { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("shipping_first_name")]
        public string ShippingFirstName { get; set; }

        [JsonProperty("shipping_last_name")]
        public string ShippingLastName { get; set; }
    }
}
