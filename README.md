# NusantaraMOBA

An original MOBA project inspired by the broad multiplayer online battle arena genre. Hero identities, lore, abilities, maps, visuals, UI, and audio must be original.

## Current stage

**Stage 0 — project foundation.** The repository contains design documentation and starter C# components. It is not yet a playable Unity build: scenes and assets still need to be created, and scripts must be compiled and tested in the Unity Editor.

## Planned technology

- Unity 6 LTS, C#, Universal Render Pipeline (URP)
- First milestone: offline single-player arena against practice targets and simple bots
- Later milestone: server-authoritative online matches, beginning with small local tests before considering 5v5
- Supabase may store accounts and profiles; it is not the real-time match server

## Start here

1. [Game design](Docs/GAME_DESIGN.md)
2. [Roadmap and milestones](Docs/ROADMAP.md)
3. [Architecture](Docs/ARCHITECTURE.md)
4. [Unity setup instructions](Docs/UNITY_SETUP.md)
5. [Future networking principles](Docs/NETWORK_PROTOCOL.md)

## Starter scripts

- `Assets/_Game/Scripts/Heroes/MOBAHeroController.cs`: WASD movement and camera follow
- `Assets/_Game/Scripts/Heroes/HeroHealth.cs`: health, damage, healing, defeat event
- `Assets/_Game/Scripts/Combat/BasicMeleeAttack.cs`: press Space to attempt a short-range attack
- `Assets/_Game/Scripts/Core/IDamageable.cs`: combat interface

For the initial prototype, configure Unity's Active Input Handling to **Input Manager (Old)** or **Both**. Follow the setup document to create a test scene.

## Project principles

- Do not copy another game's protected characters, assets, map layouts, UI, names, or audio.
- Build and verify one milestone at a time.
- Never commit API keys, credentials, signing keys, or private player data.
- Do not describe a feature as working until it has been run and tested.

## License

No license has been granted. All rights reserved by the repository owner unless a license is added.
