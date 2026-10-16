using BepInEx;
using UnityEngine;

namespace WordClimb
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class WordClimbPlugin : BaseUnityPlugin
    {
        public const string PluginGuid = "com.wolfveteran23.wordclimb";
        public const string PluginName = "WordClimb";
        public const string PluginVersion = "0.1.0";

        private void Awake()
        {
            Logger.LogInfo("WordClimb initialized.");
        }

        private void Update()
        {
            // Main hook point for input and word submission.
            // Real implementation will read the player's Scribblenauts install, map words to items,
            // and attach the created object to the player's hand while enforcing stamina costs.
        }
    }
}
