using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Stripe.Infrastructure;

namespace Stripe.Tests.infrastructure
{
	public class when_deserializing_expandable_objects
	{
		private const string id = "xx_abcdefg";
		private static string TestDataWithId;
		private static string TestDataWithObject;

		private static StripeCharge _itemWithId;
		private static StripeCharge _itemWithObject;

		Establish context = () =>
		{
			TestDataWithId = String.Format("{{ 'customer': '{0}' }}", id);
			TestDataWithObject = String.Format("{{ 'customer': {{ id: '{0}' }} }}", id);
		};

		Because of = () =>
		{
			_itemWithId = Mapper<StripeCharge>.MapFromJson(TestDataWithId);
			_itemWithObject = Mapper<StripeCharge>.MapFromJson(TestDataWithObject);
		};

		It should_have_id_set_on_iditem = () =>
			_itemWithId.CustomerId.ShouldEqual(id);

		It should_have_object_null_on_iditem = () =>
			_itemWithId.Customer.ShouldBeNull();

		It should_have_id_set_on_objectitem = () =>
			_itemWithObject.CustomerId.ShouldEqual(id);

		It should_have_object_objectitem = () =>
			_itemWithObject.Customer.ShouldNotBeNull();
	}
}
