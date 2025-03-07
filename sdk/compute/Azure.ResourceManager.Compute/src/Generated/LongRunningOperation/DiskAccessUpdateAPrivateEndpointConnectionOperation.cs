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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Approve or reject a private endpoint connection under disk access resource, this can&apos;t be used to create a new private endpoint connection. </summary>
    public partial class DiskAccessUpdateAPrivateEndpointConnectionOperation : Operation<PrivateEndpointConnection>, IOperationSource<PrivateEndpointConnection>
    {
        private readonly OperationInternals<PrivateEndpointConnection> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DiskAccessUpdateAPrivateEndpointConnectionOperation for mocking. </summary>
        protected DiskAccessUpdateAPrivateEndpointConnectionOperation()
        {
        }

        internal DiskAccessUpdateAPrivateEndpointConnectionOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<PrivateEndpointConnection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DiskAccessUpdateAPrivateEndpointConnectionOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PrivateEndpointConnection Value => _operation.Value;

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
        public override ValueTask<Response<PrivateEndpointConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PrivateEndpointConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PrivateEndpointConnection IOperationSource<PrivateEndpointConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(document.RootElement);
            return new PrivateEndpointConnection(_operationBase, data);
        }

        async ValueTask<PrivateEndpointConnection> IOperationSource<PrivateEndpointConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(document.RootElement);
            return new PrivateEndpointConnection(_operationBase, data);
        }
    }
}
