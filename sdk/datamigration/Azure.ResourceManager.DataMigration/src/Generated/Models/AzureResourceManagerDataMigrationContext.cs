// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// Context class which will be filled in by the System.ClientModel.SourceGeneration.
    /// For more information see 'https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/System.ClientModel/src/docs/ModelReaderWriterContext.md'
    /// </summary>
    [ModelReaderWriterBuildable(typeof(CheckOciDriverTaskInput))]
    [ModelReaderWriterBuildable(typeof(CheckOciDriverTaskOutput))]
    [ModelReaderWriterBuildable(typeof(CheckOciDriverTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToMongoDBTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceMySqlTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceMySqlTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceNonSqlTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceOracleSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceOracleSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceOracleSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourcePostgreSqlSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourcePostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourcePostgreSqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerTaskOutputAgentJobLevel))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerTaskOutputLoginLevel))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerTaskOutputTaskLevel))]
    [ModelReaderWriterBuildable(typeof(ConnectToSourceSqlServerTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetAzureDBForMySqlTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetAzureDBForMySqlTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetAzureDBForMySqlTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetAzureDBForPostgreSqlSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetAzureDBForPostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetAzureDBForPostgreSqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlDBSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlDBSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlDBTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlDBTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlDBTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlMISyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlMISyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlMISyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlMITaskInput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlMITaskOutput))]
    [ModelReaderWriterBuildable(typeof(ConnectToTargetSqlMITaskProperties))]
    [ModelReaderWriterBuildable(typeof(CopyProgressDetails))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigration))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationBaseProperties))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationListResult))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationProperties))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlDBData))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlDBProperties))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlDBResource))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlMIData))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlMIProperties))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlMIResource))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlVmData))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlVmProperties))]
    [ModelReaderWriterBuildable(typeof(DatabaseMigrationSqlVmResource))]
    [ModelReaderWriterBuildable(typeof(DataIntegrityValidationResult))]
    [ModelReaderWriterBuildable(typeof(DataMigrationAadApp))]
    [ModelReaderWriterBuildable(typeof(DataMigrationAvailableServiceSku))]
    [ModelReaderWriterBuildable(typeof(DataMigrationAvailableServiceSkuCapacity))]
    [ModelReaderWriterBuildable(typeof(DataMigrationAvailableServiceSkuDetails))]
    [ModelReaderWriterBuildable(typeof(DataMigrationBackupConfiguration))]
    [ModelReaderWriterBuildable(typeof(DataMigrationBackupFileInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationBackupSetInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationBackupSourceLocation))]
    [ModelReaderWriterBuildable(typeof(DataMigrationBackupTargetLocation))]
    [ModelReaderWriterBuildable(typeof(DataMigrationBlobShare))]
    [ModelReaderWriterBuildable(typeof(DataMigrationCommandProperties))]
    [ModelReaderWriterBuildable(typeof(DataMigrationDatabaseBackupInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationDatabaseFileInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationDatabaseTable))]
    [ModelReaderWriterBuildable(typeof(DataMigrationFileShareInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationFileStorageInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMISqlConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBCancelCommand))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBClusterInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBCollectionInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBCollectionProgress))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBCollectionSettings))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBCommandInput))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBDatabaseInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBDatabaseProgress))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBDatabaseSettings))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBError))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBFinishCommand))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBFinishCommandInput))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBMigrationProgress))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBMigrationSettings))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBObjectInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBProgress))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBRestartCommand))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBShardKeyField))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBShardKeyInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBShardKeySetting))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMongoDBThrottlingSettings))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMySqlConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationMySqlServerProperties))]
    [ModelReaderWriterBuildable(typeof(DataMigrationODataError))]
    [ModelReaderWriterBuildable(typeof(DataMigrationOfflineConfiguration))]
    [ModelReaderWriterBuildable(typeof(DataMigrationOracleConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationOracleOciDriverInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationPostgreSqlConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectData))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectDatabaseInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectFileData))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectFileProperties))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectFileResource))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectResource))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectTaskData))]
    [ModelReaderWriterBuildable(typeof(DataMigrationProjectTaskProperties))]
    [ModelReaderWriterBuildable(typeof(DataMigrationQuota))]
    [ModelReaderWriterBuildable(typeof(DataMigrationQuotaName))]
    [ModelReaderWriterBuildable(typeof(DataMigrationReportableException))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceData))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceList))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceNameAvailabilityContent))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceNameAvailabilityResult))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceResource))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceSku))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceStatusResponse))]
    [ModelReaderWriterBuildable(typeof(DataMigrationServiceTaskResource))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSku))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSkuCapabilities))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSkuCapacity))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSkuCosts))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSkuRestrictions))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlBackupFileInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlBackupSetInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlConnectionInformation))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlDBMigrationStatusDetails))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlDBOfflineConfiguration))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlFileShare))]
    [ModelReaderWriterBuildable(typeof(DataMigrationSqlServerOrphanedUserInfo))]
    [ModelReaderWriterBuildable(typeof(DataMigrationStatusDetails))]
    [ModelReaderWriterBuildable(typeof(DeletedIntegrationRuntimeNodeResult))]
    [ModelReaderWriterBuildable(typeof(ExecutionStatistics))]
    [ModelReaderWriterBuildable(typeof(FileList))]
    [ModelReaderWriterBuildable(typeof(GetTdeCertificatesSqlTaskInput))]
    [ModelReaderWriterBuildable(typeof(GetTdeCertificatesSqlTaskOutput))]
    [ModelReaderWriterBuildable(typeof(GetTdeCertificatesSqlTaskProperties))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesMySqlTaskInput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesMySqlTaskOutput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesMySqlTaskProperties))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesOracleTaskInput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesOracleTaskOutput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesOracleTaskProperties))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesPostgreSqlTaskInput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesPostgreSqlTaskOutput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesPostgreSqlTaskProperties))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesSqlSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesSqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesSqlTaskInput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesSqlTaskOutput))]
    [ModelReaderWriterBuildable(typeof(GetUserTablesSqlTaskProperties))]
    [ModelReaderWriterBuildable(typeof(InstallOciDriverTaskInput))]
    [ModelReaderWriterBuildable(typeof(InstallOciDriverTaskOutput))]
    [ModelReaderWriterBuildable(typeof(InstallOciDriverTaskProperties))]
    [ModelReaderWriterBuildable(typeof(IntegrationRuntimeMonitoringNode))]
    [ModelReaderWriterBuildable(typeof(IntegrationRuntimeMonitoringResult))]
    [ModelReaderWriterBuildable(typeof(ManagedServiceIdentity))]
    [ModelReaderWriterBuildable(typeof(MigrateMISyncCompleteCommandInput))]
    [ModelReaderWriterBuildable(typeof(MigrateMISyncCompleteCommandOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateMISyncCompleteCommandProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateMongoDBTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineTaskOutputTableLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlOfflineTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskOutputTableLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateMySqlAzureDBForMySqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBForPostgreSqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputTableLevel))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel))]
    [ModelReaderWriterBuildable(typeof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlServerSqlDBDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlServerSqlDBTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlServerSqlDBTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlServerSqlDBTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlServerSqlDBTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlServerSqlDBTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlServerSqlDBTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateSchemaSqlTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskOutputDatabaseError))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskOutputTableLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskOutputTableLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskOutputValidationResult))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlDBTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMIDatabaseInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMISyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMISyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMISyncTaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMISyncTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMISyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskOutputAgentJobLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskOutputDatabaseLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskOutputError))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskOutputLoginLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSqlServerSqlMITaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateSsisTaskInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSsisTaskOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateSsisTaskOutputMigrationLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSsisTaskOutputProjectLevel))]
    [ModelReaderWriterBuildable(typeof(MigrateSsisTaskProperties))]
    [ModelReaderWriterBuildable(typeof(MigrateSyncCompleteCommandInput))]
    [ModelReaderWriterBuildable(typeof(MigrateSyncCompleteCommandOutput))]
    [ModelReaderWriterBuildable(typeof(MigrateSyncCompleteCommandProperties))]
    [ModelReaderWriterBuildable(typeof(MigrationEligibilityInfo))]
    [ModelReaderWriterBuildable(typeof(MigrationOperationInput))]
    [ModelReaderWriterBuildable(typeof(MigrationReportResult))]
    [ModelReaderWriterBuildable(typeof(MigrationValidationDatabaseSummaryResult))]
    [ModelReaderWriterBuildable(typeof(MigrationValidationError))]
    [ModelReaderWriterBuildable(typeof(MigrationValidationOptions))]
    [ModelReaderWriterBuildable(typeof(MigrationValidationResult))]
    [ModelReaderWriterBuildable(typeof(MigrationValidationWaitStatistics))]
    [ModelReaderWriterBuildable(typeof(ProjectList))]
    [ModelReaderWriterBuildable(typeof(QueryAnalysisValidationResult))]
    [ModelReaderWriterBuildable(typeof(QueryExecutionResult))]
    [ModelReaderWriterBuildable(typeof(QuotaList))]
    [ModelReaderWriterBuildable(typeof(ResourceSkusResult))]
    [ModelReaderWriterBuildable(typeof(SchemaComparisonValidationResult))]
    [ModelReaderWriterBuildable(typeof(SchemaComparisonValidationResultType))]
    [ModelReaderWriterBuildable(typeof(SchemaMigrationSetting))]
    [ModelReaderWriterBuildable(typeof(SelectedCertificateInput))]
    [ModelReaderWriterBuildable(typeof(ServerConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(ServiceServiceTaskResource))]
    [ModelReaderWriterBuildable(typeof(ServiceSkuList))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationAuthenticationKeys))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationBlobDetails))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationErrorInfo))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationListResult))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationRegenAuthKeys))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationServiceData))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationServicePatch))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationServiceResource))]
    [ModelReaderWriterBuildable(typeof(SqlMigrationTaskInput))]
    [ModelReaderWriterBuildable(typeof(SqlServerSqlMISyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(SsisMigrationInfo))]
    [ModelReaderWriterBuildable(typeof(SyncMigrationDatabaseErrorEvent))]
    [ModelReaderWriterBuildable(typeof(SystemData))]
    [ModelReaderWriterBuildable(typeof(TaskList))]
    [ModelReaderWriterBuildable(typeof(UnknownCommandProperties))]
    [ModelReaderWriterBuildable(typeof(UnknownConnectionInfo))]
    [ModelReaderWriterBuildable(typeof(UnknownConnectToSourceSqlServerTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownDatabaseMigrationBaseProperties))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateMySqlAzureDBForMySqlOfflineTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateMySqlAzureDBForMySqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateSchemaSqlServerSqlDBTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateSqlServerSqlDBSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateSqlServerSqlDBTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateSqlServerSqlMISyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateSqlServerSqlMITaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMigrateSsisTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UnknownMongoDBProgress))]
    [ModelReaderWriterBuildable(typeof(UnknownProjectTaskProperties))]
    [ModelReaderWriterBuildable(typeof(UploadOciDriverTaskInput))]
    [ModelReaderWriterBuildable(typeof(UploadOciDriverTaskOutput))]
    [ModelReaderWriterBuildable(typeof(UploadOciDriverTaskProperties))]
    [ModelReaderWriterBuildable(typeof(UserAssignedIdentity))]
    [ModelReaderWriterBuildable(typeof(ValidateMigrationInputSqlServerSqlDBSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ValidateMigrationInputSqlServerSqlMISyncTaskInput))]
    [ModelReaderWriterBuildable(typeof(ValidateMigrationInputSqlServerSqlMISyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ValidateMigrationInputSqlServerSqlMISyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ValidateMigrationInputSqlServerSqlMITaskInput))]
    [ModelReaderWriterBuildable(typeof(ValidateMigrationInputSqlServerSqlMITaskOutput))]
    [ModelReaderWriterBuildable(typeof(ValidateMigrationInputSqlServerSqlMITaskProperties))]
    [ModelReaderWriterBuildable(typeof(ValidateMongoDBTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ValidateOracleAzureDBForPostgreSqlSyncTaskProperties))]
    [ModelReaderWriterBuildable(typeof(ValidateOracleAzureDBPostgreSqlSyncTaskOutput))]
    [ModelReaderWriterBuildable(typeof(ValidateSyncMigrationInputSqlServerTaskInput))]
    [ModelReaderWriterBuildable(typeof(ValidateSyncMigrationInputSqlServerTaskOutput))]
    public partial class AzureResourceManagerDataMigrationContext : ModelReaderWriterContext
    {
    }
}
