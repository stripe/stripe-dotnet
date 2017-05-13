using System;
using System.Collections.Generic;
using System.Linq;

namespace Stripe.Tests.Xunit
{
    public class transfers_fixture
    {
        public StripeTransferCreateOptions TransferCreateOptions { get; }
        public StripeTransferUpdateOptions TransferUpdateOptions { get; }
        public StripeTransferListOptions TransferListOptions { get; }

        public StripeTransfer Transfer { get; }
        public StripeTransfer TransferUpdated { get; }
        public StripeTransfer TransferRetrieved { get; }
        public List<StripeTransfer> TransferList { get; }

        public transfers_fixture()
        {
            // make sure the account has sufficient funds first
            new StripeChargeService(Cache.ApiKey).Create(new StripeChargeCreateOptions
            {
                Amount = 10000,
                Currency = "usd",
                SourceCard = new SourceCard
                {
                    Number = "4000000000000077",
                    ExpirationMonth = 10,
                    ExpirationYear = 2019,
                    Cvc = "123"
                },
                TransferGroup = $"test_group_{ Guid.NewGuid() }"
            });

            TransferCreateOptions = new StripeTransferCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                Destination = Cache.GetAccount().Id,
                TransferGroup = $"test_group_{ Guid.NewGuid() }"
            };

            TransferUpdateOptions = new StripeTransferUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "some-key", "some-value" }
                }
            };

            var service = new StripeTransferService(Cache.ApiKey);
            Transfer = service.Create(TransferCreateOptions);
            TransferUpdated = service.Update(Transfer.Id, TransferUpdateOptions);
            TransferRetrieved = service.Get(Transfer.Id);

            TransferListOptions = new StripeTransferListOptions
            {
                Created = new StripeDateFilter { EqualTo = Transfer.Created }
            };

            TransferList = service.List(TransferListOptions).ToList();
        }
    }
}
