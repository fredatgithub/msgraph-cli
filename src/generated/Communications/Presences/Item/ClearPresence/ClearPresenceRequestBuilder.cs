using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Communications.Presences.Item.ClearPresence {
    /// <summary>
    /// Provides operations to call the clearPresence method.
    /// </summary>
    public class ClearPresenceRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Clear the application&apos;s presence session for a user. If it is the user&apos;s only presence session, the user&apos;s presence will change to `Offline/Offline`. For details about presences sessions, see presence: setPresence.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/presence-clearpresence?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Clear the application's presence session for a user. If it is the user's only presence session, the user's presence will change to `Offline/Offline`. For details about presences sessions, see presence: setPresence.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/presence-clearpresence?view=graph-rest-1.0";
            var presenceIdOption = new Option<string>("--presence-id", description: "The unique identifier of presence") {
            };
            presenceIdOption.IsRequired = true;
            command.AddOption(presenceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var presenceId = invocationContext.ParseResult.GetValueForOption(presenceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ClearPresencePostRequestBody>(ClearPresencePostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (presenceId is not null) requestInfo.PathParameters.Add("presence%2Did", presenceId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new ClearPresenceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ClearPresenceRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/communications/presences/{presence%2Did}/clearPresence", pathParameters) {
        }
        /// <summary>
        /// Clear the application&apos;s presence session for a user. If it is the user&apos;s only presence session, the user&apos;s presence will change to `Offline/Offline`. For details about presences sessions, see presence: setPresence.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ClearPresencePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ClearPresencePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
    }
}
