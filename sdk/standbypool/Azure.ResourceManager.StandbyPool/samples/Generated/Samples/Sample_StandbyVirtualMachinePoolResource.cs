// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StandbyPool.Models;

namespace Azure.ResourceManager.StandbyPool.Samples
{
    public partial class Sample_StandbyVirtualMachinePoolResource
    {
        // StandbyVirtualMachinePools_ListBySubscription - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStandbyVirtualMachinePools_StandbyVirtualMachinePoolsListBySubscriptionGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (StandbyVirtualMachinePoolResource item in subscriptionResource.GetStandbyVirtualMachinePoolsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyVirtualMachinePoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // StandbyVirtualMachinePools_ListBySubscription - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStandbyVirtualMachinePools_StandbyVirtualMachinePoolsListBySubscriptionGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_ListBySubscription_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (StandbyVirtualMachinePoolResource item in subscriptionResource.GetStandbyVirtualMachinePoolsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyVirtualMachinePoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // StandbyVirtualMachinePools_Get - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StandbyVirtualMachinePoolsGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            StandbyVirtualMachinePoolResource result = await standbyVirtualMachinePool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachinePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyVirtualMachinePools_Get - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StandbyVirtualMachinePoolsGetGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            StandbyVirtualMachinePoolResource result = await standbyVirtualMachinePool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachinePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyVirtualMachinePools_Update - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_StandbyVirtualMachinePoolsUpdateGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            StandbyVirtualMachinePoolPatch patch = new StandbyVirtualMachinePoolPatch()
            {
                Tags =
{
},
                ElasticityMaxReadyCapacity = 304,
                VirtualMachineState = StandbyVirtualMachineState.Running,
                AttachedVirtualMachineScaleSetId = new ResourceIdentifier("/subscriptions/8CC31D61-82D7-4B2B-B9DC-6B924DE7D229/resourceGroups/vmssRg/providers/Microsoft.Compute/virtualMachineScaleSets/myVmss"),
            };
            StandbyVirtualMachinePoolResource result = await standbyVirtualMachinePool.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachinePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyVirtualMachinePools_Update - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_StandbyVirtualMachinePoolsUpdateGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            StandbyVirtualMachinePoolPatch patch = new StandbyVirtualMachinePoolPatch();
            StandbyVirtualMachinePoolResource result = await standbyVirtualMachinePool.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachinePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyVirtualMachinePools_Delete - generated by [MaximumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_StandbyVirtualMachinePoolsDeleteGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            await standbyVirtualMachinePool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // StandbyVirtualMachinePools_Delete - generated by [MinimumSet] rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_StandbyVirtualMachinePoolsDeleteGeneratedByMinimumSetRule()
        {
            // Generated from example definition: specification/standbypool/resource-manager/Microsoft.StandbyPool/preview/2023-12-01-preview/examples/StandbyVirtualMachinePools_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "8CC31D61-82D7-4B2B-B9DC-6B924DE7D229";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            await standbyVirtualMachinePool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
