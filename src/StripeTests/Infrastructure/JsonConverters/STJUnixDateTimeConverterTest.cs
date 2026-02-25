#if NET6_0_OR_GREATER
namespace StripeTests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;
    using STJS = System.Text.Json.Serialization;

    public class STJUnixDateTimeConverterTest : BaseStripeTest
    {
        private readonly STJUnixDateTimeConverter converter;
        private readonly JsonSerializerOptions options;

        public STJUnixDateTimeConverterTest()
        {
            this.converter = new STJUnixDateTimeConverter();
            this.options = new JsonSerializerOptions();
        }

        [Fact]
        public void Read_ValidUnixTimestampAsNumber()
        {
            var json = "{\n  \"created_at\": 1640995200\n}";
            var obj = JsonSerializer.Deserialize<TestObject>(json);

            Assert.Equal(1640995200, obj.CreatedAt);
            Assert.NotNull(obj.CreatedAt);
        }

        [Fact]
        public void Read_ValidNullUnixTimestamp()
        {
            var payload = "{\n  \"id\": \"evt_1Rr1JvFtG20dLAMsr7rHdgc2\",\n  \"object\": \"event\",\n  \"account\": \"acct_1RmfQsFtG20dLAMs\",\n  \"api_version\": \"2025-07-30.basil\",\n  \"context\": \"acct_1RmfQsFtG20dLAMs\",\n  \"created\": 1753986915,\n  \"data\": {\n    \"object\": {\n      \"id\": \"sub_1Rr1JuFtG20dLAMseqyV6s6G\",\n      \"object\": \"subscription\",\n      \"application\": \"ca_SmZ5iAGaRQDDNPqhbcsigRQREqD0dLt1\",\n      \"application_fee_percent\": null,\n      \"automatic_tax\": {\n        \"disabled_reason\": null,\n        \"enabled\": false,\n        \"liability\": null\n      },\n      \"billing_cycle_anchor\": 1753986914,\n      \"billing_cycle_anchor_config\": null,\n      \"billing_mode\": {\n        \"type\": \"classic\",\n        \"updated_at\": 0\n      },\n      \"billing_thresholds\": null,\n      \"cancel_at\": null,\n      \"cancel_at_period_end\": false,\n      \"canceled_at\": null,\n      \"cancellation_details\": {\n        \"comment\": null,\n        \"feedback\": null,\n        \"reason\": null\n      },\n      \"collection_method\": \"charge_automatically\",\n      \"created\": 1753986914,\n      \"currency\": \"usd\",\n      \"customer\": \"cus_SmZKVtb338KqvK\",\n      \"days_until_due\": null,\n      \"default_payment_method\": \"pm_1Rr0QcFtG20dLAMsU9KmfBDC\",\n      \"default_source\": null,\n      \"default_tax_rates\": [],\n      \"description\": null,\n      \"discounts\": [],\n      \"ended_at\": null,\n      \"invoice_settings\": {\n        \"account_tax_ids\": null,\n        \"issuer\": {\n          \"account\": null,\n          \"type\": \"self\"\n        }\n      },\n      \"items\": {\n        \"object\": \"list\",\n        \"data\": [\n          {\n            \"id\": \"si_SmaUvBvBsIYUlI\",\n            \"object\": \"subscription_item\",\n            \"billing_thresholds\": null,\n            \"created\": 1753986915,\n            \"current_period_end\": 1756665314,\n            \"current_period_start\": 1753986914,\n            \"discounts\": [],\n            \"metadata\": {},\n            \"plan\": {\n              \"id\": \"price_1Rr0BmFtG20dLAMsgqSmxAvZ\",\n              \"object\": \"plan\",\n              \"active\": true,\n              \"amount\": 1167,\n              \"amount_decimal\": 1167,\n              \"billing_scheme\": \"per_unit\",\n              \"created\": 1753982566,\n              \"currency\": \"usd\",\n              \"interval\": \"month\",\n              \"interval_count\": 1,\n              \"livemode\": false,\n              \"metadata\": {\n                \"3c_round_up\": \"0\",\n                \"3c_zone_id\": \"1\",\n                \"3c_agreement_id\": \"5\"\n              },\n              \"meter\": null,\n              \"nickname\": \"Zone 1\",\n              \"product\": \"3c_agreement_5\",\n              \"tiers\": null,\n              \"tiers_mode\": null,\n              \"transform_usage\": null,\n              \"trial_period_days\": null,\n              \"usage_type\": \"licensed\"\n            },\n            \"price\": {\n              \"id\": \"price_1Rr0BmFtG20dLAMsgqSmxAvZ\",\n              \"object\": \"price\",\n              \"active\": true,\n              \"billing_scheme\": \"per_unit\",\n              \"created\": 1753982566,\n              \"currency\": \"usd\",\n              \"currency_options\": null,\n              \"custom_unit_amount\": null,\n              \"livemode\": false,\n              \"lookup_key\": null,\n              \"metadata\": {\n                \"3c_round_up\": \"0\",\n                \"3c_zone_id\": \"1\",\n                \"3c_agreement_id\": \"5\"\n              },\n              \"nickname\": \"Zone 1\",\n              \"product\": \"3c_agreement_5\",\n              \"recurring\": {\n                \"interval\": \"month\",\n                \"interval_count\": 1,\n                \"meter\": null,\n                \"trial_period_days\": null,\n                \"usage_type\": \"licensed\"\n              },\n              \"tax_behavior\": \"unspecified\",\n              \"tiers\": null,\n              \"tiers_mode\": null,\n              \"transform_quantity\": null,\n              \"type\": \"recurring\",\n              \"unit_amount\": 1167,\n              \"unit_amount_decimal\": 1167\n            },\n            \"quantity\": 1,\n            \"subscription\": \"sub_1Rr1JuFtG20dLAMseqyV6s6G\",\n            \"tax_rates\": []\n          }\n        ],\n        \"has_more\": false,\n        \"url\": \"/v1/subscription_items?subscription=sub_1Rr1JuFtG20dLAMseqyV6s6G\"\n      },\n      \"latest_invoice\": \"in_1Rr1JvFtG20dLAMsdm4DSlKg\",\n      \"livemode\": false,\n      \"metadata\": {},\n      \"next_pending_invoice_item_invoice\": null,\n      \"on_behalf_of\": null,\n      \"pause_collection\": null,\n      \"payment_settings\": {\n        \"payment_method_options\": null,\n        \"payment_method_types\": null,\n        \"save_default_payment_method\": null\n      },\n      \"pending_invoice_item_interval\": null,\n      \"pending_setup_intent\": null,\n      \"pending_update\": null,\n      \"schedule\": \"sub_sched_1Rr1JuFtG20dLAMsgegakr2q\",\n      \"start_date\": 1753986914,\n      \"status\": \"active\",\n      \"test_clock\": null,\n      \"transfer_data\": null,\n      \"trial_end\": null,\n      \"trial_settings\": {\n        \"end_behavior\": {\n          \"missing_payment_method\": \"create_invoice\"\n        }\n      },\n      \"trial_start\": null\n    },\n    \"previous_attributes\": null\n  },\n  \"livemode\": false,\n  \"pending_webhooks\": 4,\n  \"request\": {\n    \"id\": \"req_MKH4UX85vdDnq3\",\n    \"idempotency_key\": \"caaec5d2-bf4d-4009-ab91-316a2e5394c4:283c3507-60c3-51e5-3df5-8b6f15f37ff6\"\n  },\n  \"type\": \"customer.subscription.created\"\n}";

            // Fails
            var des_json = JsonSerializer.Deserialize<Stripe.Event>(payload);
        }

        private class TestObject : StripeEntity<TestObject>
        {
            [STJS.JsonPropertyName("created_at")]
            public long? CreatedAt { get; set; }
        }
    }
}
#endif
