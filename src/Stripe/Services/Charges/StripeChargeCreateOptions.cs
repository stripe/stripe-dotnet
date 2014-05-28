using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeChargeCreateOptions : CreditCardOptions
	{
		private string _statementDescription;
		
		private const int StatementDescriptionMaxLength = 15;
		
		[JsonProperty("amount")]
		public int? Amount { get; set; }

		[JsonProperty("application_fee")]
		public int? ApplicationFee { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("capture")]
		public bool? Capture { get; set; }

		[JsonProperty("card")]
		public string Card { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }

		[JsonProperty("statement_description")]
		public string StatementDescription {
			get { return _statementDescription; }
			set
			{
				if (value == null)
				{
					_statementDescription = value;
				}
				else if (value.Length > StatementDescriptionMaxLength)
				{
					_statementDescription = value.Substring(0, (StatementDescriptionMaxLength - 3));
					_statementDescription = result + "...";
				}
				else
				{
					_statementDescription = value;
				}
			}
		}
	}
}
