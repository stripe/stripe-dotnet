namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Xunit;

    public class CustomerServiceSerializeBatchTest : BaseStripeTest
    {
        private readonly CustomerService service;

        public CustomerServiceSerializeBatchTest()
        {
            this.service = new CustomerService(this.StripeClient);
        }

        [Fact]
        public void SerializeBatchUpdate_BasicStructure()
        {
            var options = new CustomerUpdateOptions
            {
                Description = "test customer",
            };

            var json = this.service.SerializeBatchUpdate("cus_123", options);
            var parsed = JObject.Parse(json);

            // id is a valid GUID
            Assert.True(Guid.TryParse(parsed["id"].ToString(), out _));

            // path_params
            var pathParams = parsed["path_params"];
            Assert.Equal("cus_123", pathParams["customer"].ToString());

            // params contains description with snake_case key
            var paramsObj = parsed["params"];
            Assert.Equal("test customer", paramsObj["description"].ToString());

            // stripe_version matches global config
            Assert.Equal(
                StripeConfiguration.ApiVersion,
                parsed["stripe_version"].ToString());

            // context is absent when no StripeContext is set
            Assert.Null(parsed["context"]);
        }

        [Fact]
        public void SerializeBatchUpdate_UniqueIds()
        {
            var options = new CustomerUpdateOptions
            {
                Description = "test",
            };

            var json1 = this.service.SerializeBatchUpdate("cus_123", options);
            var json2 = this.service.SerializeBatchUpdate("cus_123", options);

            var id1 = JObject.Parse(json1)["id"].ToString();
            var id2 = JObject.Parse(json2)["id"].ToString();

            Assert.NotEqual(id1, id2);
        }

        [Fact]
        public void SerializeBatchUpdate_WithStripeContext()
        {
            var options = new CustomerUpdateOptions
            {
                Description = "test",
            };
            var requestOptions = new RequestOptions
            {
                StripeContext = "acct_123",
            };

            var json = this.service.SerializeBatchUpdate("cus_123", options, requestOptions);
            var parsed = JObject.Parse(json);

            Assert.Equal("acct_123", parsed["context"].ToString());
        }

        [Fact]
        public void SerializeBatchUpdate_NullOptions()
        {
            var json = this.service.SerializeBatchUpdate("cus_123", null);
            var parsed = JObject.Parse(json);

            // params should be null
            Assert.Equal(JTokenType.Null, parsed["params"].Type);

            // Other fields still present and correct
            Assert.True(Guid.TryParse(parsed["id"].ToString(), out _));
            Assert.Equal("cus_123", parsed["path_params"]["customer"].ToString());
            Assert.Equal(
                StripeConfiguration.ApiVersion,
                parsed["stripe_version"].ToString());
        }

        [Fact]
        public void SerializeBatchUpdate_WithMetadata()
        {
            var options = new CustomerUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key1", "value1" },
                    { "key2", "value2" },
                },
            };

            var json = this.service.SerializeBatchUpdate("cus_123", options);
            var parsed = JObject.Parse(json);

            var metadata = parsed["params"]["metadata"];
            Assert.Equal("value1", metadata["key1"].ToString());
            Assert.Equal("value2", metadata["key2"].ToString());
        }

        [Fact]
        public void SerializeBatchUpdate_NullRequestOptions()
        {
            var options = new CustomerUpdateOptions
            {
                Description = "test",
            };

            var json = this.service.SerializeBatchUpdate("cus_123", options, null);
            var parsed = JObject.Parse(json);

            Assert.Equal(
                StripeConfiguration.ApiVersion,
                parsed["stripe_version"].ToString());
            Assert.Null(parsed["context"]);
        }

        [Fact]
        public void SerializeBatchUpdate_OnlySetPropertiesSerialized()
        {
            var options = new CustomerUpdateOptions
            {
                Description = "test",
            };

            var json = this.service.SerializeBatchUpdate("cus_123", options);
            var parsed = JObject.Parse(json);

            var paramsObj = (JObject)parsed["params"];

            // Only "description" should be present — null properties like
            // email, name, etc. should be omitted by NullValueHandling.Ignore
            Assert.Single(paramsObj.Properties());
            Assert.Equal("description", paramsObj.Properties().First().Name);
        }

        [Fact]
        public void SerializeBatchUpdate_IgnoresRequestOptionsStripeVersion()
        {
            var options = new CustomerUpdateOptions
            {
                Description = "test",
            };
            var requestOptions = new RequestOptions
            {
                StripeVersion = "2024-01-01",
            };

            var json = this.service.SerializeBatchUpdate("cus_123", options, requestOptions);
            var parsed = JObject.Parse(json);

            // Always uses global ApiVersion, ignoring RequestOptions.StripeVersion
            Assert.Equal(
                StripeConfiguration.ApiVersion,
                parsed["stripe_version"].ToString());
        }
    }
}
