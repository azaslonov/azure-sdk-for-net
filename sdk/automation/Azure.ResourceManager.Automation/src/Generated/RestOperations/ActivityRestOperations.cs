// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    internal partial class ActivityRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ActivityRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ActivityRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-01-13-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, string activityName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(moduleName, true);
            uri.AppendPath("/activities/", false);
            uri.AppendPath(activityName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve the activity in the module identified by module name and activity name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="activityName"> The name of activity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="activityName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="activityName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationActivity>> GetAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, string activityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));
            Argument.AssertNotNullOrEmpty(activityName, nameof(activityName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, moduleName, activityName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationActivity value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationActivity.DeserializeAutomationActivity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve the activity in the module identified by module name and activity name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="activityName"> The name of activity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="activityName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="activityName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationActivity> Get(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, string activityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));
            Argument.AssertNotNullOrEmpty(activityName, nameof(activityName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, moduleName, activityName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationActivity value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationActivity.DeserializeAutomationActivity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByModuleRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(moduleName, true);
            uri.AppendPath("/activities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of activities in the module identified by module name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationActivityListResult>> ListByModuleAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var message = CreateListByModuleRequest(subscriptionId, resourceGroupName, automationAccountName, moduleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationActivityListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationActivityListResult.DeserializeAutomationActivityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of activities in the module identified by module name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationActivityListResult> ListByModule(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var message = CreateListByModuleRequest(subscriptionId, resourceGroupName, automationAccountName, moduleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationActivityListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationActivityListResult.DeserializeAutomationActivityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByModuleNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of activities in the module identified by module name. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationActivityListResult>> ListByModuleNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var message = CreateListByModuleNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, moduleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationActivityListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationActivityListResult.DeserializeAutomationActivityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of activities in the module identified by module name. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationActivityListResult> ListByModuleNextPage(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var message = CreateListByModuleNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, moduleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationActivityListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationActivityListResult.DeserializeAutomationActivityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
