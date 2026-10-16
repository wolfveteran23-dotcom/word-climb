# Word-Climb

Draft build metadata for the PEAK x Scribblenauts Unlimited mashup.

Title: Word-Climb
Tagline: Conjure Scribblenauts items to climb PEAK's heights
Description: "Word-Climb is a PEAK x Scribblenauts Unlimited mashup. Type words into a small notepad UI to conjure Scribblenauts items (rope, ladder, balloon, etc.) and use them to climb PEAK's cliffs. Each conjure uses stamina; riskier words cost more. Requires your own Scribblenauts Unlimited install; the mod reads words, icons and sounds from your copy at runtime. Multiplayer co-op is supported through PEAK's own multiplayer. Credit: wolfveteran23-dotcom. License: CC BY-NC."

This repository contains the initial mod scaffold for a BepInEx plugin intended for a PEAK host game and a companion Scribblenauts Unlimited install. The mod is designed to read runtime data from the player's own Scribblenauts installation without copying assets into the upload.

## Project status
- Draft only
- No in-game tests yet
- No local game launch or multiplayer session has been started

## Repository layout
- `src/WordClimb/` — PEAK/BepInEx plugin skeleton
- `data/words_objects.csv` — starter word-to-object/stamina mapping
- `docs/` — hook docs and preflight checklist
- `recipe/test.checks` — automated gameplay test mode recipe
- `melty/pack_config.json` — Melty pack manifest (placeholder launch URL until the real Melty link is provided)

## License
CC BY-NC. Credit: wolfveteran23-dotcom
