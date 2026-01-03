#if NET6_0_OR_GREATER
namespace StripeTests
{
    using System;
    using System.Text.Json;
    using Stripe;
    using Xunit;

    /// <summary>
    /// Tests for <see cref="Stripe.Infrastructure.STJUnixDateTimeConverter"/>.
    /// These tests do NOT require stripe-mock as they test JSON deserialization directly.
    /// </summary>
    public class STJUnixDateTimeConverterTest
    {
        /// <summary>
        /// Deserialization with valid Unix timestamp: Verifies the converter correctly
        /// converts a valid Unix epoch timestamp to a DateTime value.
        /// </summary>
        [Fact]
        public void Deserialize_WithValidUnixTimestamp_ReturnsCorrectDateTime()
        {
            // Unix timestamp: 1609459200 = 2021-01-01 00:00:00 UTC
            var json = @"{""id"":""sub_123"",""object"":""subscription"",""canceled_at"":1609459200,""created"":1609459200}";

            var subscription = JsonSerializer.Deserialize<Subscription>(json);

            Assert.NotNull(subscription);
            Assert.True(subscription.CanceledAt.HasValue);
            Assert.Equal(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc), subscription.CanceledAt.Value);
        }

        /// <summary>
        /// Deserialization with null DateTime: Tests the fix for issue #3157.
        /// A nullable DateTime? property should accept null values without throwing JsonException.
        /// This test ensures the converter properly handles JsonTokenType.Null.
        /// </summary>
        [Fact]
        public void Deserialize_WithNullDateTime_ShouldNotThrow()
        {
            // This is the bug from issue #3157
            // canceled_at is a DateTime? property, so null should be valid
            var json = @"{""id"":""sub_123"",""object"":""subscription"",""canceled_at"":null,""created"":1609459200}";

            // This should NOT throw JsonException
            var subscription = JsonSerializer.Deserialize<Subscription>(json);

            Assert.NotNull(subscription);
            Assert.Null(subscription.CanceledAt);
        }

        /// <summary>
        /// Multiple nullable DateTime fields with null values: Verifies the converter can handle
        /// multiple DateTime? properties all with null values in a single object.
        /// This is common for entities that have optional date fields (canceled_at, trial_end, etc.).
        /// </summary>
        [Fact]
        public void Deserialize_MultipleNullableDateTimeFields_ShouldWork()
        {
            // Testing multiple nullable DateTime fields with null values
            var json = @"{
                ""id"":""sub_123"",
                ""object"":""subscription"",
                ""canceled_at"":null,
                ""trial_end"":null,
                ""trial_start"":null,
                ""cancel_at"":null,
                ""ended_at"":null,
                ""created"":1609459200,
                ""current_period_end"":1612137600,
                ""current_period_start"":1609459200
            }";

            var subscription = JsonSerializer.Deserialize<Subscription>(json);

            Assert.NotNull(subscription);
            Assert.Null(subscription.CanceledAt);
            Assert.Null(subscription.TrialEnd);
            Assert.Null(subscription.TrialStart);
            Assert.Null(subscription.CancelAt);
            Assert.Null(subscription.EndedAt);

