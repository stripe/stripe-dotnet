using Machine.Specifications;

namespace Stripe.Tests
{
	[Behaviors]
	public class recipient_behaviors
	{
		protected static StripeRecipientCreateOptions StripeRecipientCreateOptions;
		protected static StripeRecipient StripeRecipient;
		protected static BankAccountOptions BankAccountOptions;
		protected static StripeRecipientAccount StripeRecipientAccount;

		It should_have_a_new_id = () =>
			StripeRecipient.Id.ShouldNotBeNull();

		It should_have_the_correct_email = () =>
			StripeRecipient.Email.ShouldEqual(StripeRecipientCreateOptions.Email);

		It should_have_the_correct_description = () =>
			StripeRecipient.Description.ShouldEqual(StripeRecipientCreateOptions.Description);

		It should_have_the_correct_livemode = () =>
			StripeRecipient.LiveMode.ShouldEqual(false);

		It should_have_the_correct_bank_name = () =>
			StripeRecipient.ActiveAccount.BankName.ShouldEqual(StripeRecipientAccount.BankName);

		It should_have_the_correct_country = () =>
			StripeRecipient.ActiveAccount.Country.ShouldEqual(StripeRecipientAccount.Country);

		It should_have_the_correct_currency = () =>
			StripeRecipient.ActiveAccount.Currency.ShouldEqual(StripeRecipientAccount.Currency);

		It should_have_the_correct_last_4 = () =>
			StripeRecipient.ActiveAccount.LastFour.ShouldEqual(StripeRecipientAccount.LastFour);

		It should_have_the_correct_fingerprint = () =>
			StripeRecipient.ActiveAccount.Fingerprint.ShouldEqual(StripeRecipientAccount.Fingerprint);

		It should_have_the_correct_validated_value = () =>
			StripeRecipient.ActiveAccount.Validated.ShouldEqual(StripeRecipientAccount.Validated);

		It should_have_the_correct_verified_value = () =>
			StripeRecipient.ActiveAccount.Verified.ShouldEqual(StripeRecipientAccount.Verified);

		It should_have_the_correct_bank_account_country = () =>
			StripeRecipient.BankAccountOptions.Country.ShouldEqual(BankAccountOptions.Country);

		It should_have_the_correct_routing_number = () =>
			StripeRecipient.BankAccountOptions.RoutingNumber.ShouldEqual(BankAccountOptions.RoutingNumber);

		It should_have_the_correct_account_number = () =>
			StripeRecipient.BankAccountOptions.AccountNumber.ShouldEqual(BankAccountOptions.AccountNumber);
	}
}
