using BepInEx;
using BepInEx.Logging;
using UnityEngine;
using System.Collections.Generic;

namespace WordClimb
{
    [BepInPlugin("com.wolfveteran23.wordclimb", "WordClimb", "0.1.0")]
    public class WordClimbPlugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log;

        // Simple in-memory word table loaded at runtime from player's Scribblenauts install
        private Dictionary<string, WordEntry> wordTable = new Dictionary<string, WordEntry>();

        private void Awake()
        {
            Log = Logger;
            Log.LogInfo("WordClimb: Awake — plugin loaded");

            // TODO: discover the Scribblenauts install path passed by Melty in runtime args
            // TODO: load word/object sheets from the player's Scribblenauts data
            // Keep this repository free of any Scribblenauts assets — only read at runtime.

            // Register input hooks and multiplayer setup here
        }

        private void Update()
        {
            // Placeholder: listen for notepad open key and show a simple UI
            // Real input hooking and hand/item spawning implemented in later commits
        }

        // Example staging structure for a word entry
        private class WordEntry
        {
            public string ScribbleName;
            public string IconPath; // runtime-resolved path in player's install
            public string SoundPath; // runtime-resolved path in player's install
            public string PeakObjectId; // ID of the PEAK-side object prefab to spawn
            public int StaminaCost;
        }
    }
}
