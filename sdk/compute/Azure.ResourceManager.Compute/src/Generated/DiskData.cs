// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the Disk data model. </summary>
    public partial class DiskData : TrackedResource
    {
        /// <summary> Initializes a new instance of DiskData. </summary>
        /// <param name="location"> The location. </param>
        public DiskData(AzureLocation location) : base(location)
        {
            ManagedByExtended = new ChangeTrackingList<string>();
            Zones = new ChangeTrackingList<string>();
            ShareInfo = new ChangeTrackingList<ShareInfoElement>();
        }

        /// <summary> Initializes a new instance of DiskData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedBy"> A relative URI containing the ID of the VM that has the disk attached. </param>
        /// <param name="managedByExtended"> List of relative URIs containing the IDs of the VMs that have the disk attached. maxShares should be set to a value greater than one for disks to allow attaching them to multiple VMs. </param>
        /// <param name="sku"> The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS, Premium_ZRS, or StandardSSD_ZRS. </param>
        /// <param name="zones"> The Logical zone list for Disk. </param>
        /// <param name="extendedLocation"> The extended location where the disk will be created. Extended location cannot be changed. </param>
        /// <param name="timeCreated"> The time when the disk was created. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="purchasePlan"> Purchase plan information for the the image from which the OS disk was created. E.g. - {name: 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}. </param>
        /// <param name="creationData"> Disk source information. CreationData information cannot be changed after the disk has been created. </param>
        /// <param name="diskSizeGB"> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </param>
        /// <param name="diskSizeBytes"> The size of the disk in bytes. This field is read only. </param>
        /// <param name="uniqueId"> Unique Guid identifying the resource. </param>
        /// <param name="encryptionSettingsCollection"> Encryption settings collection used for Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </param>
        /// <param name="provisioningState"> The disk provisioning state. </param>
        /// <param name="diskIopsReadWrite"> The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes. </param>
        /// <param name="diskMBpsReadWrite"> The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </param>
        /// <param name="diskIopsReadOnly"> The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One operation can transfer between 4k and 256k bytes. </param>
        /// <param name="diskMBpsReadOnly"> The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </param>
        /// <param name="diskState"> The state of the disk. </param>
        /// <param name="encryption"> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </param>
        /// <param name="maxShares"> The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time. </param>
        /// <param name="shareInfo"> Details of the list of all VMs that have the disk attached. maxShares should be set to a value greater than one for disks to allow attaching them to multiple VMs. </param>
        /// <param name="networkAccessPolicy"> Policy for accessing the disk via network. </param>
        /// <param name="diskAccessId"> ARM id of the DiskAccess resource for using private endpoints on disks. </param>
        /// <param name="tier"> Performance tier of the disk (e.g, P4, S10) as described here: https://azure.microsoft.com/en-us/pricing/details/managed-disks/. Does not apply to Ultra disks. </param>
        /// <param name="burstingEnabled"> Set to true to enable bursting beyond the provisioned performance target of the disk. Bursting is disabled by default. Does not apply to Ultra disks. </param>
        /// <param name="propertyUpdatesInProgress"> Properties of the disk for which update is pending. </param>
        /// <param name="supportsHibernation"> Indicates the OS on a disk supports hibernation. </param>
        /// <param name="securityProfile"> Contains the security related information for the resource. </param>
        internal DiskData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, string managedBy, IReadOnlyList<string> managedByExtended, DiskSku sku, IList<string> zones, ExtendedLocation extendedLocation, DateTimeOffset? timeCreated, OperatingSystemTypes? osType, HyperVGeneration? hyperVGeneration, PurchasePlanAutoGenerated purchasePlan, CreationData creationData, int? diskSizeGB, long? diskSizeBytes, string uniqueId, EncryptionSettingsCollection encryptionSettingsCollection, string provisioningState, long? diskIopsReadWrite, long? diskMBpsReadWrite, long? diskIopsReadOnly, long? diskMBpsReadOnly, DiskState? diskState, Encryption encryption, int? maxShares, IReadOnlyList<ShareInfoElement> shareInfo, NetworkAccessPolicy? networkAccessPolicy, string diskAccessId, string tier, bool? burstingEnabled, PropertyUpdatesInProgress propertyUpdatesInProgress, bool? supportsHibernation, DiskSecurityProfile securityProfile) : base(id, name, type, tags, location)
        {
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            Sku = sku;
            Zones = zones;
            ExtendedLocation = extendedLocation;
            TimeCreated = timeCreated;
            OsType = osType;
            HyperVGeneration = hyperVGeneration;
            PurchasePlan = purchasePlan;
            CreationData = creationData;
            DiskSizeGB = diskSizeGB;
            DiskSizeBytes = diskSizeBytes;
            UniqueId = uniqueId;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            ProvisioningState = provisioningState;
            DiskIopsReadWrite = diskIopsReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DiskIopsReadOnly = diskIopsReadOnly;
            DiskMBpsReadOnly = diskMBpsReadOnly;
            DiskState = diskState;
            Encryption = encryption;
            MaxShares = maxShares;
            ShareInfo = shareInfo;
            NetworkAccessPolicy = networkAccessPolicy;
            DiskAccessId = diskAccessId;
            Tier = tier;
            BurstingEnabled = burstingEnabled;
            PropertyUpdatesInProgress = propertyUpdatesInProgress;
            SupportsHibernation = supportsHibernation;
            SecurityProfile = securityProfile;
        }

        /// <summary> A relative URI containing the ID of the VM that has the disk attached. </summary>
        public string ManagedBy { get; }
        /// <summary> List of relative URIs containing the IDs of the VMs that have the disk attached. maxShares should be set to a value greater than one for disks to allow attaching them to multiple VMs. </summary>
        public IReadOnlyList<string> ManagedByExtended { get; }
        /// <summary> The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS, Premium_ZRS, or StandardSSD_ZRS. </summary>
        public DiskSku Sku { get; set; }
        /// <summary> The Logical zone list for Disk. </summary>
        public IList<string> Zones { get; }
        /// <summary> The extended location where the disk will be created. Extended location cannot be changed. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The time when the disk was created. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> The Operating System type. </summary>
        public OperatingSystemTypes? OsType { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> Purchase plan information for the the image from which the OS disk was created. E.g. - {name: 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}. </summary>
        public PurchasePlanAutoGenerated PurchasePlan { get; set; }
        /// <summary> Disk source information. CreationData information cannot be changed after the disk has been created. </summary>
        public CreationData CreationData { get; set; }
        /// <summary> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The size of the disk in bytes. This field is read only. </summary>
        public long? DiskSizeBytes { get; }
        /// <summary> Unique Guid identifying the resource. </summary>
        public string UniqueId { get; }
        /// <summary> Encryption settings collection used for Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </summary>
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }
        /// <summary> The disk provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes. </summary>
        public long? DiskIopsReadWrite { get; set; }
        /// <summary> The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </summary>
        public long? DiskMBpsReadWrite { get; set; }
        /// <summary> The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One operation can transfer between 4k and 256k bytes. </summary>
        public long? DiskIopsReadOnly { get; set; }
        /// <summary> The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </summary>
        public long? DiskMBpsReadOnly { get; set; }
        /// <summary> The state of the disk. </summary>
        public DiskState? DiskState { get; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public Encryption Encryption { get; set; }
        /// <summary> The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time. </summary>
        public int? MaxShares { get; set; }
        /// <summary> Details of the list of all VMs that have the disk attached. maxShares should be set to a value greater than one for disks to allow attaching them to multiple VMs. </summary>
        public IReadOnlyList<ShareInfoElement> ShareInfo { get; }
        /// <summary> Policy for accessing the disk via network. </summary>
        public NetworkAccessPolicy? NetworkAccessPolicy { get; set; }
        /// <summary> ARM id of the DiskAccess resource for using private endpoints on disks. </summary>
        public string DiskAccessId { get; set; }
        /// <summary> Performance tier of the disk (e.g, P4, S10) as described here: https://azure.microsoft.com/en-us/pricing/details/managed-disks/. Does not apply to Ultra disks. </summary>
        public string Tier { get; set; }
        /// <summary> Set to true to enable bursting beyond the provisioned performance target of the disk. Bursting is disabled by default. Does not apply to Ultra disks. </summary>
        public bool? BurstingEnabled { get; set; }
        /// <summary> Properties of the disk for which update is pending. </summary>
        public PropertyUpdatesInProgress PropertyUpdatesInProgress { get; }
        /// <summary> Indicates the OS on a disk supports hibernation. </summary>
        public bool? SupportsHibernation { get; set; }
        /// <summary> Contains the security related information for the resource. </summary>
        public DiskSecurityProfile SecurityProfile { get; set; }
    }
}
