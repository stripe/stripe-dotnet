using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe.Tests.balance
{
    public class when_retrieving_balance
    {
        protected static StripeBalance StripeBalance;

        private static StripeBalanceService _stripeBalanceService;

        Establish context = () =>
        {
            _stripeBalanceService = new StripeBalanceService();
        };

        Because of = () =>
        {
            StripeBalance = _stripeBalanceService.Get();
        };

        Behaves_like<balance_behaviors> behaviors;
    }
}
