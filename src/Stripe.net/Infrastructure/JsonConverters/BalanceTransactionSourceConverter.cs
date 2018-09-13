namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class BalanceTransactionSourceConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);

            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var incoming = JObject.Load(reader);

            var source = new BalanceTransactionSource
            {
                Id = incoming.SelectToken("id").ToString()
            };

            if (incoming.SelectToken("object")?.ToString() == "application_fee")
            {
                source.Type = BalanceTransactionSourceType.ApplicationFee;
                source.ApplicationFee = Mapper<ApplicationFee>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "charge")
            {
                source.Type = BalanceTransactionSourceType.Charge;
                source.Charge = Mapper<Charge>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "dispute")
            {
                source.Type = BalanceTransactionSourceType.Dispute;
                source.Dispute = Mapper<StripeDispute>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "issuing.authorization")
            {
                source.Type = BalanceTransactionSourceType.IssuingAuthorization;
                source.IssuingAuthorization = Mapper<Issuing.Authorization>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "issuing.transaction")
            {
                source.Type = BalanceTransactionSourceType.IssuingTransaction;
                source.IssuingTransaction = Mapper<Issuing.Transaction>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "payout")
            {
                source.Type = BalanceTransactionSourceType.Payout;
                source.Payout = Mapper<Payout>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "refund")
            {
                source.Type = BalanceTransactionSourceType.Refund;
                source.Refund = Mapper<Refund>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "topup")
            {
                source.Type = BalanceTransactionSourceType.Topup;
                source.Topup = Mapper<Topup>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "transfer")
            {
                source.Type = BalanceTransactionSourceType.Transfer;
                source.Transfer = Mapper<Transfer>.MapFromJson(incoming.ToString());
            }
            else if (incoming.SelectToken("object")?.ToString() == "transfer_reversal")
            {
                source.Type = BalanceTransactionSourceType.TransferReversal;
                source.TransferReversal = Mapper<TransferReversal>.MapFromJson(incoming.ToString());
            }
            else
            {
                source.Type = BalanceTransactionSourceType.Unknown;
            }

            return source;
        }
    }
}