            // Created is non-nullable DateTime, so it should have a value
            Assert.NotEqual(default(DateTime), subscription.Created);
        }

        /// <summary>
        /// Mixed null and actual values: Verifies the converter correctly handles a mix of
        /// null and non-null DateTime? fields in the same object.
        /// </summary>
        [Fact]
        public void Deserialize_MixedNullAndValues_ShouldWork()
        {
            // Some DateTime? fields with null, others with values
            var json = @"{
                ""id"":""sub_123"",
                ""object"":""subscription"",
                ""canceled_at"":1612137600,
                ""trial_end"":null,
                ""trial_start"":1609459200,
                ""created"":1609459200
            }";

            var subscription = JsonSerializer.Deserialize<Subscription>(json);

            Assert.NotNull(subscription);
            Assert.True(subscription.CanceledAt.HasValue);
            Assert.Null(subscription.TrialEnd);
            Assert.True(subscription.TrialStart.HasValue);
        }

        /// <summary>
        /// Serialization with null DateTime: Verifies that when serializing an object with
        /// a null DateTime? property, the converter outputs JSON null (not a number or empty value).
        /// </summary>
        [Fact]
        public void Serialize_NullDateTime_WritesNull()
        {
            var subscription = new Subscription
            {
                Id = "sub_123",
                CanceledAt = null,
                Created = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };

            var json = JsonSerializer.Serialize(subscription);

            Assert.Contains("\"canceled_at\":null", json);
        }

        /// <summary>
        /// Serialization with DateTime value: Verifies that when serializing an object with
        /// a non-null DateTime? property, the converter outputs the Unix epoch timestamp.
        /// </summary>
        [Fact]
        public void Serialize_WithDateTime_WritesUnixTimestamp()
        {
            var subscription = new Subscription
            {
                Id = "sub_123",
                CanceledAt = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                Created = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };

            var json = JsonSerializer.Serialize(subscription);

            // 1609459200 = 2021-01-01 00:00:00 UTC
            Assert.Contains("\"canceled_at\":1609459200", json);
        }

        /// <summary>
        /// Serialization then deserialization of null DateTime: Tests that the serialized null value
        /// is correctly preserved through the serialization-deserialization cycle.
        /// This test validates the converter produces correct JSON output for null values.
        /// </summary>
        [Fact]
        public void RoundTrip_NullDateTime_SerializesCorrectly()
        {
            // First, deserialize a subscription with null canceled_at
            var originalJson = @"{""id"":""sub_123"",""object"":""subscription"",""canceled_at"":null,""created"":1609459200}";
            var subscription = JsonSerializer.Deserialize<Subscription>(originalJson);
            Assert.NotNull(subscription);
            Assert.Null(subscription.CanceledAt);

            // Then serialize and verify the null is preserved in the output
            var serializedJson = JsonSerializer.Serialize(subscription);
            Assert.Contains("\"canceled_at\":null", serializedJson);
        }

        /// <summary>
        /// Serialization then deserialization of DateTime value: Tests that the serialized timestamp
        /// is correctly preserved through the serialization-deserialization cycle.
        /// </summary>
        [Fact]
        public void RoundTrip_WithDateTime_SerializesCorrectly()
        {
            // First, deserialize a subscription with a valid canceled_at timestamp
            var originalJson = @"{""id"":""sub_123"",""object"":""subscription"",""canceled_at"":1609459200,""created"":1609459200}";
            var expectedDate = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var subscription = JsonSerializer.Deserialize<Subscription>(originalJson);
            Assert.NotNull(subscription);
            Assert.Equal(expectedDate, subscription.CanceledAt);

            // Then serialize and verify the timestamp is preserved in the output
            var serializedJson = JsonSerializer.Serialize(subscription);
            Assert.Contains("\"canceled_at\":1609459200", serializedJson);
        }

        /// <summary>
        /// Full Event payload from issue #3157: Real-world scenario where a nested Subscription object
        /// within an Event payload contains null DateTime fields. This represents the exact scenario
        /// reported in issue #3157 with a customer.subscription.created event.
        /// </summary>
        [Fact]
        public void Deserialize_FullEventPayload_WithNullCanceledAt_ShouldWork()
        {
            // Real-world scenario from issue #3157
            var eventPayload = @"{
                ""id"": ""evt_123"",
                ""object"": ""event"",
                ""type"": ""customer.subscription.created"",
                ""created"": 1609459200,
                ""data"": {
                    ""object"": {
                        ""id"": ""sub_123"",
                        ""object"": ""subscription"",
                        ""canceled_at"": null,
                        ""created"": 1609459200,
                        ""current_period_end"": 1612137600,
                        ""current_period_start"": 1609459200
                    }
                }
            }";

            var evt = JsonSerializer.Deserialize<Event>(eventPayload);

            Assert.NotNull(evt);
            Assert.Equal("evt_123", evt.Id);

            // The subscription should be deserialized correctly with null canceled_at
            if (evt.Data?.Object is Subscription subscription)
            {
                Assert.Equal("sub_123", subscription.Id);
                Assert.Null(subscription.CanceledAt);
            }
        }
    }
}
#endif
