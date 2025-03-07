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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Creates or updates a namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent. </summary>
    public partial class EventHubNamespaceCreateOrUpdateOperation : Operation<EventHubNamespace>, IOperationSource<EventHubNamespace>
    {
        private readonly OperationInternals<EventHubNamespace> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of EventHubNamespaceCreateOrUpdateOperation for mocking. </summary>
        protected EventHubNamespaceCreateOrUpdateOperation()
        {
        }

        internal EventHubNamespaceCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<EventHubNamespace>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "EventHubNamespaceCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override EventHubNamespace Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<EventHubNamespace>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<EventHubNamespace>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        EventHubNamespace IOperationSource<EventHubNamespace>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventHubNamespaceData.DeserializeEventHubNamespaceData(document.RootElement);
            return new EventHubNamespace(_operationBase, data);
        }

        async ValueTask<EventHubNamespace> IOperationSource<EventHubNamespace>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventHubNamespaceData.DeserializeEventHubNamespaceData(document.RootElement);
            return new EventHubNamespace(_operationBase, data);
        }
    }
}
