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

namespace Azure.ResourceManager.Resources
{
    internal partial class DeploymentScriptLogsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DeploymentScriptLogsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public DeploymentScriptLogsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal Core.HttpMessage CreateGetLogsRequest(string resourceGroupName, string scriptName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Resources/deploymentScripts/", false);
            uri.AppendPath(scriptName, true);
            uri.AppendPath("/logs", false);
            uri.AppendQuery("api-version", "2020-10-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="scriptName"/> is null. </exception>
        public async Task<Response<ScriptLogsList>> GetLogsAsync(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var message = CreateGetLogsRequest(resourceGroupName, scriptName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptLogsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptLogsList.DeserializeScriptLogsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="scriptName"/> is null. </exception>
        public Response<ScriptLogsList> GetLogs(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var message = CreateGetLogsRequest(resourceGroupName, scriptName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptLogsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptLogsList.DeserializeScriptLogsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateGetLogsDefaultRequest(string resourceGroupName, string scriptName, int? tail)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Resources/deploymentScripts/", false);
            uri.AppendPath(scriptName, true);
            uri.AppendPath("/logs/default", false);
            uri.AppendQuery("api-version", "2020-10-01", true);
            if (tail != null)
            {
                uri.AppendQuery("tail", tail.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If &apos;tail&apos; is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="scriptName"/> is null. </exception>
        public async Task<Response<ScriptLogData>> GetLogsDefaultAsync(string resourceGroupName, string scriptName, int? tail = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var message = CreateGetLogsDefaultRequest(resourceGroupName, scriptName, tail);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptLogData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptLogData.DeserializeScriptLogData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If &apos;tail&apos; is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="scriptName"/> is null. </exception>
        public Response<ScriptLogData> GetLogsDefault(string resourceGroupName, string scriptName, int? tail = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var message = CreateGetLogsDefaultRequest(resourceGroupName, scriptName, tail);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptLogData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptLogData.DeserializeScriptLogData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
