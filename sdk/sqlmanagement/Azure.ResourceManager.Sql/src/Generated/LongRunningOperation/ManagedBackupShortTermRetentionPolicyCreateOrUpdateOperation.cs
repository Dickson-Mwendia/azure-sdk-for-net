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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Updates a managed database&apos;s short term retention policy. </summary>
    public partial class ManagedBackupShortTermRetentionPolicyCreateOrUpdateOperation : Operation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>, IOperationSource<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>
    {
        private readonly OperationInternals<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ManagedBackupShortTermRetentionPolicyCreateOrUpdateOperation for mocking. </summary>
        protected ManagedBackupShortTermRetentionPolicyCreateOrUpdateOperation()
        {
        }

        internal ManagedBackupShortTermRetentionPolicyCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ManagedBackupShortTermRetentionPolicyCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagedInstanceDatabaseBackupShortTermRetentionPolicy Value => _operation.Value;

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
        public override ValueTask<Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ManagedInstanceDatabaseBackupShortTermRetentionPolicy IOperationSource<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(_operationBase, data);
        }

        async ValueTask<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> IOperationSource<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(_operationBase, data);
        }
    }
}
