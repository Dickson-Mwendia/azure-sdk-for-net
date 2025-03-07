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
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class representing collection of AddressResource and their operations over its parent. </summary>
    public partial class AddressResourceCollection : ArmCollection, IEnumerable<AddressResource>, IAsyncEnumerable<AddressResource>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly EdgeOrderManagementRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="AddressResourceCollection"/> class for mocking. </summary>
        protected AddressResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AddressResourceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AddressResourceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new EdgeOrderManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CreateAddress
        /// <summary> Creates a new address with the specified parameters. Existing address can be updated with this API. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="addressResource"> Address details from request body. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> or <paramref name="addressResource"/> is null. </exception>
        public virtual EdgeOrderManagementCreateAddressOperation CreateOrUpdate(bool waitForCompletion, string addressName, AddressResourceData addressResource, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }
            if (addressResource == null)
            {
                throw new ArgumentNullException(nameof(addressResource));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateAddress(Id.SubscriptionId, Id.ResourceGroupName, addressName, addressResource, cancellationToken);
                var operation = new EdgeOrderManagementCreateAddressOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateAddressRequest(Id.SubscriptionId, Id.ResourceGroupName, addressName, addressResource).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CreateAddress
        /// <summary> Creates a new address with the specified parameters. Existing address can be updated with this API. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="addressResource"> Address details from request body. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> or <paramref name="addressResource"/> is null. </exception>
        public async virtual Task<EdgeOrderManagementCreateAddressOperation> CreateOrUpdateAsync(bool waitForCompletion, string addressName, AddressResourceData addressResource, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }
            if (addressResource == null)
            {
                throw new ArgumentNullException(nameof(addressResource));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateAddressAsync(Id.SubscriptionId, Id.ResourceGroupName, addressName, addressResource, cancellationToken).ConfigureAwait(false);
                var operation = new EdgeOrderManagementCreateAddressOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateAddressRequest(Id.SubscriptionId, Id.ResourceGroupName, addressName, addressResource).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetAddressByName
        /// <summary> Gets information about the specified address. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public virtual Response<AddressResource> Get(string addressName, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _restClient.GetAddressByName(Id.SubscriptionId, Id.ResourceGroupName, addressName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AddressResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetAddressByName
        /// <summary> Gets information about the specified address. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public async virtual Task<Response<AddressResource>> GetAsync(string addressName, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAddressByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, addressName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AddressResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public virtual Response<AddressResource> GetIfExists(string addressName, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restClient.GetAddressByName(Id.SubscriptionId, Id.ResourceGroupName, addressName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AddressResource>(null, response.GetRawResponse());
                return Response.FromValue(new AddressResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public async virtual Task<Response<AddressResource>> GetIfExistsAsync(string addressName, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restClient.GetAddressByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, addressName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AddressResource>(null, response.GetRawResponse());
                return Response.FromValue(new AddressResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public virtual Response<bool> Exists(string addressName, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(addressName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string addressName, CancellationToken cancellationToken = default)
        {
            if (addressName == null)
            {
                throw new ArgumentNullException(nameof(addressName));
            }

            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(addressName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ListAddressesAtResourceGroupLevel
        /// <summary> Lists all the addresses available under the given resource group. </summary>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AddressResource> GetAll(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<AddressResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.ListAddressesAtResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, filter, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AddressResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.ListAddressesAtResourceGroupLevelNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ListAddressesAtResourceGroupLevel
        /// <summary> Lists all the addresses available under the given resource group. </summary>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AddressResource> GetAllAsync(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AddressResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAddressesAtResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, filter, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AddressResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAddressesAtResourceGroupLevelNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AddressResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AddressResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AddressResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AddressResourceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AddressResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AddressResource> IEnumerable<AddressResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AddressResource> IAsyncEnumerable<AddressResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AddressResource, AddressResourceData> Construct() { }
    }
}
