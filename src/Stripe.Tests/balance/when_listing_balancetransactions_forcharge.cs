using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.balance
{
	public class when_listing_balancetransactions_forcharge
	{
		private static List<StripeBalanceTransaction> _stripeBalanceTransactionList;
		private static StripeBalanceService _stripeBalanceService;
		private static StripeBalanceTransactionListOptions _stripeBalanceTransactionListOptions;
		private static StripeCharge _stripeCharge;
		private static StripeChargeService _stripeChargeService;

		Establish context = () =>
		{
			// Balance Transactions are created by anything affecting the balance in Stripe, such as adding a charge
			_stripeChargeService = new StripeChargeService();
			_stripeBalanceService = new StripeBalanceService();

			_stripeCharge = _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
			_stripeBalanceTransactionListOptions = new StripeBalanceTransactionListOptions
			{
				SourceId = _stripeCharge.Id,
				Type = "charge"
			};
		};

		Because of = () =>
			_stripeBalanceTransactionList = _stripeBalanceService.List(_stripeBalanceTransactionListOptions).ToList();

		It should_have_only_one_entry = () =>
			_stripeBalanceTransactionList.Count.ShouldEqual(1);
		It should_match_charge_id = () =>
			_stripeBalanceTransactionList.Single().Source.ShouldEqual(_stripeCharge.Id);
		It should_match_charge_type = () =>
			_stripeBalanceTransactionList.Single().Type.ShouldEqual("charge");
		It should_contain_one_fee = () =>
			_stripeBalanceTransactionList.Single().FeeDetails.Count().ShouldEqual(1);
	}
}
