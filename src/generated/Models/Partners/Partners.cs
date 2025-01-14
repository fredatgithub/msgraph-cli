// <auto-generated/>
using ApiSdk.Models.Partners.Billing;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Partners {
    public class Partners : ApiSdk.Models.Entity, IParsable {
        /// <summary>Represents billing details for billed and unbilled data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Partners.Billing.Billing? Billing { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Partners.Billing.Billing Billing { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="Partners"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Partners CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Partners();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"billing", n => { Billing = n.GetObjectValue<ApiSdk.Models.Partners.Billing.Billing>(ApiSdk.Models.Partners.Billing.Billing.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Partners.Billing.Billing>("billing", Billing);
        }
    }
}
