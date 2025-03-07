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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedTransparentDataEncryption and their operations over its parent. </summary>
    public partial class ManagedTransparentDataEncryptionCollection : ArmCollection, IEnumerable<ManagedTransparentDataEncryption>, IAsyncEnumerable<ManagedTransparentDataEncryption>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseTransparentDataEncryptionRestOperations _managedDatabaseTransparentDataEncryptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedTransparentDataEncryptionCollection"/> class for mocking. </summary>
        protected ManagedTransparentDataEncryptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedTransparentDataEncryptionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedTransparentDataEncryptionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseTransparentDataEncryptionRestClient = new ManagedDatabaseTransparentDataEncryptionRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabase.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseTransparentDataEncryption_CreateOrUpdate
        /// <summary> Updates a database&apos;s transparent data encryption configuration. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="parameters"> The database transparent data encryption. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedDatabaseTransparentDataEncryptionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, TransparentDataEncryptionName tdeName, ManagedTransparentDataEncryptionData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedDatabaseTransparentDataEncryptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, parameters, cancellationToken);
                var operation = new ManagedDatabaseTransparentDataEncryptionCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseTransparentDataEncryption_CreateOrUpdate
        /// <summary> Updates a database&apos;s transparent data encryption configuration. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="parameters"> The database transparent data encryption. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedDatabaseTransparentDataEncryptionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, TransparentDataEncryptionName tdeName, ManagedTransparentDataEncryptionData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTransparentDataEncryptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedDatabaseTransparentDataEncryptionCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseTransparentDataEncryption_Get
        /// <summary> Gets a managed database&apos;s transparent data encryption. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedTransparentDataEncryption> Get(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseTransparentDataEncryptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedTransparentDataEncryption(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseTransparentDataEncryption_Get
        /// <summary> Gets a managed database&apos;s transparent data encryption. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedTransparentDataEncryption>> GetAsync(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTransparentDataEncryptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedTransparentDataEncryption(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedTransparentDataEncryption> GetIfExists(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseTransparentDataEncryptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedTransparentDataEncryption>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedTransparentDataEncryption(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedTransparentDataEncryption>> GetIfExistsAsync(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTransparentDataEncryptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tdeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedTransparentDataEncryption>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedTransparentDataEncryption(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tdeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tdeName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(TransparentDataEncryptionName tdeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tdeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseTransparentDataEncryption_ListByDatabase
        /// <summary> Gets a list of managed database&apos;s transparent data encryptions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedTransparentDataEncryption" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedTransparentDataEncryption> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedTransparentDataEncryption> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseTransparentDataEncryptionRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedTransparentDataEncryption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedTransparentDataEncryption> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseTransparentDataEncryptionRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedTransparentDataEncryption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseTransparentDataEncryption_ListByDatabase
        /// <summary> Gets a list of managed database&apos;s transparent data encryptions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedTransparentDataEncryption" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedTransparentDataEncryption> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedTransparentDataEncryption>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseTransparentDataEncryptionRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedTransparentDataEncryption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedTransparentDataEncryption>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedTransparentDataEncryptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseTransparentDataEncryptionRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedTransparentDataEncryption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedTransparentDataEncryption> IEnumerable<ManagedTransparentDataEncryption>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedTransparentDataEncryption> IAsyncEnumerable<ManagedTransparentDataEncryption>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ManagedTransparentDataEncryption, ManagedTransparentDataEncryptionData> Construct() { }
    }
}
