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
    /// <summary> A class representing collection of ManagedInstanceAdministrator and their operations over its parent. </summary>
    public partial class ManagedInstanceAdministratorCollection : ArmCollection, IEnumerable<ManagedInstanceAdministrator>, IAsyncEnumerable<ManagedInstanceAdministrator>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedInstanceAdministratorsRestOperations _managedInstanceAdministratorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdministratorCollection"/> class for mocking. </summary>
        protected ManagedInstanceAdministratorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdministratorCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceAdministratorCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedInstanceAdministratorsRestClient = new ManagedInstanceAdministratorsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstance.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstance.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceAdministrators_CreateOrUpdate
        /// <summary> Creates or updates a managed instance administrator. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="parameters"> The requested administrator parameters. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstanceAdministratorCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, AdministratorName administratorName, ManagedInstanceAdministratorData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceAdministratorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters, cancellationToken);
                var operation = new ManagedInstanceAdministratorCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedInstanceAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceAdministrators_CreateOrUpdate
        /// <summary> Creates or updates a managed instance administrator. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="parameters"> The requested administrator parameters. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedInstanceAdministratorCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, AdministratorName administratorName, ManagedInstanceAdministratorData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdministratorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedInstanceAdministratorCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedInstanceAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceAdministrators_Get
        /// <summary> Gets a managed instance administrator. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAdministrator> Get(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdministrator(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceAdministrators_Get
        /// <summary> Gets a managed instance administrator. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceAdministrator>> GetAsync(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceAdministrator(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAdministrator> GetIfExists(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceAdministrator>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdministrator(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceAdministrator>> GetIfExistsAsync(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceAdministrator>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdministrator(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(administratorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="administratorName"> The AdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(administratorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceAdministrators_ListByInstance
        /// <summary> Gets a list of managed instance administrators. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceAdministrator" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceAdministrator> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceAdministrator> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceAdministratorsRestClient.ListByInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAdministrator(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceAdministrator> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceAdministratorsRestClient.ListByInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAdministrator(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceAdministrators_ListByInstance
        /// <summary> Gets a list of managed instance administrators. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceAdministrator" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceAdministrator> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceAdministrator>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceAdministratorsRestClient.ListByInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAdministrator(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceAdministrator>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceAdministratorsRestClient.ListByInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAdministrator(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstanceAdministrator> IEnumerable<ManagedInstanceAdministrator>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceAdministrator> IAsyncEnumerable<ManagedInstanceAdministrator>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ManagedInstanceAdministrator, ManagedInstanceAdministratorData> Construct() { }
    }
}
