// <auto-generated/>
using ApiSdk.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Assignments;
using ApiSdk.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Categories;
using ApiSdk.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.ContentVersions;
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
namespace ApiSdk.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp {
    /// <summary>
    /// Casts the previous resource to androidLobApp.
    /// </summary>
    public class GraphAndroidLobAppRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the assignments property of the microsoft.graph.mobileApp entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildAssignmentsNavCommand() {
            var command = new Command("assignments");
            command.Description = "Provides operations to manage the assignments property of the microsoft.graph.mobileApp entity.";
            var builder = new AssignmentsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the categories property of the microsoft.graph.mobileApp entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildCategoriesNavCommand() {
            var command = new Command("categories");
            command.Description = "Provides operations to manage the categories property of the microsoft.graph.mobileApp entity.";
            var builder = new CategoriesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contentVersions property of the microsoft.graph.mobileLobApp entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildContentVersionsNavCommand() {
            var command = new Command("content-versions");
            command.Description = "Provides operations to manage the contentVersions property of the microsoft.graph.mobileLobApp entity.";
            var builder = new ContentVersionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.androidLobApp
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get the item of type microsoft.graph.mobileApp as microsoft.graph.androidLobApp";
            var mobileAppIdOption = new Option<string>("--mobile-app-id", description: "The unique identifier of mobileApp") {
            };
            mobileAppIdOption.IsRequired = true;
            command.AddOption(mobileAppIdOption);
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
                var mobileAppId = invocationContext.ParseResult.GetValueForOption(mobileAppIdOption);
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
                if (mobileAppId is not null) requestInfo.PathParameters.Add("mobileApp%2Did", mobileAppId);
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
        /// Instantiates a new <see cref="GraphAndroidLobAppRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GraphAndroidLobAppRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.androidLobApp{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="GraphAndroidLobAppRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GraphAndroidLobAppRequestBuilder(string rawUrl) : base("{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.androidLobApp{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.androidLobApp
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GraphAndroidLobAppRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GraphAndroidLobAppRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.androidLobApp
        /// </summary>
        public class GraphAndroidLobAppRequestBuilderGetQueryParameters {
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
