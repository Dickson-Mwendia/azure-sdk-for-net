// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of DatabaseColumn and their operations over its parent. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableColumnCollection : ArmCollection, IEnumerable<ManagedInstanceDatabaseSchemaTableColumn>, IAsyncEnumerable<ManagedInstanceDatabaseSchemaTableColumn>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseColumnsRestOperations _managedDatabaseColumnsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnCollection"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableColumnCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceDatabaseSchemaTableColumnCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseColumnsRestClient = new ManagedDatabaseColumnsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceDatabaseSchemaTable.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceDatabaseSchemaTable.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: ManagedDatabaseColumns_Get
        /// <summary> Get managed database column. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumn> Get(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: ManagedDatabaseColumns_Get
        /// <summary> Get managed database column. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTableColumn>> GetAsync(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumn> GetIfExists(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseSchemaTableColumn>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTableColumn>> GetIfExistsAsync(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseSchemaTableColumn>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<bool> Exists(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(columnName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(columnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: ManagedDatabaseColumns_ListByTable
        /// <summary> List managed database columns. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceDatabaseSchemaTableColumn" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceDatabaseSchemaTableColumn> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceDatabaseSchemaTableColumn> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseColumnsRestClient.ListByTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceDatabaseSchemaTableColumn> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseColumnsRestClient.ListByTableNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: ManagedDatabaseColumns_ListByTable
        /// <summary> List managed database columns. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceDatabaseSchemaTableColumn" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceDatabaseSchemaTableColumn> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceDatabaseSchemaTableColumn>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseColumnsRestClient.ListByTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceDatabaseSchemaTableColumn>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseColumnsRestClient.ListByTableNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstanceDatabaseSchemaTableColumn> IEnumerable<ManagedInstanceDatabaseSchemaTableColumn>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceDatabaseSchemaTableColumn> IAsyncEnumerable<ManagedInstanceDatabaseSchemaTableColumn>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ManagedInstanceDatabaseSchemaTableColumn, DatabaseColumnData> Construct() { }
    }
}
