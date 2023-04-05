using Azure;
using Azure.Core.Dynamic;
using Azure.Data.AppConfiguration;
using System.Text.Json;
using System.Text.Json.Nodes;

#nullable disable


namespace AppConfigToy
{
    public class GetValueSample
    {
        private static ConfigurationClient client = Common.GetClient(); 

        public static void Run()
        {
            // ********
            // 
            // 1. Convenience method - using model types
            //
            // ********

            ConfigurationSetting setting = client.GetConfigurationSetting("FontColor");
            string fontColor = setting.Value;

            WriteWithFontColor(fontColor);



            // ********
            // 
            // 2. Protocol method - using JsonDocument
            //
            // ********

            Response response = client.GetConfigurationSetting("FontColor", null, null, null, null, null);

            JsonDocument doc = JsonDocument.Parse(response.Content);
            fontColor = doc.RootElement.GetProperty("value").GetString();

            WriteWithFontColor(fontColor);



            // ********
            // 
            // 3. Protocol method - using JsonNode
            //
            // ********

            response = client.GetConfigurationSetting("FontColor", null, null, null, null, null);

            JsonNode node = JsonNode.Parse(response.Content.ToStream());
            fontColor = (string)node["value"];

            WriteWithFontColor(fontColor);



            // ********
            // 
            // 4. Protocol method - using DynamicJson
            //
            // ********

            response = client.GetConfigurationSetting("FontColor", null, null, null, null, null);

            dynamic json = response.Content.ToDynamicFromJson(DynamicJsonOptions.AzureDefault);
            fontColor = json.value;

            WriteWithFontColor(fontColor);

        }

        public static void WriteWithFontColor(string fontColor)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), fontColor);
            Console.WriteLine("Hello :)");
        }
    }
}
