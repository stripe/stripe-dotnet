using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_deleting_ephemeral_keys : IClassFixture<ephemeral_keys_fixture>
    {
        private readonly ephemeral_keys_fixture fixture;

        public creating_and_deleting_ephemeral_keys(ephemeral_keys_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_has_the_right_customer_id()
        {
            fixture.EphemeralKey.AssociatedObjects.Count().Should().Be(1);
        }
    }
}
