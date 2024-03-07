// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Properties used to create a user on an Azure Batch node. </summary>
    public partial class BatchUserAccount
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchUserAccount"/>. </summary>
        /// <param name="name"> The name of the user account. Names can contain any Unicode characters up to a maximum length of 20. </param>
        /// <param name="password"> The password for the user account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="password"/> is null. </exception>
        public BatchUserAccount(string name, string password)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(password, nameof(password));

            Name = name;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="BatchUserAccount"/>. </summary>
        /// <param name="name"> The name of the user account. Names can contain any Unicode characters up to a maximum length of 20. </param>
        /// <param name="password"> The password for the user account. </param>
        /// <param name="elevationLevel"> nonAdmin - The auto user is a standard user without elevated access. admin - The auto user is a user with elevated access and operates with full Administrator permissions. The default value is nonAdmin. </param>
        /// <param name="linuxUserConfiguration"> This property is ignored if specified on a Windows pool. If not specified, the user is created with the default options. </param>
        /// <param name="windowsUserConfiguration"> This property can only be specified if the user is on a Windows pool. If not specified and on a Windows pool, the user is created with the default options. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchUserAccount(string name, string password, BatchUserAccountElevationLevel? elevationLevel, BatchLinuxUserConfiguration linuxUserConfiguration, BatchWindowsUserConfiguration windowsUserConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Password = password;
            ElevationLevel = elevationLevel;
            LinuxUserConfiguration = linuxUserConfiguration;
            WindowsUserConfiguration = windowsUserConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchUserAccount"/> for deserialization. </summary>
        internal BatchUserAccount()
        {
        }

        /// <summary> The name of the user account. Names can contain any Unicode characters up to a maximum length of 20. </summary>
        public string Name { get; set; }
        /// <summary> The password for the user account. </summary>
        public string Password { get; set; }
        /// <summary> nonAdmin - The auto user is a standard user without elevated access. admin - The auto user is a user with elevated access and operates with full Administrator permissions. The default value is nonAdmin. </summary>
        public BatchUserAccountElevationLevel? ElevationLevel { get; set; }
        /// <summary> This property is ignored if specified on a Windows pool. If not specified, the user is created with the default options. </summary>
        public BatchLinuxUserConfiguration LinuxUserConfiguration { get; set; }
        /// <summary> This property can only be specified if the user is on a Windows pool. If not specified and on a Windows pool, the user is created with the default options. </summary>
        internal BatchWindowsUserConfiguration WindowsUserConfiguration { get; set; }
        /// <summary> Specifies login mode for the user. The default value for VirtualMachineConfiguration pools is interactive mode and for CloudServiceConfiguration pools is batch mode. </summary>
        public BatchWindowsLoginMode? WindowsUserLoginMode
        {
            get => WindowsUserConfiguration is null ? default : WindowsUserConfiguration.LoginMode;
            set
            {
                if (WindowsUserConfiguration is null)
                    WindowsUserConfiguration = new BatchWindowsUserConfiguration();
                WindowsUserConfiguration.LoginMode = value;
            }
        }
    }
}
