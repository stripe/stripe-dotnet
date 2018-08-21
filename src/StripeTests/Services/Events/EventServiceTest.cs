namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class EventServiceTest : BaseStripeTest
    {
        private const string EventId = "evt_123";

        private EventService service;
        private EventListOptions listOptions;

        public EventServiceTest()
        {
            this.service = new EventService();

            this.listOptions = new EventListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var evt = this.service.Get(EventId);
            Assert.NotNull(evt);
            Assert.Equal("event", evt.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var evt = await this.service.GetAsync(EventId);
            Assert.NotNull(evt);
            Assert.Equal("event", evt.Object);
        }

        [Fact]
        public void List()
        {
            var events = this.service.List(this.listOptions);
            Assert.NotNull(events);
            Assert.Equal("list", events.Object);
            Assert.Single(events.Data);
            Assert.Equal("event", events.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var events = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(events);
            Assert.Equal("list", events.Object);
            Assert.Single(events.Data);
            Assert.Equal("event", events.Data[0].Object);
        }
    }
}
