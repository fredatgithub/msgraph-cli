// <auto-generated/>
using ApiSdk.Education.Users.Item.User.MailboxSettings;
using ApiSdk.Education.Users.Item.User.ServiceProvisioningErrors;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.Education.Users.Item.User {
    /// <summary>
    /// Provides operations to manage the user property of the microsoft.graph.educationUser entity.
    /// </summary>
    public class UserRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Retrieve the simple directory user that corresponds to this educationUser.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/educationuser-get-user?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve the simple directory user that corresponds to this educationUser.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/educationuser-get-user?view=graph-rest-1.0";
            var educationUserIdOption = new Option<string>("--education-user-id", description: "The unique identifier of educationUser") {
            };
            educationUserIdOption.IsRequired = true;
            command.AddOption(educationUserIdOption);
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
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var educationUserId = invocationContext.ParseResult.GetValueForOption(educationUserIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (educationUserId is not null) requestInfo.PathParameters.Add("educationUser%2Did", educationUserId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The mailboxSettings property
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildMailboxSettingsNavCommand() {
            var command = new Command("mailbox-settings");
            command.Description = "The mailboxSettings property";
            var builder = new MailboxSettingsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The serviceProvisioningErrors property
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildServiceProvisioningErrorsNavCommand() {
            var command = new Command("service-provisioning-errors");
            command.Description = "The serviceProvisioningErrors property";
            var builder = new ServiceProvisioningErrorsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/users/{educationUser%2Did}/user{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UserRequestBuilder(string rawUrl) : base("{+baseurl}/education/users/{educationUser%2Did}/user{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Retrieve the simple directory user that corresponds to this educationUser.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UserRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UserRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the simple directory user that corresponds to this educationUser.
        /// </summary>
        public class UserRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
