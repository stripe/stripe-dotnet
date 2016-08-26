using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_country_spec
    {
        private static CountrySpec _countrySpec;
        private static CountrySpecService _countrySpecService;

        Establish context = () =>
        {
            _countrySpecService = new CountrySpecService();
        };

        Because of = () =>
            _countrySpec = _countrySpecService.Get("US");

        It should_have_default_currency = () =>
            _countrySpec.DefaultCurrency.ShouldNotBeEmpty();

        It should_have_supported_bank_currencies = () =>
            _countrySpec.SupportedBankAccountCurrencies.ShouldNotBeEmpty();

        It should_have_supported_payment_currencies = () =>
            _countrySpec.SupportedPaymentCurrencies.ShouldNotBeEmpty();

        It should_have_supported_payment_methods = () =>
            _countrySpec.SupportedPaymentMethods.ShouldNotBeEmpty();

        It should_have_verification_field_individual_with_minimum = () =>
            _countrySpec.VerificationFields["individual"]["minimum"].ShouldNotBeNull();

        It should_have_verification_field_individual_with_additional = () =>
            _countrySpec.VerificationFields["individual"]["additional"].ShouldNotBeNull();

        It should_have_verification_field_company_with_minimum = () =>
            _countrySpec.VerificationFields["company"]["minimum"].ShouldNotBeNull();

        It should_have_verification_field_company_with_additional = () =>
            _countrySpec.VerificationFields["company"]["additional"].ShouldNotBeNull();
    }
}