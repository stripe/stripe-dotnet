using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_creating_an_invoice_with_failed_charge
	{
		private static StripeInvoice _stripeCreatedInvoice;
		private static StripeInvoice _stripeFailedInvoice;
		private static StripeInvoiceService _stripeInvoiceService;
		private static StripeCharge _stripeCharge;
        private static StripeException _stripeException;

		Establish context = () =>
		{
			var stripeCustomerService = new StripeCustomerService();
			var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCardButChargeFails();
			var stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

			var stripeInvoiceItemService = new StripeInvoiceItemService();
			var stripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id);
			stripeInvoiceItemService.Create(stripeInvoiceItemCreateOptions);

			_stripeInvoiceService = new StripeInvoiceService();
			_stripeCreatedInvoice = _stripeInvoiceService.Create(stripeCustomer.Id);
		};

		Because of = () =>
		{
            // API 2013-02-11 changed behaviour to throw exception instead of just set paid to false
            _stripeException = Catch.Exception(() => _stripeInvoiceService.Pay(_stripeCreatedInvoice.Id)) as StripeException;

			_stripeFailedInvoice = _stripeInvoiceService.Get(_stripeCreatedInvoice.Id);

			var stripeChargeService = new StripeChargeService();
			_stripeCharge = stripeChargeService.Get(_stripeFailedInvoice.ChargeId);
		};

        It should_have_thrown_an_exception = () =>
            _stripeException.ShouldNotBeNull();
        
        It should_have_the_correct_id = () =>
			_stripeFailedInvoice.Id.ShouldEqual(_stripeCreatedInvoice.Id);

		It should_have_a_declined_failure_message = () =>
			_stripeCharge.FailureMessage.ShouldBeEqualIgnoringCase("Your card was declined.");

		It should_have_a_declined_failure_code = () =>
			_stripeCharge.FailureCode.ShouldBeEqualIgnoringCase("card_declined");
	}
}
