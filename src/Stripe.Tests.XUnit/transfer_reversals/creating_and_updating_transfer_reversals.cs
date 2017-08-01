using FluentAssertions;
using System.Collections.Generic;
using System;
using System.Linq;
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
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeTransferReversal> enumerable = fixture.TransferReversalList as IEnumerable<StripeTransferReversal>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(fixture.TransferReversalList.ToList().Count > 0, true);
            Assert.Equal(fixture.TransferReversalList.ToList().Count, count);

        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in fixture.TransferReversalList.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeTransferReversal> enumerable = fixture.TransferReversalList as IEnumerable<StripeTransferReversal>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(fixture.TransferReversalList.Object);
            Assert.Equal(fixture.TransferReversalList.Object, "list");
            Assert.NotNull(fixture.TransferReversalList.Data);
            Assert.NotNull(fixture.TransferReversalList.Url);
        }
    }
}
