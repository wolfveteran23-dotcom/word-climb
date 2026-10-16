# Preflight checklist

Run before every build:
- [ ] Confirm the repo `search_mashups` check has been run and any similar mashup is noted in one line.
- [ ] Confirm PEAK metadata and player limit are pulled from `game_info` before finalizing multiplayer support.
- [ ] Confirm the local Scribblenauts path or Melty mapping is present (runtime data only; no upload of any content from it).
- [ ] Confirm the plugin loads in the PEAK host environment under BepInEx.
- [ ] Confirm the word and object list is present and mapped to actual Scribblenauts entries.
- [ ] Confirm the notepad UI opens and accepts input within the first minute of spawn.
- [ ] Confirm the selected word spawns the correct PEAK object in the player's hands.
- [ ] Confirm stamina cost is deducted from the player's stamina pool.
- [ ] If multiplayer changes are touched, run `setup_multiplayer` and test host plus join with two game instances.
- [ ] Ensure the recipe test mode is available and the screenshot capture marker exists.
- [ ] Update the build metadata only after the pack is validated.
