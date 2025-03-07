// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AvailabilitySet
        /// <summary> Gets an object representing a AvailabilitySet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySet" /> object. </returns>
        public static AvailabilitySet GetAvailabilitySet(this ArmClient armClient, ResourceIdentifier id)
        {
            AvailabilitySet.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AvailabilitySet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ProximityPlacementGroup
        /// <summary> Gets an object representing a ProximityPlacementGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProximityPlacementGroup" /> object. </returns>
        public static ProximityPlacementGroup GetProximityPlacementGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            ProximityPlacementGroup.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ProximityPlacementGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DedicatedHostGroup
        /// <summary> Gets an object representing a DedicatedHostGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroup" /> object. </returns>
        public static DedicatedHostGroup GetDedicatedHostGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            DedicatedHostGroup.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DedicatedHostGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DedicatedHost
        /// <summary> Gets an object representing a DedicatedHost along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHost" /> object. </returns>
        public static DedicatedHost GetDedicatedHost(this ArmClient armClient, ResourceIdentifier id)
        {
            DedicatedHost.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DedicatedHost(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SshPublicKey
        /// <summary> Gets an object representing a SshPublicKey along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SshPublicKey" /> object. </returns>
        public static SshPublicKey GetSshPublicKey(this ArmClient armClient, ResourceIdentifier id)
        {
            SshPublicKey.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SshPublicKey(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineExtensionImage
        /// <summary> Gets an object representing a VirtualMachineExtensionImage along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtensionImage" /> object. </returns>
        public static VirtualMachineExtensionImage GetVirtualMachineExtensionImage(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineExtensionImage.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineExtensionImage(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineExtension
        /// <summary> Gets an object representing a VirtualMachineExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtension" /> object. </returns>
        public static VirtualMachineExtension GetVirtualMachineExtension(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineExtension.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineExtension(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachine
        /// <summary> Gets an object representing a VirtualMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachine" /> object. </returns>
        public static VirtualMachine GetVirtualMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachine.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSet
        /// <summary> Gets an object representing a VirtualMachineScaleSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSet" /> object. </returns>
        public static VirtualMachineScaleSet GetVirtualMachineScaleSet(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineScaleSet.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Image
        /// <summary> Gets an object representing a Image along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Image" /> object. </returns>
        public static Image GetImage(this ArmClient armClient, ResourceIdentifier id)
        {
            Image.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Image(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RestorePointGroup
        /// <summary> Gets an object representing a RestorePointGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePointGroup" /> object. </returns>
        public static RestorePointGroup GetRestorePointGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            RestorePointGroup.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RestorePointGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RestorePoint
        /// <summary> Gets an object representing a RestorePoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePoint" /> object. </returns>
        public static RestorePoint GetRestorePoint(this ArmClient armClient, ResourceIdentifier id)
        {
            RestorePoint.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RestorePoint(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetExtension
        /// <summary> Gets an object representing a VirtualMachineScaleSetExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetExtension" /> object. </returns>
        public static VirtualMachineScaleSetExtension GetVirtualMachineScaleSetExtension(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineScaleSetExtension.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetExtension(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetRollingUpgrade
        /// <summary> Gets an object representing a VirtualMachineScaleSetRollingUpgrade along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetRollingUpgrade" /> object. </returns>
        public static VirtualMachineScaleSetRollingUpgrade GetVirtualMachineScaleSetRollingUpgrade(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineScaleSetRollingUpgrade.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetRollingUpgrade(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetVMExtension
        /// <summary> Gets an object representing a VirtualMachineScaleSetVMExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVMExtension" /> object. </returns>
        public static VirtualMachineScaleSetVMExtension GetVirtualMachineScaleSetVMExtension(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineScaleSetVMExtension.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetVMExtension(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetVM
        /// <summary> Gets an object representing a VirtualMachineScaleSetVM along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVM" /> object. </returns>
        public static VirtualMachineScaleSetVM GetVirtualMachineScaleSetVM(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineScaleSetVM.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetVM(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineRunCommand
        /// <summary> Gets an object representing a VirtualMachineRunCommand along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineRunCommand" /> object. </returns>
        public static VirtualMachineRunCommand GetVirtualMachineRunCommand(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineRunCommand.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineRunCommand(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetVirtualMachineRunCommand
        /// <summary> Gets an object representing a VirtualMachineScaleSetVirtualMachineRunCommand along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVirtualMachineRunCommand" /> object. </returns>
        public static VirtualMachineScaleSetVirtualMachineRunCommand GetVirtualMachineScaleSetVirtualMachineRunCommand(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualMachineScaleSetVirtualMachineRunCommand.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetVirtualMachineRunCommand(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Disk
        /// <summary> Gets an object representing a Disk along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Disk" /> object. </returns>
        public static Disk GetDisk(this ArmClient armClient, ResourceIdentifier id)
        {
            Disk.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Disk(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Snapshot
        /// <summary> Gets an object representing a Snapshot along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Snapshot" /> object. </returns>
        public static Snapshot GetSnapshot(this ArmClient armClient, ResourceIdentifier id)
        {
            Snapshot.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Snapshot(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiskEncryptionSet
        /// <summary> Gets an object representing a DiskEncryptionSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskEncryptionSet" /> object. </returns>
        public static DiskEncryptionSet GetDiskEncryptionSet(this ArmClient armClient, ResourceIdentifier id)
        {
            DiskEncryptionSet.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiskEncryptionSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiskAccess
        /// <summary> Gets an object representing a DiskAccess along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskAccess" /> object. </returns>
        public static DiskAccess GetDiskAccess(this ArmClient armClient, ResourceIdentifier id)
        {
            DiskAccess.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiskAccess(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            PrivateEndpointConnection.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiskRestorePoint
        /// <summary> Gets an object representing a DiskRestorePoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskRestorePoint" /> object. </returns>
        public static DiskRestorePoint GetDiskRestorePoint(this ArmClient armClient, ResourceIdentifier id)
        {
            DiskRestorePoint.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiskRestorePoint(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Gallery
        /// <summary> Gets an object representing a Gallery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Gallery" /> object. </returns>
        public static Gallery GetGallery(this ArmClient armClient, ResourceIdentifier id)
        {
            Gallery.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Gallery(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryImage
        /// <summary> Gets an object representing a GalleryImage along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImage" /> object. </returns>
        public static GalleryImage GetGalleryImage(this ArmClient armClient, ResourceIdentifier id)
        {
            GalleryImage.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryImage(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryImageVersion
        /// <summary> Gets an object representing a GalleryImageVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImageVersion" /> object. </returns>
        public static GalleryImageVersion GetGalleryImageVersion(this ArmClient armClient, ResourceIdentifier id)
        {
            GalleryImageVersion.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryImageVersion(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryApplication
        /// <summary> Gets an object representing a GalleryApplication along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplication" /> object. </returns>
        public static GalleryApplication GetGalleryApplication(this ArmClient armClient, ResourceIdentifier id)
        {
            GalleryApplication.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryApplication(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryApplicationVersion
        /// <summary> Gets an object representing a GalleryApplicationVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplicationVersion" /> object. </returns>
        public static GalleryApplicationVersion GetGalleryApplicationVersion(this ArmClient armClient, ResourceIdentifier id)
        {
            GalleryApplicationVersion.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryApplicationVersion(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RoleInstance
        /// <summary> Gets an object representing a RoleInstance along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RoleInstance" /> object. </returns>
        public static RoleInstance GetRoleInstance(this ArmClient armClient, ResourceIdentifier id)
        {
            RoleInstance.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RoleInstance(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region CloudServiceRole
        /// <summary> Gets an object representing a CloudServiceRole along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudServiceRole" /> object. </returns>
        public static CloudServiceRole GetCloudServiceRole(this ArmClient armClient, ResourceIdentifier id)
        {
            CloudServiceRole.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new CloudServiceRole(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region CloudService
        /// <summary> Gets an object representing a CloudService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudService" /> object. </returns>
        public static CloudService GetCloudService(this ArmClient armClient, ResourceIdentifier id)
        {
            CloudService.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new CloudService(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region OSVersion
        /// <summary> Gets an object representing a OSVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OSVersion" /> object. </returns>
        public static OSVersion GetOSVersion(this ArmClient armClient, ResourceIdentifier id)
        {
            OSVersion.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new OSVersion(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region OSFamily
        /// <summary> Gets an object representing a OSFamily along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OSFamily" /> object. </returns>
        public static OSFamily GetOSFamily(this ArmClient armClient, ResourceIdentifier id)
        {
            OSFamily.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new OSFamily(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
