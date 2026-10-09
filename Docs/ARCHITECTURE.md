# Architecture

## Runtime layers
- Core: match state, team IDs, shared interfaces.
- Input: local player input.
- Heroes: movement, health, stats, attacks, and abilities.
- AI: bot decisions.
- World: minions, towers, objectives, and spawn rules.
- UI: HUD, menus, shop, and results.
- Networking (later): connection lifecycle and replicated state.
- Backend (later): account/profile and durable progression.

## Prototype components
- MOBAHeroController: CharacterController movement and optional camera follow.
- HeroHealth: health, damage, healing, and defeat event.
- IDamageable: contract for objects that receive damage.
- BasicMeleeAttack: cooldown-gated overlap attack against IDamageable targets.

## Online trust boundary
Clients send intent, not truth. A dedicated server validates movement, range, cooldowns, damage, item costs, and win conditions. Never embed server secrets in the client. Supabase can store profiles, but is not a real-time authoritative match server.
