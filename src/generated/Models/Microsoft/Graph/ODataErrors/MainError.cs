using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ODataErrors {
    public class MainError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Code { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.ODataErrors.ErrorDetails> Details { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ODataErrors.InnerError Innererror { get; set; }
        public string Message { get; set; }
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new MainError and sets the default values.
        /// </summary>
        public MainError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ODataErrors.MainError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MainError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as MainError).Code = n.GetStringValue(); } },
                {"details", (o,n) => { (o as MainError).Details = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ODataErrors.ErrorDetails>(ApiSdk.Models.Microsoft.Graph.ODataErrors.ErrorDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"innererror", (o,n) => { (o as MainError).Innererror = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ODataErrors.InnerError>(ApiSdk.Models.Microsoft.Graph.ODataErrors.InnerError.CreateFromDiscriminatorValue); } },
                {"message", (o,n) => { (o as MainError).Message = n.GetStringValue(); } },
                {"target", (o,n) => { (o as MainError).Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ODataErrors.ErrorDetails>("details", Details);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ODataErrors.InnerError>("innererror", Innererror);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}