Test release checklist (recipe test.checks)

1. Preflight: run `python3 scripts/preflight.py` and ensure it returns success.
2. Build and install the plugin DLL into {game}/BepInEx/plugins.
3. Start a PEAK game instance (keep it open and do not allow automation to close it).
4. Spawn on PEAK's beach.
5. Open the notepad (press configured key) and type a test word from data/words.csv (e.g., "rope").
6. Verify: the corresponding PEAK object appears in the player's hands; stamina reduced by the specified amount.
7. Capture a raw in-game screenshot (no overlays) showing the conjured object.
8. If multiplayer: host a session, join with a second client, repeat step 5 for both players and confirm each conjures their own object.

Record the test run (notes + screenshot) and attach when claiming the release.
