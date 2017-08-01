using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_transfers : IClassFixture<transfers_fixture>
    {
        private readonly transfers_fixture fixture;

        public creating_and_updating_transfers(transfers_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Transfer.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_id()
        {
            fixture.Transfer.Id.Should().StartWith("tr_");
        }

        [Fact]
        public void created_has_right_source_transaction()
        {
            fixture.Transfer.SourceTransactionId.Should().Be(fixture.Charge.Id);
        }

        [Fact]
        public void created_has_the_right_amount()
        {
            fixture.Transfer.Amount.Should().Be(fixture.TransferCreateOptions.Amount);
        }

        [Fact]
        public void get_is_not_null()
        {
            fixture.TransferRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void get_has_the_same_id()
        {
            fixture.TransferRetrieved.Id.Should().Be(fixture.Transfer.Id);
        }

        [Fact]
        public void updated_has_the_right_metadata()
        {
            fixture.TransferUpdated.Metadata.Keys.Should().BeEquivalentTo(fixture.TransferUpdated.Metadata.Keys);
        }

        [Fact]
        public void list_has_atleast_one_item()
        {
            fixture.TransferList.Count.Should().BeGreaterOrEqualTo(1);
        }
    }
}
