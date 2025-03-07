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
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates or updates a certificate and associates with key vault secret. </summary>
    public partial class AppServiceCertificateOrderCreateOrUpdateCertificateOperation : Operation<AppServiceCertificateResource>, IOperationSource<AppServiceCertificateResource>
    {
        private readonly OperationInternals<AppServiceCertificateResource> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of AppServiceCertificateOrderCreateOrUpdateCertificateOperation for mocking. </summary>
        protected AppServiceCertificateOrderCreateOrUpdateCertificateOperation()
        {
        }

        internal AppServiceCertificateOrderCreateOrUpdateCertificateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AppServiceCertificateResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "AppServiceCertificateOrderCreateOrUpdateCertificateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AppServiceCertificateResource Value => _operation.Value;

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
        public override ValueTask<Response<AppServiceCertificateResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AppServiceCertificateResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AppServiceCertificateResource IOperationSource<AppServiceCertificateResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServiceCertificateResourceData.DeserializeAppServiceCertificateResourceData(document.RootElement);
            return new AppServiceCertificateResource(_operationBase, data);
        }

        async ValueTask<AppServiceCertificateResource> IOperationSource<AppServiceCertificateResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServiceCertificateResourceData.DeserializeAppServiceCertificateResourceData(document.RootElement);
            return new AppServiceCertificateResource(_operationBase, data);
        }
    }
}
