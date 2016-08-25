using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_country_spec
    {
        protected static CountrySpec CountrySpec;

        private static StripeCountrySpecService _stripeCountrySpecService;

        Establish context = () =>
        {
            _stripeCountrySpecService = new StripeCountrySpecService();
        };

        Because of = () =>
            CountrySpec = _stripeCountrySpecService.Get("US");

        It should_have_verification_field_with_individual_company = () =>
                CountrySpec.VerificationFields.ShouldContain("individual", "company");

        It should_have_default_currency = () =>
                CountrySpec.DefaultCurrency.ShouldNotBeEmpty();

        It should_have_supported_bank_currencies = () =>
                CountrySpec.SupportedBankAccountCurrencies.ShouldNotBeEmpty();

        It should_have_supported_payment_currencies = () =>
                CountrySpec.SupportedPaymentCurrencies.ShouldNotBeEmpty();

        It should_have_supported_payment_methods = () =>
                CountrySpec.SupportedPaymentMethods.ShouldNotBeEmpty();

        It should_have_verification_field_individual_with_minimum_additional = () =>
                CountrySpec.VerificationFields["individual"].ShouldContain("minimum", "additional");

        It should_have_verification_field_company_with_minimum_additional = () =>
                CountrySpec.VerificationFields["company"].ShouldContain("minimum", "additional");
    }
}