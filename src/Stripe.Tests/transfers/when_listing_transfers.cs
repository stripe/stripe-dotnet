using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_transfers
    {
        private static List<StripeTransfer> _stripeTransferList;
        private static StripeTransfer _failedTransfer;
        private static StripeTransferReversal _failedTransferReversal;
        private static StripeTransferService _stripeTransferService;
        private static StripeRecipientService _stripeRecipientService;
        private static string _recipientId;

        Establish context = () =>
        {
            _stripeRecipientService = new StripeRecipientService();
            _stripeTransferService = new StripeTransferService();

            var recipient = _stripeRecipientService.Create(test_data.stripe_recipient_create_options.TransferFailCorporation());
            _recipientId = recipient.Id;

            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid(_recipientId));
            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid());
            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid());
        };

        Because of = () =>
        {
            _stripeTransferList = _stripeTransferService.List().ToList();
            _failedTransfer = _stripeTransferList.Single(t => t.RecipientId == _recipientId && t.Status == "failed");
            _failedTransferReversal = _failedTransfer.StripeTransferReversalList.Data.Single();
        };

        It should_have_at_least_one_entry = () =>
            _stripeTransferList.Count.ShouldBeGreaterThanOrEqualTo(3);

        It should_contain_a_failed_transfer_that_is_reversed = () => 
            _failedTransfer.Reversed.ShouldEqual(true);
        
        It should_contain_a_failed_transfer_that_has_amount_reversed_set = () => 
            _failedTransfer.AmountReversed.ShouldEqual(50);

        It should_contain_a_failed_transfer_that_has_reversal_amount = () => 
            _failedTransferReversal.Amount.ShouldEqual(50);
    }
}
