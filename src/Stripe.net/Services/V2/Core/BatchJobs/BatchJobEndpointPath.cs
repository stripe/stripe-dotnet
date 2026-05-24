// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class BatchJobEndpointPath : StringEnum
    {
        public static readonly BatchJobEndpointPath V1AccountUpdate = new BatchJobEndpointPath("/v1/accounts/:account");
        public static readonly BatchJobEndpointPath V1CouponCreate = new BatchJobEndpointPath("/v1/coupons");
        public static readonly BatchJobEndpointPath V1CustomerUpdate = new BatchJobEndpointPath("/v1/customers/:customer");
        public static readonly BatchJobEndpointPath V1PromotionCodeCreate = new BatchJobEndpointPath("/v1/promotion_codes");
        public static readonly BatchJobEndpointPath V1PromotionCodeUpdate = new BatchJobEndpointPath("/v1/promotion_codes/:promotion_code");
        public static readonly BatchJobEndpointPath V1SubscriptionUpdate = new BatchJobEndpointPath("/v1/subscriptions/:subscription_exposed_id");
        public static readonly BatchJobEndpointPath V1SubscriptionCancel = new BatchJobEndpointPath("/v1/subscriptions/:subscription_exposed_id");
        public static readonly BatchJobEndpointPath V1SubscriptionMigrate = new BatchJobEndpointPath("/v1/subscriptions/:subscription/migrate");

        private BatchJobEndpointPath(string value)
            : base(value)
        {
        }
    }
}
