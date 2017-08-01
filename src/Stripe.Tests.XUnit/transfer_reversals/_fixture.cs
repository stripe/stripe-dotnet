using System.Collections.Generic;
using System.Linq;

namespace Stripe.Tests.Xunit
{
    public class transfer_reversals_fixture
    {
        public StripeTransferReversalCreateOptions TransferReversalCreateOptions { get; }
        public StripeTransferReversalUpdateOptions TransferReversalUpdateOptions { get; }
        public StripeListOptions TransferReversalListOptions { get; }

        public StripeTransfer Transfer { get; }
        public StripeTransferReversal TransferReversal { get; }
        public StripeTransferReversal TransferReversalUpdated { get; }
        public StripeTransferReversal TransferReversalRetrieved { get; }
        public StripeList<StripeTransferReversal> TransferReversalList { get; }

        public transfer_reversals_fixture()
        {
            // make sure the account has sufficient funds first
            new StripeChargeService(Cache.ApiKey).Create(new StripeChargeCreateOptions
            {
                Amount = 10000,
                Currency = "usd",
                SourceTokenOrExistingSourceId = "tok_bypassPending"
            });

            // create transfer to be reversed
            Transfer = new StripeTransferService(Cache.ApiKey).Create(new StripeTransferCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                Destination = Cache.GetAccount().Id
            });

            TransferReversalCreateOptions = new StripeTransferReversalCreateOptions
            {
                Amount = 1000,
                Description = "Transfer reversed"
            };

            TransferReversalUpdateOptions = new StripeTransferReversalUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "some-key", "some-value" }
                }
            };

            var service = new StripeTransferReversalService(Cache.ApiKey);
            service.ExpandBalanceTransaction = true;
            service.ExpandTransfer = true;

            TransferReversal = service.Create(Transfer.Id, TransferReversalCreateOptions);
            TransferReversalUpdated = service.Update(Transfer.Id, TransferReversal.Id, TransferReversalUpdateOptions);
            TransferReversalRetrieved = service.Get(Transfer.Id, TransferReversal.Id);
            TransferReversalList = service.List(Transfer.Id, new StripeListOptions());

            // get the original transfer
            Transfer = new StripeTransferService(Cache.ApiKey).Get(Transfer.Id);
        }
    }
}
