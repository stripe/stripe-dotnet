namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class EventServiceTest : BaseStripeTest
    {
        private const string EventId = "evt_123";

        private readonly EventService service;
        private readonly EventListOptions listOptions;

        public EventServiceTest()
        {
            this.service = new EventService();

            this.listOptions = new EventListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var evt = this.service.Get(EventId);
            this.AssertRequest(HttpMethod.Get, "/v1/events/evt_123");
            Assert.NotNull(evt);
            Assert.Equal("event", evt.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var evt = await this.service.GetAsync(EventId);
            this.AssertRequest(HttpMethod.Get, "/v1/events/evt_123");
            Assert.NotNull(evt);
            Assert.Equal("event", evt.Object);
        }

        [Fact]
        public void List()
        {
            var events = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/events");
            Assert.NotNull(events);
            Assert.Equal("list", events.Object);
            Assert.Single(events.Data);
            Assert.Equal("event", events.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var events = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/events");
            Assert.NotNull(events);
            Assert.Equal("list", events.Object);
            Assert.Single(events.Data);
            Assert.Equal("event", events.Data[0].Object);
        }
    }
}
