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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of DdosProtectionPlan and their operations over its parent. </summary>
    public partial class DdosProtectionPlanCollection : ArmCollection, IEnumerable<DdosProtectionPlan>, IAsyncEnumerable<DdosProtectionPlan>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DdosProtectionPlansRestOperations _ddosProtectionPlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="DdosProtectionPlanCollection"/> class for mocking. </summary>
        protected DdosProtectionPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DdosProtectionPlanCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DdosProtectionPlanCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _ddosProtectionPlansRestClient = new DdosProtectionPlansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a DDoS protection plan. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DdosProtectionPlanCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string ddosProtectionPlanName, DdosProtectionPlanData parameters, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlansRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters, cancellationToken);
                var operation = new DdosProtectionPlanCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ddosProtectionPlansRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters).Request, response);
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

        /// <summary> Creates or updates a DDoS protection plan. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DdosProtectionPlanCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string ddosProtectionPlanName, DdosProtectionPlanData parameters, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlansRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DdosProtectionPlanCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ddosProtectionPlansRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters).Request, response);
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

        /// <summary> Gets information about the specified DDoS protection plan. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<DdosProtectionPlan> Get(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlan(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified DDoS protection plan. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public async virtual Task<Response<DdosProtectionPlan>> GetAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DdosProtectionPlan(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<DdosProtectionPlan> GetIfExists(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DdosProtectionPlan>(null, response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlan(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public async virtual Task<Response<DdosProtectionPlan>> GetIfExistsAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DdosProtectionPlan>(null, response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlan(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ddosProtectionPlanName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ddosProtectionPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the DDoS protection plans in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DdosProtectionPlan" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DdosProtectionPlan> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DdosProtectionPlan> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ddosProtectionPlansRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DdosProtectionPlan> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ddosProtectionPlansRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the DDoS protection plans in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DdosProtectionPlan" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DdosProtectionPlan> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DdosProtectionPlan>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ddosProtectionPlansRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DdosProtectionPlan>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ddosProtectionPlansRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DdosProtectionPlan" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DdosProtectionPlan.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DdosProtectionPlan" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DdosProtectionPlan.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DdosProtectionPlan> IEnumerable<DdosProtectionPlan>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DdosProtectionPlan> IAsyncEnumerable<DdosProtectionPlan>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DdosProtectionPlan, DdosProtectionPlanData> Construct() { }
    }
}
