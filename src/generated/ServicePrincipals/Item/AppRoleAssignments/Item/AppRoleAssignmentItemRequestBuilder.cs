// <auto-generated/>
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
namespace ApiSdk.ServicePrincipals.Item.AppRoleAssignments.Item {
    /// <summary>
    /// Provides operations to manage the appRoleAssignments property of the microsoft.graph.servicePrincipal entity.
    /// </summary>
    public class AppRoleAssignmentItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Deletes an appRoleAssignment that a service principal has been granted. App roles which are assigned to service principals are also known as application permissions. Deleting an app role assignment for a service principal is equivalent to revoking the app-only permission grant.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-delete-approleassignments?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Deletes an appRoleAssignment that a service principal has been granted. App roles which are assigned to service principals are also known as application permissions. Deleting an app role assignment for a service principal is equivalent to revoking the app-only permission grant.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/serviceprincipal-delete-approleassignments?view=graph-rest-1.0";
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "The unique identifier of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var appRoleAssignmentIdOption = new Option<string>("--app-role-assignment-id", description: "The unique identifier of appRoleAssignment") {
            };
            appRoleAssignmentIdOption.IsRequired = true;
            command.AddOption(appRoleAssignmentIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var appRoleAssignmentId = invocationContext.ParseResult.GetValueForOption(appRoleAssignmentIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                if (appRoleAssignmentId is not null) requestInfo.PathParameters.Add("appRoleAssignment%2Did", appRoleAssignmentId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
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
        /// App role assignment for another app or service, granted to this service principal. Supports $expand.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "App role assignment for another app or service, granted to this service principal. Supports $expand.";
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "The unique identifier of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var appRoleAssignmentIdOption = new Option<string>("--app-role-assignment-id", description: "The unique identifier of appRoleAssignment") {
            };
            appRoleAssignmentIdOption.IsRequired = true;
            command.AddOption(appRoleAssignmentIdOption);
            var consistencyLevelOption = new Option<string[]>("--consistency-level", description: "Indicates the requested consistency level. Documentation URL: https://docs.microsoft.com/graph/aad-advanced-queries") {
                Arity = ArgumentArity.ZeroOrMore
            };
            consistencyLevelOption.IsRequired = false;
            command.AddOption(consistencyLevelOption);
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
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var appRoleAssignmentId = invocationContext.ParseResult.GetValueForOption(appRoleAssignmentIdOption);
                var consistencyLevel = invocationContext.ParseResult.GetValueForOption(consistencyLevelOption);
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
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                if (appRoleAssignmentId is not null) requestInfo.PathParameters.Add("appRoleAssignment%2Did", appRoleAssignmentId);
                if (consistencyLevel is not null) requestInfo.Headers.Add("ConsistencyLevel", consistencyLevel);
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
        /// Update the navigation property appRoleAssignments in servicePrincipals
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property appRoleAssignments in servicePrincipals";
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "The unique identifier of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var appRoleAssignmentIdOption = new Option<string>("--app-role-assignment-id", description: "The unique identifier of appRoleAssignment") {
            };
            appRoleAssignmentIdOption.IsRequired = true;
            command.AddOption(appRoleAssignmentIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var appRoleAssignmentId = invocationContext.ParseResult.GetValueForOption(appRoleAssignmentIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                if (appRoleAssignmentId is not null) requestInfo.PathParameters.Add("appRoleAssignment%2Did", appRoleAssignmentId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="AppRoleAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AppRoleAssignmentItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/appRoleAssignments/{appRoleAssignment%2Did}{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AppRoleAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AppRoleAssignmentItemRequestBuilder(string rawUrl) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/appRoleAssignments/{appRoleAssignment%2Did}{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Deletes an appRoleAssignment that a service principal has been granted. App roles which are assigned to service principals are also known as application permissions. Deleting an app role assignment for a service principal is equivalent to revoking the app-only permission grant.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/appRoleAssignments/{appRoleAssignment%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// App role assignment for another app or service, granted to this service principal. Supports $expand.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AppRoleAssignmentItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AppRoleAssignmentItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property appRoleAssignments in servicePrincipals
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AppRoleAssignment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AppRoleAssignment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/appRoleAssignments/{appRoleAssignment%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// App role assignment for another app or service, granted to this service principal. Supports $expand.
        /// </summary>
        public class AppRoleAssignmentItemRequestBuilderGetQueryParameters {
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
