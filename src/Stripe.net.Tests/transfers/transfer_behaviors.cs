using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class transfer_behaviors
    {
        protected static StripeTransferCreateOptions StripeTransferCreateOptions;
        protected static StripeTransfer StripeTransfer;

        It should_have_a_new_id = () =>
            StripeTransfer.Id.ShouldNotBeNull();

        It should_have_an_object_value_of_transfer = () =>
            StripeTransfer.Object.ShouldEqual("transfer");

        It should_have_the_correct_live_mode = () =>
            StripeTransfer.LiveMode.ShouldEqual(false);

        It should_have_the_correct_amount = () =>
            StripeTransfer.Amount.ShouldEqual(StripeTransferCreateOptions.Amount);

        It should_have_the_correct_currency = () =>
            StripeTransfer.Currency.ShouldEqual(StripeTransferCreateOptions.Currency);

        It should_have_a_valid_date = () =>
            StripeTransfer.Date.ShouldBeLessThanOrEqualTo(DateTime.UtcNow.AddMinutes(1));

        It should_have_a_status_other_than_failed = () =>
            StripeTransfer.Status.ShouldNotEqual("failed");

        It should_have_a_balance_transactionid = () =>
            StripeTransfer.BalanceTransactionId.ShouldNotBeNull();

        It should_have_the_correct_description = () =>
            StripeTransfer.Description.ShouldEqual(StripeTransferCreateOptions.Description);

        It should_have_the_correct_statement_descriptor = () =>
            StripeTransfer.StatementDescriptor.ShouldEqual(StripeTransferCreateOptions.StatementDescriptor);
    }
}
