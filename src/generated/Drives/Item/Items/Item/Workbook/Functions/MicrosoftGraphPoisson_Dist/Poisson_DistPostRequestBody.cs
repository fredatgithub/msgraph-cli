using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphPoisson_Dist {
    public class Poisson_DistPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cumulative property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cumulative { get; set; }
#nullable restore
#else
        public Json Cumulative { get; set; }
#endif
        /// <summary>The mean property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Mean { get; set; }
#nullable restore
#else
        public Json Mean { get; set; }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? X { get; set; }
#nullable restore
#else
        public Json X { get; set; }
#endif
        /// <summary>
        /// Instantiates a new poisson_DistPostRequestBody and sets the default values.
        /// </summary>
        public Poisson_DistPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Poisson_DistPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Poisson_DistPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cumulative", n => { Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"mean", n => { Mean = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", n => { X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("mean", Mean);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
