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
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Creates a new CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
    public partial class CdnEndpointCreateOperation : Operation<CdnEndpoint>, IOperationSource<CdnEndpoint>
    {
        private readonly OperationInternals<CdnEndpoint> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of CdnEndpointCreateOperation for mocking. </summary>
        protected CdnEndpointCreateOperation()
        {
        }

        internal CdnEndpointCreateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CdnEndpoint>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CdnEndpointCreateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CdnEndpoint Value => _operation.Value;

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
        public override ValueTask<Response<CdnEndpoint>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CdnEndpoint>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CdnEndpoint IOperationSource<CdnEndpoint>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CdnEndpointData.DeserializeCdnEndpointData(document.RootElement);
            return new CdnEndpoint(_operationBase, data);
        }

        async ValueTask<CdnEndpoint> IOperationSource<CdnEndpoint>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CdnEndpointData.DeserializeCdnEndpointData(document.RootElement);
            return new CdnEndpoint(_operationBase, data);
        }
    }
}
