using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_requesting_something_from_stripe
    {
        private static StripeCharge _stripeChargeSync;
        private static StripeCharge _stripeChargeAsync;
        private static StripeList<StripeCharge> _stripeChargesSyncList;
        private static StripeList<StripeCharge> _stripeChargesAsyncList;

        private static string _listIdentifier = "\"url\": \"/v1/charges\"";

        Establish context = () =>
        {
            // create some charges and store them for the tests to assert - sync and async to cover both cases 
            // no context is really needed here, since we aren't doing anything new. we just want to make sure 
            // the StripeResponse is attached to the entities

            // the list are not always populated as individual items as part of StripeList<T>, so that code was 
            // commented out. fix this if it's a problem. the StripeResponse is still on the StripeList<T>
        };

        Because of = () =>
        {
            _stripeChargeSync = new StripeChargeService().Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeAsync = new StripeChargeService().CreateAsync(test_data.stripe_charge_create_options.ValidCard()).Result;

            _stripeChargesSyncList = new StripeChargeService().List(test_data.stripe_charge_list_options.ChargesSinceYesterday());
            _stripeChargesAsyncList = new StripeChargeService().ListAsync(test_data.stripe_charge_list_options.ChargesSinceYesterday()).Result;
        };

        It should_have_the_right_request_id = () =>
        {
            _stripeChargeSync.StripeResponse.RequestId.ShouldStartWith("req_");
            _stripeChargeAsync.StripeResponse.RequestId.ShouldStartWith("req_");

            //_stripeChargesSyncList.Data.First().StripeResponse.RequestId.ShouldStartWith("req_");
            //_stripeChargesAsyncList.Data.First().StripeResponse.RequestId.ShouldStartWith("req_");
        };

        It should_have_a_recent_request_datetime = () =>
        {
            _stripeChargeSync.StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);
            _stripeChargeAsync.StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);

            //_stripeChargesSyncList.Data.First().StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);
            //_stripeChargesAsyncList.Data.First().StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);
        };

        //It should_not_have_a_data_array_in_the_object_json_for_the_single_entities = () =>
        //{
        //    _stripeChargesSyncList.Data.First().StripeResponse.ObjectJson.ShouldNotContain(_listIdentifier);
        //    _stripeChargesAsyncList.Data.First().StripeResponse.ObjectJson.ShouldNotContain(_listIdentifier);
        //};

        //It should_not_have_list_json_in_the_object_json_for_the_lists = () =>
        //{
        //    _stripeChargesSyncList.Data.First().StripeResponse.ObjectJson.ShouldNotContain(_listIdentifier);
        //    _stripeChargesAsyncList.Data.First().StripeResponse.ObjectJson.ShouldNotContain(_listIdentifier);
        //};

        //It should_have_list_json_in_the_response_json_for_the_charges_on_the_list = () =>
        //{
        //    _stripeChargesSyncList.Data.First().StripeResponse.ResponseJson.ShouldContain(_listIdentifier);
        //    _stripeChargesAsyncList.Data.First().StripeResponse.ResponseJson.ShouldContain(_listIdentifier);
        //};

        It should_have_matching_object_and_response_json_for_the_single_entities = () =>
        {
            _stripeChargeSync.StripeResponse.ObjectJson.ShouldEqual(_stripeChargeSync.StripeResponse.ResponseJson);
            _stripeChargeAsync.StripeResponse.ObjectJson.ShouldEqual(_stripeChargeAsync.StripeResponse.ResponseJson);
        };
    }
}
