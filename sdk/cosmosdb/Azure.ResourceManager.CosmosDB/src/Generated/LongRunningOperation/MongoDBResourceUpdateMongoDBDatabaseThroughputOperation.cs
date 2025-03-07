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
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Update RUs per second of the an Azure Cosmos DB MongoDB database. </summary>
    public partial class MongoDBResourceUpdateMongoDBDatabaseThroughputOperation : Operation<DatabaseAccountMongodbDatabaseThroughputSetting>, IOperationSource<DatabaseAccountMongodbDatabaseThroughputSetting>
    {
        private readonly OperationInternals<DatabaseAccountMongodbDatabaseThroughputSetting> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of MongoDBResourceUpdateMongoDBDatabaseThroughputOperation for mocking. </summary>
        protected MongoDBResourceUpdateMongoDBDatabaseThroughputOperation()
        {
        }

        internal MongoDBResourceUpdateMongoDBDatabaseThroughputOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DatabaseAccountMongodbDatabaseThroughputSetting>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "MongoDBResourceUpdateMongoDBDatabaseThroughputOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DatabaseAccountMongodbDatabaseThroughputSetting Value => _operation.Value;

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
        public override ValueTask<Response<DatabaseAccountMongodbDatabaseThroughputSetting>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DatabaseAccountMongodbDatabaseThroughputSetting>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DatabaseAccountMongodbDatabaseThroughputSetting IOperationSource<DatabaseAccountMongodbDatabaseThroughputSetting>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement);
            return new DatabaseAccountMongodbDatabaseThroughputSetting(_operationBase, data);
        }

        async ValueTask<DatabaseAccountMongodbDatabaseThroughputSetting> IOperationSource<DatabaseAccountMongodbDatabaseThroughputSetting>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement);
            return new DatabaseAccountMongodbDatabaseThroughputSetting(_operationBase, data);
        }
    }
}
