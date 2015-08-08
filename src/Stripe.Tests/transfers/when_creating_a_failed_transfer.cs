using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_failed_transfer
    {
        private static StripeTransferService _stripeTransferService;
        private static StripeTransfer _failedTransfer;
        private static StripeTransferReversal _failedTransferReversal;
        private static string _recipientId;

        Establish context = () =>
        {
            _stripeTransferService = new StripeTransferService();

            var stripeRecipientService = new StripeRecipientService();

            var recipient = stripeRecipientService.Create(test_data.stripe_recipient_create_options.TransferFailCorporation());
            _recipientId = recipient.Id;

            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid(_recipientId));
        };

        Because of = () =>
        {
            var stripeTransferList = _stripeTransferService.List().ToList();
            _failedTransfer = stripeTransferList.Single(t => t.RecipientId == _recipientId && t.Status == "failed");
            _failedTransferReversal = _failedTransfer.StripeTransferReversalList.Data.Single();
        };

        It should_contain_a_failed_transfer_that_is_reversed = () =>
            _failedTransfer.Reversed.ShouldEqual(true);

        It should_contain_a_failed_transfer_that_has_amount_reversed_set = () =>
            _failedTransfer.AmountReversed.ShouldEqual(test_data.stripe_transfer_create_options.Valid(_recipientId).Amount);

        It should_contain_a_failed_transfer_that_has_reversal_amount = () =>
            _failedTransferReversal.Amount.ShouldEqual(test_data.stripe_transfer_create_options.Valid(_recipientId).Amount);
    }
}
