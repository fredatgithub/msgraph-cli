using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Binding;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Identity.B2xUserFlows.Item.UserAttributeAssignments.Item.UserAttribute.Ref {
    /// <summary>Builds and executes requests for operations under \identity\b2xUserFlows\{b2xIdentityUserFlow-id}\userAttributeAssignments\{identityUserFlowAttributeAssignment-id}\userAttribute\$ref</summary>
    public class RefRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The user attribute that you want to add to your user flow.";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "key: id of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var identityUserFlowAttributeAssignmentIdOption = new Option<string>("--identity-user-flow-attribute-assignment-id", description: "key: id of identityUserFlowAttributeAssignment") {
            };
            identityUserFlowAttributeAssignmentIdOption.IsRequired = true;
            command.AddOption(identityUserFlowAttributeAssignmentIdOption);
            command.SetHandler(async (object[] parameters) => {
                var b2xIdentityUserFlowId = (string) parameters[0];
                var identityUserFlowAttributeAssignmentId = (string) parameters[1];
                var cancellationToken = (CancellationToken) parameters[2];
                PathParameters.Clear();
                PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                PathParameters.Add("identityUserFlowAttributeAssignment_id", identityUserFlowAttributeAssignmentId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(b2xIdentityUserFlowIdOption, identityUserFlowAttributeAssignmentIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The user attribute that you want to add to your user flow.";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "key: id of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var identityUserFlowAttributeAssignmentIdOption = new Option<string>("--identity-user-flow-attribute-assignment-id", description: "key: id of identityUserFlowAttributeAssignment") {
            };
            identityUserFlowAttributeAssignmentIdOption.IsRequired = true;
            command.AddOption(identityUserFlowAttributeAssignmentIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (object[] parameters) => {
                var b2xIdentityUserFlowId = (string) parameters[0];
                var identityUserFlowAttributeAssignmentId = (string) parameters[1];
                var output = (FormatterType) parameters[2];
                var query = (string) parameters[3];
                var jsonNoIndent = (bool) parameters[4];
                var outputFilter = (IOutputFilter) parameters[5];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[6];
                var cancellationToken = (CancellationToken) parameters[7];
                PathParameters.Clear();
                PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                PathParameters.Add("identityUserFlowAttributeAssignment_id", identityUserFlowAttributeAssignmentId);
                var requestInfo = CreateGetRequestInformation(q => {
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                var formatter = outputFormatterFactory.GetFormatter(output);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(b2xIdentityUserFlowIdOption, identityUserFlowAttributeAssignmentIdOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "The user attribute that you want to add to your user flow.";
            // Create options for all the parameters
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "key: id of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
            var identityUserFlowAttributeAssignmentIdOption = new Option<string>("--identity-user-flow-attribute-assignment-id", description: "key: id of identityUserFlowAttributeAssignment") {
            };
            identityUserFlowAttributeAssignmentIdOption.IsRequired = true;
            command.AddOption(identityUserFlowAttributeAssignmentIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var b2xIdentityUserFlowId = (string) parameters[0];
                var identityUserFlowAttributeAssignmentId = (string) parameters[1];
                var body = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                PathParameters.Add("identityUserFlowAttributeAssignment_id", identityUserFlowAttributeAssignmentId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Ref>(Ref.CreateFromDiscriminatorValue);
                var requestInfo = CreatePutRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(b2xIdentityUserFlowIdOption, identityUserFlowAttributeAssignmentIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new RefRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RefRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow_id}/userAttributeAssignments/{identityUserFlowAttributeAssignment_id}/userAttribute/$ref";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(Ref body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
    }
}