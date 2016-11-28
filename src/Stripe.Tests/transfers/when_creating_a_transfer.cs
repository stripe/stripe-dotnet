using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_transfer
    {
        protected static StripeTransferCreateOptions StripeTransferCreateOptions;
        protected static StripeTransfer StripeTransfer;

        private static StripeTransferService _stripeTransferService;

        Establish context = () =>
        {
            var accountOptions = test_data.stripe_account_create_options.ValidAccountWithCard();
            accountOptions.Managed = true;

            var account = new StripeAccountService().Create(accountOptions);

            _stripeTransferService = new StripeTransferService();
            StripeTransferCreateOptions = test_data.stripe_transfer_create_options.ValidForDestination(account.Id);
        };

        Because of = () =>
        {
            StripeTransfer = _stripeTransferService.Create(StripeTransferCreateOptions);
        };

        Behaves_like<transfer_behaviors> behaviors;

        It should_have_the_right_destination = () =>
            StripeTransfer.Destination.ShouldEqual(StripeTransferCreateOptions.Destination);
    }
}