using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class card_behaviors
    {
        protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
        protected static StripeCustomer StripeCustomer;
        protected static StripePlan StripePlan;
        protected static StripeCoupon StripeCoupon;
        protected static StripeCard StripeCard;
        
        It should_have_a_new_id = () =>
            StripeCustomer.Id.ShouldNotBeNull();

        It should_have_the_correct_email = () =>
            StripeCustomer.Email.ShouldEqual(StripeCustomerCreateOptions.Email);

        It should_have_the_correct_description = () =>
            StripeCustomer.Description.ShouldEqual(StripeCustomerCreateOptions.Description);

        It should_have_the_correct_livemode = () =>
            StripeCustomer.LiveMode.ShouldEqual(false);

        It should_have_an_id = () =>
            StripeCustomer.Sources.Data.First().Id.ShouldNotBeNull();

        It should_have_the_correct_source_address_line_1 = () =>
            StripeCustomer.Sources.Data.First().Card.AddressLine1.ShouldEqual(StripeCard.AddressLine1);

        It should_have_the_correct_source_address_line_2 = () =>
            StripeCustomer.Sources.Data.First().Card.AddressLine2.ShouldEqual(StripeCard.AddressLine2);

        It should_have_the_correct_source_address_state = () =>
            StripeCustomer.Sources.Data.First().Card.AddressState.ShouldEqual(StripeCard.AddressState);

        It should_have_the_correct_source_address_zip = () =>
            StripeCustomer.Sources.Data.First().Card.AddressZip.ShouldEqual(StripeCard.AddressZip);

        It should_have_the_correct_source_last_4 = () =>
            StripeCustomer.Sources.Data.First().Card.Last4.ShouldEqual(StripeCard.Last4.ShouldEqual(StripeCard.Last4));

        It should_have_the_correct_source_expiration_month = () =>
            StripeCustomer.Sources.Data.First().Card.ExpirationMonth.ShouldEqual(StripeCard.ExpirationMonth);

        It should_have_the_correct_source_expiration_year = () =>
            StripeCustomer.Sources.Data.First().Card.ExpirationYear.ShouldEqual(StripeCard.ExpirationYear);

        It should_have_the_correct_source_name = () =>
            StripeCustomer.Sources.Data.First().Card.Name.ShouldEqual(StripeCard.Name);

        It should_have_the_correct_source_type = () =>
            StripeCustomer.Sources.Data.First().Card.Brand.ShouldEqual("Visa");

        It should_have_a_fingerprint = () =>
            StripeCustomer.Sources.Data.First().Card.Fingerprint.ShouldNotBeNull();

        It should_have_the_correct_source_country = () =>
            StripeCustomer.Sources.Data.First().Card.Country.ShouldEqual("US");

        It should_have_the_correct_coupon_id = () =>
            StripeCustomer.StripeDiscount.StripeCoupon.Id.ShouldEqual(StripeCoupon.Id);

        It should_have_the_correct_coupon_percent_off = () =>
            StripeCustomer.StripeDiscount.StripeCoupon.PercentOff.ShouldEqual(StripeCoupon.PercentOff);

        It should_have_the_correct_coupon_duration = () =>
            StripeCustomer.StripeDiscount.StripeCoupon.Duration.ShouldEqual(StripeCoupon.Duration);

        It should_have_the_correct_coupon_duration_in_months = () =>
            StripeCustomer.StripeDiscount.StripeCoupon.DurationInMonths.ShouldEqual(StripeCoupon.DurationInMonths);

        It should_have_the_correct_coupon_max_redemptions = () =>
            StripeCustomer.StripeDiscount.StripeCoupon.MaxRedemptions.ShouldEqual(StripeCoupon.MaxRedemptions);

        It should_have_the_correct_coupon_livemode = () =>
            StripeCustomer.StripeDiscount.StripeCoupon.LiveMode.ShouldEqual(false);
    }
}