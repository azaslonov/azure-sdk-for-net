// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Labeling MLAssist configuration definition when MLAssist is enabled. </summary>
    public partial class MachineLearningAssistEnabledConfiguration : MachineLearningAssistConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningAssistEnabledConfiguration"/>. </summary>
        /// <param name="inferencingComputeBinding"> [Required] AML compute binding used in inferencing. </param>
        /// <param name="trainingComputeBinding"> [Required] AML compute binding used in training. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inferencingComputeBinding"/> or <paramref name="trainingComputeBinding"/> is null. </exception>
        public MachineLearningAssistEnabledConfiguration(string inferencingComputeBinding, string trainingComputeBinding)
        {
            Argument.AssertNotNull(inferencingComputeBinding, nameof(inferencingComputeBinding));
            Argument.AssertNotNull(trainingComputeBinding, nameof(trainingComputeBinding));

            InferencingComputeBinding = inferencingComputeBinding;
            TrainingComputeBinding = trainingComputeBinding;
            MlAssist = MLAssistConfigurationType.Enabled;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAssistEnabledConfiguration"/>. </summary>
        /// <param name="mlAssist"> [Required] Indicates whether MLAssist feature is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="inferencingComputeBinding"> [Required] AML compute binding used in inferencing. </param>
        /// <param name="trainingComputeBinding"> [Required] AML compute binding used in training. </param>
        internal MachineLearningAssistEnabledConfiguration(MLAssistConfigurationType mlAssist, IDictionary<string, BinaryData> serializedAdditionalRawData, string inferencingComputeBinding, string trainingComputeBinding) : base(mlAssist, serializedAdditionalRawData)
        {
            InferencingComputeBinding = inferencingComputeBinding;
            TrainingComputeBinding = trainingComputeBinding;
            MlAssist = mlAssist;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAssistEnabledConfiguration"/> for deserialization. </summary>
        internal MachineLearningAssistEnabledConfiguration()
        {
        }

        /// <summary> [Required] AML compute binding used in inferencing. </summary>
        public string InferencingComputeBinding { get; set; }
        /// <summary> [Required] AML compute binding used in training. </summary>
        public string TrainingComputeBinding { get; set; }
    }
}
