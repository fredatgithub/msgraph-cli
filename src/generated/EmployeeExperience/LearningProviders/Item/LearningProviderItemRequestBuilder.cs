// <auto-generated/>
using ApiSdk.EmployeeExperience.LearningProviders.Item.LearningContents;
using ApiSdk.EmployeeExperience.LearningProviders.Item.LearningContentsWithExternalId;
using ApiSdk.EmployeeExperience.LearningProviders.Item.LearningCourseActivities;
using ApiSdk.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId;
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
namespace ApiSdk.EmployeeExperience.LearningProviders.Item {
    /// <summary>
    /// Provides operations to manage the learningProviders property of the microsoft.graph.employeeExperience entity.
    /// </summary>
    public class LearningProviderItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Delete a learningProvider resource and remove its registration in Viva Learning for a tenant.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/employeeexperience-delete-learningproviders?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete a learningProvider resource and remove its registration in Viva Learning for a tenant.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/employeeexperience-delete-learningproviders?view=graph-rest-1.0";
            var learningProviderIdOption = new Option<string>("--learning-provider-id", description: "The unique identifier of learningProvider") {
            };
            learningProviderIdOption.IsRequired = true;
            command.AddOption(learningProviderIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var learningProviderId = invocationContext.ParseResult.GetValueForOption(learningProviderIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (learningProviderId is not null) requestInfo.PathParameters.Add("learningProvider%2Did", learningProviderId);
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
        /// Read the properties and relationships of a learningProvider object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/learningprovider-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of a learningProvider object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/learningprovider-get?view=graph-rest-1.0";
            var learningProviderIdOption = new Option<string>("--learning-provider-id", description: "The unique identifier of learningProvider") {
            };
            learningProviderIdOption.IsRequired = true;
            command.AddOption(learningProviderIdOption);
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
                var learningProviderId = invocationContext.ParseResult.GetValueForOption(learningProviderIdOption);
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
                if (learningProviderId is not null) requestInfo.PathParameters.Add("learningProvider%2Did", learningProviderId);
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
        /// Provides operations to manage the learningContents property of the microsoft.graph.learningProvider entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildLearningContentsNavCommand() {
            var command = new Command("learning-contents");
            command.Description = "Provides operations to manage the learningContents property of the microsoft.graph.learningProvider entity.";
            var builder = new LearningContentsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the learningContents property of the microsoft.graph.learningProvider entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildLearningContentsWithExternalIdRbCommand() {
            var command = new Command("learning-contents-with-external-id");
            command.Description = "Provides operations to manage the learningContents property of the microsoft.graph.learningProvider entity.";
            var builder = new LearningContentsWithExternalIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the learningCourseActivities property of the microsoft.graph.learningProvider entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildLearningCourseActivitiesNavCommand() {
            var command = new Command("learning-course-activities");
            command.Description = "Provides operations to manage the learningCourseActivities property of the microsoft.graph.learningProvider entity.";
            var builder = new LearningCourseActivitiesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the learningCourseActivities property of the microsoft.graph.learningProvider entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildLearningCourseActivitiesWithExternalcourseActivityIdRbCommand() {
            var command = new Command("learning-course-activities-with-externalcourse-activity-id");
            command.Description = "Provides operations to manage the learningCourseActivities property of the microsoft.graph.learningProvider entity.";
            var builder = new LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the properties of a learningProvider object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/learningprovider-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of a learningProvider object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/learningprovider-update?view=graph-rest-1.0";
            var learningProviderIdOption = new Option<string>("--learning-provider-id", description: "The unique identifier of learningProvider") {
            };
            learningProviderIdOption.IsRequired = true;
            command.AddOption(learningProviderIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var learningProviderId = invocationContext.ParseResult.GetValueForOption(learningProviderIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<LearningProvider>(LearningProvider.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (learningProviderId is not null) requestInfo.PathParameters.Add("learningProvider%2Did", learningProviderId);
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
        /// Instantiates a new <see cref="LearningProviderItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public LearningProviderItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/employeeExperience/learningProviders/{learningProvider%2Did}{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="LearningProviderItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public LearningProviderItemRequestBuilder(string rawUrl) : base("{+baseurl}/employeeExperience/learningProviders/{learningProvider%2Did}{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Delete a learningProvider resource and remove its registration in Viva Learning for a tenant.
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/employeeExperience/learningProviders/{learningProvider%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a learningProvider object.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<LearningProviderItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<LearningProviderItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a learningProvider object.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(LearningProvider body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(LearningProvider body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/employeeExperience/learningProviders/{learningProvider%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a learningProvider object.
        /// </summary>
        public class LearningProviderItemRequestBuilderGetQueryParameters {
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
