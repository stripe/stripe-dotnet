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
        public void created_has_the_number_of_associated_objects()
        {
            fixture.EphemeralKey.AssociatedObjects.Count().Should().Be(1);
        }

        [Fact]
        public void created_has_the_right_customer_id()
        {
            fixture.EphemeralKey.AssociatedObjects.First().Id.Should().Be(fixture.EphemeralKeyCreateOptions.CustomerId);
        }

        [Fact]
        public void created_has_the_right_livemode()
        {
            fixture.EphemeralKey.LiveMode.Should().Be(false);
        }

        [Fact]
        public void created_has_the_response_json()
        {
            fixture.EphemeralKey.RawJson.Should().NotBeNull();
        }
    }
}
