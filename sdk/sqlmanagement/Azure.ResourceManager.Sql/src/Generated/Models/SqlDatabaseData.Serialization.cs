// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlDatabaseData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes");
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(SampleName))
            {
                writer.WritePropertyName("sampleName");
                writer.WriteStringValue(SampleName.Value.ToString());
            }
            if (Optional.IsDefined(ElasticPoolId))
            {
                writer.WritePropertyName("elasticPoolId");
                writer.WriteStringValue(ElasticPoolId);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId");
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime");
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(SourceDatabaseDeletionDate))
            {
                writer.WritePropertyName("sourceDatabaseDeletionDate");
                writer.WriteStringValue(SourceDatabaseDeletionDate.Value, "O");
            }
            if (Optional.IsDefined(RecoveryServicesRecoveryPointId))
            {
                writer.WritePropertyName("recoveryServicesRecoveryPointId");
                writer.WriteStringValue(RecoveryServicesRecoveryPointId);
            }
            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId");
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId");
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("restorableDroppedDatabaseId");
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(CatalogCollation))
            {
                writer.WritePropertyName("catalogCollation");
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (Optional.IsDefined(ZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(ZoneRedundant.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(ReadScale))
            {
                writer.WritePropertyName("readScale");
                writer.WriteStringValue(ReadScale.Value.ToString());
            }
            if (Optional.IsDefined(HighAvailabilityReplicaCount))
            {
                writer.WritePropertyName("highAvailabilityReplicaCount");
                writer.WriteNumberValue(HighAvailabilityReplicaCount.Value);
            }
            if (Optional.IsDefined(SecondaryType))
            {
                writer.WritePropertyName("secondaryType");
                writer.WriteStringValue(SecondaryType.Value.ToString());
            }
            if (Optional.IsDefined(AutoPauseDelay))
            {
                writer.WritePropertyName("autoPauseDelay");
                writer.WriteNumberValue(AutoPauseDelay.Value);
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy");
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity");
                writer.WriteNumberValue(MinCapacity.Value);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId");
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(IsLedgerOn))
            {
                writer.WritePropertyName("isLedgerOn");
                writer.WriteBooleanValue(IsLedgerOn.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SqlDatabaseData DeserializeSqlDatabaseData(JsonElement element)
        {
            Optional<Sku> sku = default;
            Optional<string> kind = default;
            Optional<string> managedBy = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<CreateMode> createMode = default;
            Optional<string> collation = default;
            Optional<long> maxSizeBytes = default;
            Optional<SampleSchemaName> sampleName = default;
            Optional<string> elasticPoolId = default;
            Optional<string> sourceDatabaseId = default;
            Optional<DatabaseStatus> status = default;
            Optional<Guid> databaseId = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<string> currentServiceObjectiveName = default;
            Optional<string> requestedServiceObjectiveName = default;
            Optional<string> defaultSecondaryLocation = default;
            Optional<string> failoverGroupId = default;
            Optional<DateTimeOffset> restorePointInTime = default;
            Optional<DateTimeOffset> sourceDatabaseDeletionDate = default;
            Optional<string> recoveryServicesRecoveryPointId = default;
            Optional<string> longTermRetentionBackupResourceId = default;
            Optional<string> recoverableDatabaseId = default;
            Optional<string> restorableDroppedDatabaseId = default;
            Optional<CatalogCollationType> catalogCollation = default;
            Optional<bool> zoneRedundant = default;
            Optional<DatabaseLicenseType> licenseType = default;
            Optional<long> maxLogSizeBytes = default;
            Optional<DateTimeOffset> earliestRestoreDate = default;
            Optional<DatabaseReadScale> readScale = default;
            Optional<int> highAvailabilityReplicaCount = default;
            Optional<SecondaryType> secondaryType = default;
            Optional<Sku> currentSku = default;
            Optional<int> autoPauseDelay = default;
            Optional<CurrentBackupStorageRedundancy> currentBackupStorageRedundancy = default;
            Optional<RequestedBackupStorageRedundancy> requestedBackupStorageRedundancy = default;
            Optional<double> minCapacity = default;
            Optional<DateTimeOffset> pausedDate = default;
            Optional<DateTimeOffset> resumedDate = default;
            Optional<string> maintenanceConfigurationId = default;
            Optional<bool> isLedgerOn = default;
            Optional<bool> isInfraEncryptionEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createMode = new CreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("collation"))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxSizeBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sampleName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sampleName = new SampleSchemaName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("elasticPoolId"))
                        {
                            elasticPoolId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseId"))
                        {
                            sourceDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new DatabaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            databaseId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("currentServiceObjectiveName"))
                        {
                            currentServiceObjectiveName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedServiceObjectiveName"))
                        {
                            requestedServiceObjectiveName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultSecondaryLocation"))
                        {
                            defaultSecondaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("failoverGroupId"))
                        {
                            failoverGroupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseDeletionDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceDatabaseDeletionDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recoveryServicesRecoveryPointId"))
                        {
                            recoveryServicesRecoveryPointId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("longTermRetentionBackupResourceId"))
                        {
                            longTermRetentionBackupResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recoverableDatabaseId"))
                        {
                            recoverableDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restorableDroppedDatabaseId"))
                        {
                            restorableDroppedDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("catalogCollation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            catalogCollation = new CatalogCollationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            licenseType = new DatabaseLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxLogSizeBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxLogSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("earliestRestoreDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            earliestRestoreDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("readScale"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            readScale = new DatabaseReadScale(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("highAvailabilityReplicaCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            highAvailabilityReplicaCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("secondaryType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            secondaryType = new SecondaryType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("currentSku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            currentSku = Sku.DeserializeSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoPauseDelay"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoPauseDelay = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentBackupStorageRedundancy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            currentBackupStorageRedundancy = new CurrentBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestedBackupStorageRedundancy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requestedBackupStorageRedundancy = new RequestedBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minCapacity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minCapacity = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("pausedDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            pausedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resumedDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resumedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"))
                        {
                            maintenanceConfigurationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isLedgerOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isLedgerOn = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isInfraEncryptionEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isInfraEncryptionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SqlDatabaseData(id, name, type, tags, location, sku.Value, kind.Value, managedBy.Value, Optional.ToNullable(createMode), collation.Value, Optional.ToNullable(maxSizeBytes), Optional.ToNullable(sampleName), elasticPoolId.Value, sourceDatabaseId.Value, Optional.ToNullable(status), Optional.ToNullable(databaseId), Optional.ToNullable(creationDate), currentServiceObjectiveName.Value, requestedServiceObjectiveName.Value, defaultSecondaryLocation.Value, failoverGroupId.Value, Optional.ToNullable(restorePointInTime), Optional.ToNullable(sourceDatabaseDeletionDate), recoveryServicesRecoveryPointId.Value, longTermRetentionBackupResourceId.Value, recoverableDatabaseId.Value, restorableDroppedDatabaseId.Value, Optional.ToNullable(catalogCollation), Optional.ToNullable(zoneRedundant), Optional.ToNullable(licenseType), Optional.ToNullable(maxLogSizeBytes), Optional.ToNullable(earliestRestoreDate), Optional.ToNullable(readScale), Optional.ToNullable(highAvailabilityReplicaCount), Optional.ToNullable(secondaryType), currentSku.Value, Optional.ToNullable(autoPauseDelay), Optional.ToNullable(currentBackupStorageRedundancy), Optional.ToNullable(requestedBackupStorageRedundancy), Optional.ToNullable(minCapacity), Optional.ToNullable(pausedDate), Optional.ToNullable(resumedDate), maintenanceConfigurationId.Value, Optional.ToNullable(isLedgerOn), Optional.ToNullable(isInfraEncryptionEnabled));
        }
    }
}
