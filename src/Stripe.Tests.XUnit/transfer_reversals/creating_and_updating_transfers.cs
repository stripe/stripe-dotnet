using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_transfer_reversals : IClassFixture<transfer_reversals_fixture>
    {
        private readonly transfer_reversals_fixture fixture;

        public creating_and_updating_transfer_reversals(transfer_reversals_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.TransferReversal.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_id()
        {
            fixture.TransferReversal.Id.Should().StartWith("trr_");
        }

        [Fact]
        public void created_has_the_right_transfer_id()
        {
            fixture.TransferReversal.TransferId.Should().Be(fixture.Transfer.Id);
        }

        [Fact]
        public void created_has_the_right_amount()
        {
            fixture.TransferReversal.Amount.Should().Be(fixture.TransferReversalCreateOptions.Amount);
            fixture.Transfer.AmountReversed.Should().Be(fixture.TransferReversalCreateOptions.Amount);
        }

        [Fact]
        public void created_has_transfer_reversed()
        {
            fixture.Transfer.Reversed.Should().BeTrue();
            fixture.Transfer.Reversals.Data.Count.Should().BeGreaterOrEqualTo(1);
        }

        [Fact]
        public void get_is_not_null()
        {
            fixture.TransferReversalRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void get_has_the_same_id()
        {
            fixture.TransferReversalRetrieved.Id.Should().Be(fixture.TransferReversal.Id);
        }

        [Fact]
        public void updated_has_the_right_metadata()
        {
            fixture.TransferReversalUpdated.Metadata.Keys.Should().BeEquivalentTo(fixture.TransferReversalUpdated.Metadata.Keys);
        }

        [Fact]
        public void list_has_atleast_one_item()
        {
            fixture.TransferReversalList.Count.Should().BeGreaterOrEqualTo(1);
        }
    }
}
