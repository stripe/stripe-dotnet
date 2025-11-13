namespace StripeTests.Terminal
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Terminal;
    using Xunit;
#if NET6_0_OR_GREATER
    using System.Text.Json;
#endif

    public class ReaderTest : BaseStripeTest
    {
        public ReaderTest(StripeMockFixture stripeMockFixture)
: base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/terminal/readers/ds_123");
            var reader = JsonConvert.DeserializeObject<Reader>(json);
            Assert.NotNull(reader);
            Assert.IsType<Reader>(reader);
            Assert.NotNull(reader.Id);
            Assert.Equal("terminal.reader", reader.Object);
        }

        [Fact]
        public void DeserializeWithLastSeenAtInMilliseconds()
        {
            // This test verifies that timestamps in milliseconds are handled correctly
            // Addresses GitHub issue #3253 where last_seen_at comes as milliseconds instead of seconds

            // Unix timestamp in milliseconds for November 13, 2023 18:26:40 UTC
            // 1699900000000 milliseconds = 1699900000 seconds
            long timestampMillis = 1699900000000L;

            string json = $@"{{
    ""id"": ""tmr_test123"",
    ""object"": ""terminal.reader"",
    ""device_type"": ""simulated_stripe_s700"",
    ""label"": ""Test Reader"",
    ""last_seen_at"": {timestampMillis},
    ""livemode"": false,
    ""location"": ""tml_test456"",
    ""metadata"": {{}},
    ""serial_number"": ""123456789"",
    ""status"": ""online""
}}";

            // This should now work correctly with the updated converter
            var reader = JsonConvert.DeserializeObject<Reader>(json);

            Assert.NotNull(reader);
            Assert.NotNull(reader.LastSeenAt);

            // Verify the timestamp was parsed correctly
            // Expected: November 13, 2023 18:26:40 UTC (timestamp 1699900000)
            var expectedDate = new DateTime(2023, 11, 13, 18, 26, 40, DateTimeKind.Utc);
            Assert.Equal(expectedDate, reader.LastSeenAt.Value);
        }

        [Fact]
        public void DeserializeWithLastSeenAtInSeconds()
        {
            // This test verifies that regular timestamps in seconds still work correctly

            // Unix timestamp in seconds for November 13, 2023 18:26:40 UTC
            long timestampSeconds = 1699900000L;

            string json = $@"{{
    ""id"": ""tmr_test456"",
    ""object"": ""terminal.reader"",
    ""device_type"": ""simulated_stripe_s700"",
    ""label"": ""Test Reader Seconds"",
    ""last_seen_at"": {timestampSeconds},
    ""livemode"": false,
    ""location"": ""tml_test789"",
    ""metadata"": {{}},
    ""serial_number"": ""987654321"",
    ""status"": ""online""
}}";

            var reader = JsonConvert.DeserializeObject<Reader>(json);

            Assert.NotNull(reader);
            Assert.NotNull(reader.LastSeenAt);

            // Verify the timestamp was parsed correctly
            // Expected: November 13, 2023 18:26:40 UTC (timestamp 1699900000)
            var expectedDate = new DateTime(2023, 11, 13, 18, 26, 40, DateTimeKind.Utc);
            Assert.Equal(expectedDate, reader.LastSeenAt.Value);
        }

#if NET6_0_OR_GREATER
        [Fact]
        public void DeserializeWithLastSeenAtInMilliseconds_SystemTextJson()
        {
// This test verifies that timestamps in milliseconds are handled correctly in System.Text.Json
// Addresses GitHub issue #3253 where last_seen_at comes as milliseconds instead of seconds

// Unix timestamp in milliseconds for November 13, 2023 18:26:40 UTC
// 1699900000000 milliseconds = 1699900000 seconds
long timestampMillis = 1699900000000L;
string json = $@"{{
    ""id"": ""tmr_test123"",
    ""object"": ""terminal.reader"",
    ""device_type"": ""simulated_stripe_s700"",
    ""label"": ""Test Reader STJ"",
    ""last_seen_at"": {timestampMillis},
    ""livemode"": false,
    ""location"": ""tml_test456"",
    ""metadata"": {{}},
    ""serial_number"": ""123456789"",
    ""status"": ""online""
}}";

            // This should now work correctly with the updated STJ converter
            var reader = System.Text.Json.JsonSerializer.Deserialize<Reader>(json);

            Assert.NotNull(reader);
            Assert.NotNull(reader.LastSeenAt);

            // Verify the timestamp was parsed correctly
            // Expected: November 13, 2023 18:26:40 UTC (timestamp 1699900000)
            var expectedDate = new DateTime(2023, 11, 13, 18, 26, 40, DateTimeKind.Utc);
            Assert.Equal(expectedDate, reader.LastSeenAt.Value);
        }

        [Fact]
        public void DeserializeWithLastSeenAtInSeconds_SystemTextJson()
        {
// This test verifies that regular timestamps in seconds still work correctly in System.Text.Json

// Unix timestamp in seconds for November 13, 2023 18:26:40 UTC
long timestampSeconds = 1699900000L;
string json = $@"{{
    ""id"": ""tmr_test456"",
    ""object"": ""terminal.reader"",
    ""device_type"": ""simulated_stripe_s700"",
    ""label"": ""Test Reader Seconds STJ"",
    ""last_seen_at"": {timestampSeconds},
    ""livemode"": false,
    ""location"": ""tml_test789"",
    ""metadata"": {{}},
    ""serial_number"": ""987654321"",
    ""status"": ""online""
}}";

            var reader = System.Text.Json.JsonSerializer.Deserialize<Reader>(json);

            Assert.NotNull(reader);
            Assert.NotNull(reader.LastSeenAt);

            // Verify the timestamp was parsed correctly
            // Expected: November 13, 2023 18:26:40 UTC (timestamp 1699900000)
            var expectedDate = new DateTime(2023, 11, 13, 18, 26, 40, DateTimeKind.Utc);
            Assert.Equal(expectedDate, reader.LastSeenAt.Value);
        }
#endif
    }
}
