﻿using Newtonsoft.Json;
using System;

namespace Stripe
{
	public class StripeEventSearchOptions : StripeListOptions
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("created")]
		public StripeDateFilter Created { get; set; }
	}
}