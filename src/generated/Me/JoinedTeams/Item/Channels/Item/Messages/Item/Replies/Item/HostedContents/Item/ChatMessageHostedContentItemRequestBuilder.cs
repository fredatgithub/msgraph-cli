using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Models.Microsoft.Graph.ODataErrors;
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
namespace ApiSdk.Me.JoinedTeams.Item.Channels.Item.Messages.Item.Replies.Item.HostedContents.Item {
    /// <summary>Provides operations to manage the hostedContents property of the microsoft.graph.chatMessage entity.</summary>
    public class ChatMessageHostedContentItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property hostedContents for me
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property hostedContents for me";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var channelIdOption = new Option<string>("--channel-id", description: "key: id of channel") {
            };
            channelIdOption.IsRequired = true;
            command.AddOption(channelIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "key: id of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var chatMessageId1Option = new Option<string>("--chat-message-id1", description: "key: id of chatMessage") {
            };
            chatMessageId1Option.IsRequired = true;
            command.AddOption(chatMessageId1Option);
            var chatMessageHostedContentIdOption = new Option<string>("--chat-message-hosted-content-id", description: "key: id of chatMessageHostedContent") {
            };
            chatMessageHostedContentIdOption.IsRequired = true;
            command.AddOption(chatMessageHostedContentIdOption);
            command.SetHandler(async (object[] parameters) => {
                var teamId = (string) parameters[0];
                var channelId = (string) parameters[1];
                var chatMessageId = (string) parameters[2];
                var chatMessageId1 = (string) parameters[3];
                var chatMessageHostedContentId = (string) parameters[4];
                var cancellationToken = (CancellationToken) parameters[5];
                PathParameters.Clear();
                PathParameters.Add("team_id", teamId);
                PathParameters.Add("channel_id", channelId);
                PathParameters.Add("chatMessage_id", chatMessageId);
                PathParameters.Add("chatMessage_id1", chatMessageId1);
                PathParameters.Add("chatMessageHostedContent_id", chatMessageHostedContentId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(teamIdOption, channelIdOption, chatMessageIdOption, chatMessageId1Option, chatMessageHostedContentIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Content in a message hosted by Microsoft Teams - for example, images or code snippets.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Content in a message hosted by Microsoft Teams - for example, images or code snippets.";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var channelIdOption = new Option<string>("--channel-id", description: "key: id of channel") {
            };
            channelIdOption.IsRequired = true;
            command.AddOption(channelIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "key: id of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var chatMessageId1Option = new Option<string>("--chat-message-id1", description: "key: id of chatMessage") {
            };
            chatMessageId1Option.IsRequired = true;
            command.AddOption(chatMessageId1Option);
            var chatMessageHostedContentIdOption = new Option<string>("--chat-message-hosted-content-id", description: "key: id of chatMessageHostedContent") {
            };
            chatMessageHostedContentIdOption.IsRequired = true;
            command.AddOption(chatMessageHostedContentIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
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
                var teamId = (string) parameters[0];
                var channelId = (string) parameters[1];
                var chatMessageId = (string) parameters[2];
                var chatMessageId1 = (string) parameters[3];
                var chatMessageHostedContentId = (string) parameters[4];
                var select = (string[]) parameters[5];
                var expand = (string[]) parameters[6];
                var output = (FormatterType) parameters[7];
                var query = (string) parameters[8];
                var jsonNoIndent = (bool) parameters[9];
                var outputFilter = (IOutputFilter) parameters[10];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[11];
                var cancellationToken = (CancellationToken) parameters[12];
                PathParameters.Clear();
                PathParameters.Add("team_id", teamId);
                PathParameters.Add("channel_id", channelId);
                PathParameters.Add("chatMessage_id", chatMessageId);
                PathParameters.Add("chatMessage_id1", chatMessageId1);
                PathParameters.Add("chatMessageHostedContent_id", chatMessageHostedContentId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(teamIdOption, channelIdOption, chatMessageIdOption, chatMessageId1Option, chatMessageHostedContentIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Update the navigation property hostedContents in me
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property hostedContents in me";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var channelIdOption = new Option<string>("--channel-id", description: "key: id of channel") {
            };
            channelIdOption.IsRequired = true;
            command.AddOption(channelIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "key: id of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var chatMessageId1Option = new Option<string>("--chat-message-id1", description: "key: id of chatMessage") {
            };
            chatMessageId1Option.IsRequired = true;
            command.AddOption(chatMessageId1Option);
            var chatMessageHostedContentIdOption = new Option<string>("--chat-message-hosted-content-id", description: "key: id of chatMessageHostedContent") {
            };
            chatMessageHostedContentIdOption.IsRequired = true;
            command.AddOption(chatMessageHostedContentIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var teamId = (string) parameters[0];
                var channelId = (string) parameters[1];
                var chatMessageId = (string) parameters[2];
                var chatMessageId1 = (string) parameters[3];
                var chatMessageHostedContentId = (string) parameters[4];
                var body = (string) parameters[5];
                var cancellationToken = (CancellationToken) parameters[6];
                PathParameters.Clear();
                PathParameters.Add("team_id", teamId);
                PathParameters.Add("channel_id", channelId);
                PathParameters.Add("chatMessage_id", chatMessageId);
                PathParameters.Add("chatMessage_id1", chatMessageId1);
                PathParameters.Add("chatMessageHostedContent_id", chatMessageHostedContentId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ChatMessageHostedContent>(ChatMessageHostedContent.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(teamIdOption, channelIdOption, chatMessageIdOption, chatMessageId1Option, chatMessageHostedContentIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new ChatMessageHostedContentItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ChatMessageHostedContentItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/joinedTeams/{team_id}/channels/{channel_id}/messages/{chatMessage_id}/replies/{chatMessage_id1}/hostedContents/{chatMessageHostedContent_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property hostedContents for me
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Content in a message hosted by Microsoft Teams - for example, images or code snippets.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property hostedContents in me
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ChatMessageHostedContent body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>Content in a message hosted by Microsoft Teams - for example, images or code snippets.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}