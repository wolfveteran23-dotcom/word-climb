# Word-Climb

PEAK x Scribblenauts Unlimited mashup mod (BepInEx plugin, Melty pack).

Overview
- Project name: Word-Climb
- Mashup: PEAK (primary, host) x Scribblenauts Unlimited (companion)
- Mod type: Unity plugin for PEAK, installed to {game}/BepInEx/plugins. Melty installs itself and passes Scribblenauts path as {game:custom-scribblenauts-unlimited}.

Player flow (first minute)
1. Player spawns on PEAK's beach.
2. Player presses configured key to open a small notepad UI.
3. Player types a word (e.g. "rope"). The mod looks up the word in the player's installed Scribblenauts data at runtime and conjures the mapped PEAK-side object for that player.

First version scope
- 10-15 words mapped to Scribblenauts entries and simple climbing helpers (rope, ladder, balloon, umbrella, hook, glider, etc.)
- Names, icons, and sounds are loaded from the player's Scribblenauts install at runtime. No assets are copied into this repository from Scribblenauts.
- Risky/powerful words consume stamina. See data/words.csv for sample numbers.

Multiplayer
- Uses PEAK's native multiplayer. Each player conjures their own items locally.
- Use PEAK's real player limit from game_info when configuring multiplayer tests.
- Run setup_multiplayer and test host + join with two game instances before claiming multiplayer works. If joining cannot be tested, document the limitation and leave connect out.

Development process & checks
- Run search_mashups and game_info before implementing features; report any similar mashups in one line.
- Maintain sheets for words, objects, stamina costs, and hooks under /data and /design.
- Run preflight (scripts/preflight.py) before every build; CI should run it too.
- Provide a test mode (test/recipe_test_checks.md) so test_release proves gameplay (conjuring) occurred, not just that the plugin started.

Important rules
- Inspect the installed Scribblenauts copy at runtime to find executable, folders and data formats. Do not include or upload any Scribblenauts assets or look-alikes in this repo.
- Ask the repository owner before starting a game or taking over mouse/keyboard. Never close a game the owner has open.
- Capture at least one real in-game screenshot (game only — no overlays) of a word being conjured for release verification.

Getting started
- Build: This repository contains a BepInEx plugin skeleton under src/.
- Installation (local test): compile the plugin DLL and copy it to {game}/BepInEx/plugins/WordClimb
- Preflight: python3 scripts/preflight.py

License: Other
