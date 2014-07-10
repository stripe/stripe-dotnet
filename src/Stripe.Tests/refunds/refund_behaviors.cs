using System;
using Machine.Specifications;

namespace Stripe.Tests
{
	[Behaviors]
	public class refund_behaviors
	{
        protected static StripeRefundCreateOptions StripeRefundCreateOptions;
        protected static StripeRefund StripeRefund;
		protected static StripeCharge StripeCharge;

		It should_have_an_id = () =>
			StripeRefund.Id.ShouldNotBeNull();

		It should_have_the_correct_amount = () => 
        {
            if (StripeRefundCreateOptions.Amount != null)
			    StripeRefund.Amount.ShouldEqual(StripeRefundCreateOptions.Amount.Value);
            else
                StripeRefund.Amount.ShouldEqual(StripeCharge.Amount.Value);
        };
        
		It should_have_the_correct_created_date = () =>
			StripeRefund.Created.Day.ShouldEqual(DateTime.UtcNow.Day);

		It should_have_the_correct_currency = () =>
			StripeRefund.Currency.ShouldEqual(StripeCharge.Currency);

        It should_have_the_correct_charge_id = () =>
			StripeRefund.Charge.Id.ShouldEqual(StripeCharge.Id);

        It should_have_the_correct_refuneded_amount = () =>
            StripeRefund.Amount.ShouldEqual((int)StripeCharge.AmountRefunded);

        It should_have_metadata = () =>
            StripeRefund.Metadata.ShouldNotBeNull();

        It should_have_the_correct_metadata = () =>
            StripeRefund.Metadata.ShouldContainOnly(StripeRefundCreateOptions.Metadata);
	}
}