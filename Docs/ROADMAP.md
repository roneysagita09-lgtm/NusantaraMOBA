# Roadmap

## Stage 0 — foundation
- [x] Repository README and starter documentation
- [x] Initial C# movement and combat components
- [ ] Create Unity 6 LTS URP project on development PC
- [ ] Import scripts and resolve compile errors
- [ ] Create and save test scene

## Stage 1 — offline movement and combat
- [ ] WASD movement and camera follow tested in Play Mode
- [ ] Health and damage tested
- [ ] Basic attack tested against a target
- [ ] Simple bot movement/attack
- [ ] Minimal health HUD

## Stage 2 — MOBA loop
- [ ] Lane and minion spawning
- [ ] Tower targeting and destruction
- [ ] Hero abilities and cooldowns
- [ ] Gold/XP and small test item shop
- [ ] Core objective and win/lose conditions
- [ ] Restart and match results

## Stage 3 — content and polish
- [ ] Original hero data, abilities, and balance
- [ ] Original map blockout and art pass
- [ ] Audio, animation, effects, settings, accessibility
- [ ] EditMode/PlayMode tests and Windows build smoke test

## Stage 4 — online prototype
- [ ] Define protocol and server-authoritative simulation
- [ ] Local two-client connection test
- [ ] Server validates movement, attack range, cooldowns, and damage
- [ ] Reconnect, latency, disconnect, and abuse tests
- [ ] Small closed playtest before 5v5 scope

## Stage 5 — production online
- [ ] Dedicated match server deployment and monitoring
- [ ] Matchmaking and parties
- [ ] Account/profile persistence
- [ ] Moderation, privacy, telemetry, backups, security review, and load tests

**Rule:** never mark a milestone complete until it has been run and verified in Unity or a target build.
