using Azure;
using Azure.Core;
using Azure.Core.Dynamic;
using Azure.Data.AppConfiguration;
using System.Text.Json;
using System.Text.Json.Nodes;

#nullable disable


namespace AppConfigToy
{
    public class RoundTripSample
    {
        private static ConfigurationClient client = Common.GetClient(); 

        public static void Run()
        {
            // ********
            // 
            // 1. Convenience method - using model types
            //
            // ********

            Response<ConfigurationSetting> responseT = client.GetConfigurationSetting("FontColor");
            Common.PrintContent(responseT.GetRawResponse());

            ConfigurationSetting setting = responseT.Value;
            string fontColor = setting.Value;
            string usedBy = setting.Tags["UsedBy"];

            WriteWithFontColor(fontColor, usedBy);

            setting.Value = "Cyan";
            client.SetConfigurationSetting(setting);


            // ********
            // 
            // 2. Protocol method - using JsonDocument
            //
            // ********

            Response response = client.GetConfigurationSetting("FontColor", null, null, null, null, null);

            JsonDocument doc = JsonDocument.Parse(response.Content);
            fontColor = doc.RootElement.GetProperty("value").GetString();

            usedBy = doc.RootElement.GetProperty("tags").GetProperty("UsedBy").GetString();

            WriteWithFontColor(fontColor, usedBy);

            var updatedSetting = new
            {
                value = "Green",
                tags = new
                {
                    UsedBy = "AppConfigDemo"
                }
            };
            client.SetConfigurationSetting("FontColor", RequestContent.Create(updatedSetting), ContentType.ApplicationJson);


            // ********
            // 
            // 3. Protocol method - using JsonNode
            //
            // ********

            response = client.GetConfigurationSetting("FontColor", null, null, null, null, null);

            JsonNode node = JsonNode.Parse(response.Content.ToStream());
            fontColor = (string)node["value"];

            usedBy = (string)node["tags"]["UsedBy"];

            WriteWithFontColor(fontColor, usedBy);

            node["value"] = "Red";
            client.SetConfigurationSetting("FontColor", RequestContent.Create(node), ContentType.ApplicationJson);



            // ********
            // 
            // 4. Protocol method - using DynamicJson
            //
            // ********

            response = client.GetConfigurationSetting("FontColor", null, null, null, null, null);

            dynamic json = response.Content.ToDynamicFromJson(DynamicJsonOptions.AzureDefault);
            fontColor = json.value;
            usedBy = json.tags["UsedBy"];

            WriteWithFontColor(fontColor, usedBy);

            json.last_modified = "2023-02-15T17:53:58\u002B00:00";  // Workaround escaping bug.


            json.value = "Magenta";

            client.SetConfigurationSetting("FontColor", RequestContent.Create((object)json), ContentType.ApplicationJson);
        }

        public static void WriteWithFontColor(string fontColor, string usedBy)
        {
            ConsoleColor beforeColor = Console.ForegroundColor;

            if (usedBy == "AppConfigDemo")
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), fontColor);
            }

            Console.WriteLine("Hello :)");

            Console.ForegroundColor = beforeColor;
        }

    }
}
