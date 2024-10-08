// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Spark job definition. </summary>
    public partial class SparkJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="SparkJob"/>. </summary>
        /// <param name="codeId"> [Required] arm-id of the code asset. </param>
        /// <param name="entry">
        /// [Required] The entry to execute on startup of the job.
        /// Please note <see cref="SparkJobEntry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SparkJobPythonEntry"/> and <see cref="SparkJobScalaEntry"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="codeId"/> or <paramref name="entry"/> is null. </exception>
        public SparkJob(ResourceIdentifier codeId, SparkJobEntry entry)
        {
            Argument.AssertNotNull(codeId, nameof(codeId));
            Argument.AssertNotNull(entry, nameof(entry));

            CodeId = codeId;
            Entry = entry;
            Inputs = new ChangeTrackingDictionary<string, MachineLearningJobInput>();
            Outputs = new ChangeTrackingDictionary<string, MachineLearningJobOutput>();
            PyFiles = new ChangeTrackingList<string>();
            Jars = new ChangeTrackingList<string>();
            Files = new ChangeTrackingList<string>();
            Archives = new ChangeTrackingList<string>();
            Conf = new ChangeTrackingDictionary<string, string>();
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            JobType = JobType.Spark;
        }

        /// <summary> Initializes a new instance of <see cref="SparkJob"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="resources"> Compute Resource configuration for the job. </param>
        /// <param name="args"> Arguments for the job. </param>
        /// <param name="codeId"> [Required] arm-id of the code asset. </param>
        /// <param name="entry">
        /// [Required] The entry to execute on startup of the job.
        /// Please note <see cref="SparkJobEntry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SparkJobPythonEntry"/> and <see cref="SparkJobScalaEntry"/>.
        /// </param>
        /// <param name="environmentId"> The ARM resource ID of the Environment specification for the job. </param>
        /// <param name="inputs">
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="outputs">
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </param>
        /// <param name="pyFiles"> Python files used in the job. </param>
        /// <param name="jars"> Jar files used in the job. </param>
        /// <param name="files"> Files used in the job. </param>
        /// <param name="archives"> Archive files used in the job. </param>
        /// <param name="conf"> Spark configured properties. </param>
        /// <param name="queueSettings"> Queue settings for the job. </param>
        /// <param name="environmentVariables"> Environment variables included in the job. </param>
        internal SparkJob(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, JobType jobType, string displayName, MachineLearningJobStatus? status, string experimentName, IDictionary<string, MachineLearningJobService> services, ResourceIdentifier computeId, bool? isArchived, MachineLearningIdentityConfiguration identity, ResourceIdentifier componentId, NotificationSetting notificationSetting, SparkResourceConfiguration resources, string args, ResourceIdentifier codeId, SparkJobEntry entry, ResourceIdentifier environmentId, IDictionary<string, MachineLearningJobInput> inputs, IDictionary<string, MachineLearningJobOutput> outputs, IList<string> pyFiles, IList<string> jars, IList<string> files, IList<string> archives, IDictionary<string, string> conf, JobQueueSettings queueSettings, IDictionary<string, string> environmentVariables) : base(description, tags, properties, serializedAdditionalRawData, jobType, displayName, status, experimentName, services, computeId, isArchived, identity, componentId, notificationSetting)
        {
            Resources = resources;
            Args = args;
            CodeId = codeId;
            Entry = entry;
            EnvironmentId = environmentId;
            Inputs = inputs;
            Outputs = outputs;
            PyFiles = pyFiles;
            Jars = jars;
            Files = files;
            Archives = archives;
            Conf = conf;
            QueueSettings = queueSettings;
            EnvironmentVariables = environmentVariables;
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="SparkJob"/> for deserialization. </summary>
        internal SparkJob()
        {
        }

        /// <summary> Compute Resource configuration for the job. </summary>
        [WirePath("resources")]
        public SparkResourceConfiguration Resources { get; set; }
        /// <summary> Arguments for the job. </summary>
        [WirePath("args")]
        public string Args { get; set; }
        /// <summary> [Required] arm-id of the code asset. </summary>
        [WirePath("codeId")]
        public ResourceIdentifier CodeId { get; set; }
        /// <summary>
        /// [Required] The entry to execute on startup of the job.
        /// Please note <see cref="SparkJobEntry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SparkJobPythonEntry"/> and <see cref="SparkJobScalaEntry"/>.
        /// </summary>
        [WirePath("entry")]
        public SparkJobEntry Entry { get; set; }
        /// <summary> The ARM resource ID of the Environment specification for the job. </summary>
        [WirePath("environmentId")]
        public ResourceIdentifier EnvironmentId { get; set; }
        /// <summary>
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </summary>
        [WirePath("inputs")]
        public IDictionary<string, MachineLearningJobInput> Inputs { get; set; }
        /// <summary>
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </summary>
        [WirePath("outputs")]
        public IDictionary<string, MachineLearningJobOutput> Outputs { get; set; }
        /// <summary> Python files used in the job. </summary>
        [WirePath("pyFiles")]
        public IList<string> PyFiles { get; set; }
        /// <summary> Jar files used in the job. </summary>
        [WirePath("jars")]
        public IList<string> Jars { get; set; }
        /// <summary> Files used in the job. </summary>
        [WirePath("files")]
        public IList<string> Files { get; set; }
        /// <summary> Archive files used in the job. </summary>
        [WirePath("archives")]
        public IList<string> Archives { get; set; }
        /// <summary> Spark configured properties. </summary>
        [WirePath("conf")]
        public IDictionary<string, string> Conf { get; set; }
        /// <summary> Queue settings for the job. </summary>
        internal JobQueueSettings QueueSettings { get; set; }
        /// <summary> Controls the compute job tier. </summary>
        [WirePath("queueSettings.jobTier")]
        public JobTier? QueueJobTier
        {
            get => QueueSettings is null ? default : QueueSettings.JobTier;
            set
            {
                if (QueueSettings is null)
                    QueueSettings = new JobQueueSettings();
                QueueSettings.JobTier = value;
            }
        }

        /// <summary> Environment variables included in the job. </summary>
        [WirePath("environmentVariables")]
        public IDictionary<string, string> EnvironmentVariables { get; set; }
    }
}
