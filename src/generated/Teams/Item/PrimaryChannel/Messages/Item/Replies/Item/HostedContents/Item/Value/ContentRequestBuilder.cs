// <auto-generated/>
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
namespace ApiSdk.Teams.Item.PrimaryChannel.Messages.Item.Replies.Item.HostedContents.Item.Value {
    /// <summary>
    /// Provides operations to manage the media for the team entity.
    /// </summary>
    public class ContentRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Get media content for the navigation property hostedContents from teams
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/chatmessage-list-hostedcontents?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get media content for the navigation property hostedContents from teams\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/chatmessage-list-hostedcontents?view=graph-rest-1.0";
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "The unique identifier of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var chatMessageId1Option = new Option<string>("--chat-message-id1", description: "The unique identifier of chatMessage") {
            };
            chatMessageId1Option.IsRequired = true;
            command.AddOption(chatMessageId1Option);
            var chatMessageHostedContentIdOption = new Option<string>("--chat-message-hosted-content-id", description: "The unique identifier of chatMessageHostedContent") {
            };
            chatMessageHostedContentIdOption.IsRequired = true;
            command.AddOption(chatMessageHostedContentIdOption);
            var formatOption = new Option<string>("--format", description: "Format of the content") {
            };
            formatOption.IsRequired = false;
            command.AddOption(formatOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var chatMessageId = invocationContext.ParseResult.GetValueForOption(chatMessageIdOption);
                var chatMessageId1 = invocationContext.ParseResult.GetValueForOption(chatMessageId1Option);
                var chatMessageHostedContentId = invocationContext.ParseResult.GetValueForOption(chatMessageHostedContentIdOption);
                var format = invocationContext.ParseResult.GetValueForOption(formatOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(format)) q.QueryParameters.Format = format;
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (chatMessageId is not null) requestInfo.PathParameters.Add("chatMessage%2Did", chatMessageId);
                if (chatMessageId1 is not null) requestInfo.PathParameters.Add("chatMessage%2Did1", chatMessageId1);
                if (chatMessageHostedContentId is not null) requestInfo.PathParameters.Add("chatMessageHostedContent%2Did", chatMessageHostedContentId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Update media content for the navigation property hostedContents in teams
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update media content for the navigation property hostedContents in teams";
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "The unique identifier of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var chatMessageId1Option = new Option<string>("--chat-message-id1", description: "The unique identifier of chatMessage") {
            };
            chatMessageId1Option.IsRequired = true;
            command.AddOption(chatMessageId1Option);
            var chatMessageHostedContentIdOption = new Option<string>("--chat-message-hosted-content-id", description: "The unique identifier of chatMessageHostedContent") {
            };
            chatMessageHostedContentIdOption.IsRequired = true;
            command.AddOption(chatMessageHostedContentIdOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var chatMessageId = invocationContext.ParseResult.GetValueForOption(chatMessageIdOption);
                var chatMessageId1 = invocationContext.ParseResult.GetValueForOption(chatMessageId1Option);
                var chatMessageHostedContentId = invocationContext.ParseResult.GetValueForOption(chatMessageHostedContentIdOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) {
                    Console.Error.WriteLine("No available file to send.");
                    return;
                }
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (chatMessageId is not null) requestInfo.PathParameters.Add("chatMessage%2Did", chatMessageId);
                if (chatMessageId1 is not null) requestInfo.PathParameters.Add("chatMessage%2Did1", chatMessageId1);
                if (chatMessageHostedContentId is not null) requestInfo.PathParameters.Add("chatMessageHostedContent%2Did", chatMessageHostedContentId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teams/{team%2Did}/primaryChannel/messages/{chatMessage%2Did}/replies/{chatMessage%2Did1}/hostedContents/{chatMessageHostedContent%2Did}/$value{?%24format*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContentRequestBuilder(string rawUrl) : base("{+baseurl}/teams/{team%2Did}/primaryChannel/messages/{chatMessage%2Did}/replies/{chatMessage%2Did1}/hostedContents/{chatMessageHostedContent%2Did}/$value{?%24format*}", rawUrl) {
        }
        /// <summary>
        /// Get media content for the navigation property hostedContents from teams
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ContentRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ContentRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream, application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update media content for the navigation property hostedContents in teams
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, "{+baseurl}/teams/{team%2Did}/primaryChannel/messages/{chatMessage%2Did}/replies/{chatMessage%2Did1}/hostedContents/{chatMessageHostedContent%2Did}/$value", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// Get media content for the navigation property hostedContents from teams
        /// </summary>
        public class ContentRequestBuilderGetQueryParameters {
            /// <summary>Format of the content</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("%24format")]
            public string Format { get; set; }
#endif
        }
    }
}
