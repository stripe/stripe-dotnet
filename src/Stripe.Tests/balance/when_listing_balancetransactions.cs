using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.balance
{
	public class when_listing_balancetransactions
	{
		private static List<StripeBalanceTransaction> _stripeBalanceTransactionList;
		private static StripeChargeService _stripeChargeService;
		private static StripeBalanceService _stripeBalanceService;

		Establish context = () =>
		{
			// Balance Transactions are created by anything affecting the balance in Stripe, such as adding a charge
			_stripeChargeService = new StripeChargeService();
			_stripeBalanceService = new StripeBalanceService();

			_stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
			_stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
			_stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
			_stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
		};

		Because of = () =>
			_stripeBalanceTransactionList = _stripeBalanceService.List().ToList();

		It should_have_atleast_4_entries = () =>
			_stripeBalanceTransactionList.Count.ShouldBeGreaterThanOrEqualTo(4);
	}
}
