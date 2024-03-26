// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiCenter;

namespace Azure.ResourceManager.ApiCenter.Samples
{
    public partial class Sample_WorkspaceResource
    {
        // Workspaces_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkspacesGet()
        {
            // Generated from example definition: specification/apicenter/resource-manager/Microsoft.ApiCenter/stable/2024-03-01/examples/Workspaces_Get.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceResource created on azure
            // for more information of creating WorkspaceResource, please refer to the document of WorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-resources";
            string serviceName = "contoso";
            string workspaceName = "default";
            ResourceIdentifier workspaceResourceId = WorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceName);
            WorkspaceResource workspace = client.GetWorkspaceResource(workspaceResourceId);

            // invoke the operation
            WorkspaceResource result = await workspace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Workspaces_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkspacesCreateOrUpdate()
        {
            // Generated from example definition: specification/apicenter/resource-manager/Microsoft.ApiCenter/stable/2024-03-01/examples/Workspaces_CreateOrUpdate.json
            // this example is just showing the usage of "Workspaces_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceResource created on azure
            // for more information of creating WorkspaceResource, please refer to the document of WorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-resources";
            string serviceName = "contoso";
            string workspaceName = "default";
            ResourceIdentifier workspaceResourceId = WorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceName);
            WorkspaceResource workspace = client.GetWorkspaceResource(workspaceResourceId);

            // invoke the operation
            WorkspaceData data = new WorkspaceData();
            ArmOperation<WorkspaceResource> lro = await workspace.UpdateAsync(WaitUntil.Completed, data);
            WorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Workspaces_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WorkspacesDelete()
        {
            // Generated from example definition: specification/apicenter/resource-manager/Microsoft.ApiCenter/stable/2024-03-01/examples/Workspaces_Delete.json
            // this example is just showing the usage of "Workspaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceResource created on azure
            // for more information of creating WorkspaceResource, please refer to the document of WorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-resources";
            string serviceName = "contoso";
            string workspaceName = "default";
            ResourceIdentifier workspaceResourceId = WorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceName);
            WorkspaceResource workspace = client.GetWorkspaceResource(workspaceResourceId);

            // invoke the operation
            await workspace.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Workspaces_Head
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Head_WorkspacesHead()
        {
            // Generated from example definition: specification/apicenter/resource-manager/Microsoft.ApiCenter/stable/2024-03-01/examples/Workspaces_Head.json
            // this example is just showing the usage of "Workspaces_Head" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceResource created on azure
            // for more information of creating WorkspaceResource, please refer to the document of WorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso-resources";
            string serviceName = "contoso";
            string workspaceName = "default";
            ResourceIdentifier workspaceResourceId = WorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceName);
            WorkspaceResource workspace = client.GetWorkspaceResource(workspaceResourceId);

            // invoke the operation
            bool result = await workspace.HeadAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
