using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Machine.Specifications;
using NCrunch.Framework;

namespace Stripe.Tests.charges
{
	[Serial]
	public class when_listing_charges_by_date
	{
		private static StripeChargeService _stripeChargeService;
		
		private static List<StripeCharge> _createdCharges;
		private static List<StripeCharge> _chargeListEquals;
		private static List<StripeCharge> _chargeListGreaterThan;
		private static List<StripeCharge> _chargeListLessThanAndGreaterThan;

		private static StripeDateFilter _equalsFilter;
		private static StripeDateFilter _greaterThanFilter;
		private static StripeDateFilter _lessThanAndGreaterThanFilter;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();

			_createdCharges = new List<StripeCharge>();

			_createdCharges.Add(_stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard()));
			Thread.Sleep(1000);
			_createdCharges.Add(_stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard()));
			Thread.Sleep(1000);
			_createdCharges.Add(_stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard()));

			_equalsFilter = new StripeDateFilter { EqualTo = _createdCharges[0].Created };
			_greaterThanFilter = new StripeDateFilter { GreaterThan = _createdCharges[0].Created };
			_lessThanAndGreaterThanFilter = new StripeDateFilter
			{
				LessThan = _createdCharges[2].Created,
				GreaterThan = _createdCharges[0].Created
			};
		};

		Because of = () =>
		{
			_chargeListEquals = _stripeChargeService.List(new StripeChargeListOptions { Created = _equalsFilter }).ToList();
			_chargeListGreaterThan = _stripeChargeService.List(new StripeChargeListOptions { Created = _greaterThanFilter }).ToList();
			_chargeListLessThanAndGreaterThan = _stripeChargeService.List(new StripeChargeListOptions { Created = _lessThanAndGreaterThanFilter }).ToList();
		};

		It should_only_have_single_element_for_equals = () =>
			_chargeListEquals.Count.ShouldEqual(1);

		It should_only_contain_first_charge_for_equals = () =>
			_chargeListEquals.Single().Id.ShouldEqual(_createdCharges[0].Id);

		It should_contain_two_elements_for_gt = () =>
			_chargeListGreaterThan.Count.ShouldEqual(2);

		It should_not_contain_first_element_for_gt = () =>
			_chargeListGreaterThan.ShouldNotContain(c => c.Id == _createdCharges[0].Id);

		It should_contain_single_elements_for_ltgt = () =>
			_chargeListLessThanAndGreaterThan.Count.ShouldEqual(1);

		It should_contain_second_element_for_gt = () =>
			_chargeListLessThanAndGreaterThan.Single().Id.ShouldEqual(_createdCharges[1].Id);
	}
}
