# NusantaraMOBA — Game Design (v0.1)

## Vision
Build an original team-based arena battler with distinct heroes, lane pressure, objectives, and teamwork. First deliverable is a small offline prototype, not a complete commercial game.

## Originality
Use original hero identities, names, lore, abilities, maps, UI, sound, and art. Do not copy or extract protected assets from other games.

## Targets
- Development: Windows PC
- Planned platforms: Windows and Android after input, UI, and performance work
- First mode: offline single-player versus simple bots
- Later mode: online team matches after offline rules are stable

## First playable loop
1. Enter a small test arena.
2. Move a hero using WASD.
3. Approach a target dummy.
4. Perform a basic attack and apply damage.
5. Observe health and defeat state.

## Planned match rules
- Eventual team size: 5v5; prototype starts with a player and practice targets.
- Three lanes, towers, minions, jungle camps, and a core objective are later milestones.
- Win by destroying the opposing core.
- Match duration target: 12–20 minutes, to be tuned through playtesting.

## Design pillars
- Clarity: range, danger, cooldowns, and objectives should be readable.
- Fairness: combat outcomes should be testable.
- Performance: start with a small arena and simple assets.
- Maintainability: separate data and gameplay systems.
- Security: online matches must not trust client-reported damage, currency, cooldowns, or results.

## Not in v0.1
Ranked matchmaking, purchases, skins, chat, accounts, payment systems, and monetization. They must not delay the first playable prototype.
