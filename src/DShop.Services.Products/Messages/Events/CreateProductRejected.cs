using System;
using DShop.Common.Messages;
using Newtonsoft.Json;

namespace DShop.Services.Products.Messages.Events
{
    public class CreateProductRejected : IRejectedEvent
    {
        public Guid Id { get; }
        public string Reason { get; }
        public string Code { get; }

        [JsonConstructor]
        public CreateProductRejected(Guid id, string reason, string code)
        {
            Id = id;
            Reason = reason;
            Code = code;
        }
    }
}