using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_country_spec
    {
        protected static StripeCountrySpec StripeCountrySpec;

        private static StripeCountrySpecsService _stripeCountrySpecsService;

        Establish context = () =>
        {
            _stripeCountrySpecsService = new StripeCountrySpecsService();
        };

        Because of = () =>
            StripeCountrySpec = _stripeCountrySpecsService.Get("US");

        It should_have_verification_field_with_individual_company = () =>
                StripeCountrySpec.VerificationFields.ShouldContain("individual", "company");

        It should_have_default_currency = () =>
                StripeCountrySpec.DefaultCurrency.ShouldNotBeEmpty();

        It should_have_supported_bank_currencies = () =>
                StripeCountrySpec.SupportedBankAccountCurrencies.ShouldNotBeEmpty();

        It should_have_supported_payment_currencies = () =>
                StripeCountrySpec.SupportedPaymentCurrencies.ShouldNotBeEmpty();

        It should_have_supported_payment_methods = () =>
                StripeCountrySpec.SupportedPaymentMethods.ShouldNotBeEmpty();

        It should_have_verification_field_individual_with_minimum_additional = () =>
                StripeCountrySpec.VerificationFields["individual"].ShouldContain("minimum", "additional");

        It should_have_verification_field_company_with_minimum_additional = () =>
                StripeCountrySpec.VerificationFields["company"].ShouldContain("minimum", "additional");
    }
}