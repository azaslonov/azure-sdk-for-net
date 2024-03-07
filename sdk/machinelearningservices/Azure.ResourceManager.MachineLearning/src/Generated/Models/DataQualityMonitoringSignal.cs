// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DataQualityMonitoringSignal. </summary>
    public partial class DataQualityMonitoringSignal : MonitoringSignalBase
    {
        /// <summary> Initializes a new instance of <see cref="DataQualityMonitoringSignal"/>. </summary>
        /// <param name="metricThresholds">
        /// [Required] A list of metrics to calculate and their associated thresholds.
        /// Please note <see cref="DataQualityMetricThresholdBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CategoricalDataQualityMetricThreshold"/> and <see cref="NumericalDataQualityMetricThreshold"/>.
        /// </param>
        /// <param name="productionData">
        /// [Required] The data produced by the production service which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricThresholds"/>, <paramref name="productionData"/> or <paramref name="referenceData"/> is null. </exception>
        public DataQualityMonitoringSignal(IEnumerable<DataQualityMetricThresholdBase> metricThresholds, MonitoringInputDataBase productionData, MonitoringInputDataBase referenceData)
        {
            Argument.AssertNotNull(metricThresholds, nameof(metricThresholds));
            Argument.AssertNotNull(productionData, nameof(productionData));
            Argument.AssertNotNull(referenceData, nameof(referenceData));

            FeatureDataTypeOverride = new ChangeTrackingDictionary<string, MonitoringFeatureDataType>();
            MetricThresholds = metricThresholds.ToList();
            ProductionData = productionData;
            ReferenceData = referenceData;
            SignalType = MonitoringSignalType.DataQuality;
        }

        /// <summary> Initializes a new instance of <see cref="DataQualityMonitoringSignal"/>. </summary>
        /// <param name="mode"> The current notification mode for this signal. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="signalType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="featureDataTypeOverride"> A dictionary that maps feature names to their respective data types. </param>
        /// <param name="features">
        /// The features to calculate drift over.
        /// Please note <see cref="MonitoringFeatureFilterBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAllFeatures"/>, <see cref="FeatureSubset"/> and <see cref="TopNFeaturesByAttribution"/>.
        /// </param>
        /// <param name="metricThresholds">
        /// [Required] A list of metrics to calculate and their associated thresholds.
        /// Please note <see cref="DataQualityMetricThresholdBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CategoricalDataQualityMetricThreshold"/> and <see cref="NumericalDataQualityMetricThreshold"/>.
        /// </param>
        /// <param name="productionData">
        /// [Required] The data produced by the production service which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        internal DataQualityMonitoringSignal(MonitoringNotificationMode? mode, IDictionary<string, string> properties, MonitoringSignalType signalType, IDictionary<string, BinaryData> serializedAdditionalRawData, IDictionary<string, MonitoringFeatureDataType> featureDataTypeOverride, MonitoringFeatureFilterBase features, IList<DataQualityMetricThresholdBase> metricThresholds, MonitoringInputDataBase productionData, MonitoringInputDataBase referenceData) : base(mode, properties, signalType, serializedAdditionalRawData)
        {
            FeatureDataTypeOverride = featureDataTypeOverride;
            Features = features;
            MetricThresholds = metricThresholds;
            ProductionData = productionData;
            ReferenceData = referenceData;
            SignalType = signalType;
        }

        /// <summary> Initializes a new instance of <see cref="DataQualityMonitoringSignal"/> for deserialization. </summary>
        internal DataQualityMonitoringSignal()
        {
        }

        /// <summary> A dictionary that maps feature names to their respective data types. </summary>
        public IDictionary<string, MonitoringFeatureDataType> FeatureDataTypeOverride { get; set; }
        /// <summary>
        /// The features to calculate drift over.
        /// Please note <see cref="MonitoringFeatureFilterBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAllFeatures"/>, <see cref="FeatureSubset"/> and <see cref="TopNFeaturesByAttribution"/>.
        /// </summary>
        public MonitoringFeatureFilterBase Features { get; set; }
        /// <summary>
        /// [Required] A list of metrics to calculate and their associated thresholds.
        /// Please note <see cref="DataQualityMetricThresholdBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CategoricalDataQualityMetricThreshold"/> and <see cref="NumericalDataQualityMetricThreshold"/>.
        /// </summary>
        public IList<DataQualityMetricThresholdBase> MetricThresholds { get; }
        /// <summary>
        /// [Required] The data produced by the production service which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public MonitoringInputDataBase ProductionData { get; set; }
        /// <summary>
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public MonitoringInputDataBase ReferenceData { get; set; }
    }
}
