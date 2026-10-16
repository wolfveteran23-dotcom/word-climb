# Game hooks contract

## Primary design
- PEAK acts as the host game and primary runtime environment.
- Scribblenauts Unlimited acts as the companion game and data source.
- Melty is used to merge the purchased games; the mod reads the player's own Scribblenauts install at runtime and does not copy or upload assets from it.

## Required runtime hooks
### Input
- Small notepad UI bound to a key (default: N)
- Submit typed word to a lookup layer
- Validate before conjuring

### Word lookup
- Read words and object names from the local Scribblenauts install at runtime
- Resolve icon path, sound path, and display name
- Match the typed word to a real Scribblenauts entry

### Conjure / item attach
- Spawn an object on PEAK side for the local player
- Attach the object to the player's hand or near-hands position
- Use a PEAK object reference compatible with the host's prefab system

### Stamina costs
- Risky or powerful words cost stamina
- Costs must be tracked per player and enforced before spawn

### Multiplayer
- Use PEAK's real multiplayer player limit from game_info
- Each player conjures their own items in co-op
- The host/peer logic must not create objects for other players without permission

### Data source contract
- Do not copy any icons/sounds directly into the upload
- Use runtime file path resolution to read the player's own Scribblenauts directory
- Permit a specific env var or config path, e.g. `SCRIBBLE_PATH`, `game:custom-scribblenauts-unlimited`, or a Melty folder mapping
