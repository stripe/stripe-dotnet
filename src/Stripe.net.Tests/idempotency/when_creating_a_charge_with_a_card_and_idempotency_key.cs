using System;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_an_idempotency_key
    {
        private static StripeCharge _stripeChargeOne;
        private static StripeCharge _stripeChargeTwo;
        private static StripeCharge _stripeChargeThree;

        Because of = () =>
        {
            var idempotencyKey = Guid.NewGuid().ToString();

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

            var stripeChargeService = new StripeChargeService();
            var chargeOptions = test_data.stripe_charge_create_options.ValidCustomer(stripeCustomer.Id);

            _stripeChargeOne = stripeChargeService.Create(chargeOptions, new StripeRequestOptions() { IdempotencyKey =  idempotencyKey });
            Thread.Sleep(2000);

            _stripeChargeTwo = stripeChargeService.Create(chargeOptions);
            Thread.Sleep(2000);

            _stripeChargeThree = stripeChargeService.Create(chargeOptions, new StripeRequestOptions() { IdempotencyKey = idempotencyKey });
        };

        It should_not_have_created_a_new_charge_with_the_same_idempotencykey = () =>
            _stripeChargeOne.Created.ShouldEqual(_stripeChargeThree.Created);

        It should_have_created_a_new_charge_without_the_idempotency_key = () =>
            _stripeChargeOne.Created.ShouldNotEqual(_stripeChargeTwo.Created);
    }
}