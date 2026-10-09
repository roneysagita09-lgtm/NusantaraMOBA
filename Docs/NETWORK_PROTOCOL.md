# Networking principles (future milestone)

This document records constraints, not an implemented online mode.

## Authority
- A dedicated match server owns match state and validates all gameplay.
- Clients send player intent; they do not submit authoritative damage, gold, cooldown completion, objective ownership, or match results.
- Server simulation must validate movement speed, collision, attack range, cooldowns, team membership, and target eligibility.
- Account/profile storage is separate from real-time simulation.

## Initial test plan
1. Two local clients connect to a development server.
2. Server creates the match state and assigns player/team IDs.
3. Clients send movement/attack intent.
4. Server validates intent and replicates approved state.
5. Disconnect/reconnect and latency cases are tested.
6. Only then consider larger lobbies and 5v5.

## Security
- Never commit credentials or server secrets.
- Do not trust client clocks or client-side result screens.
- Rate-limit requests and validate every message.
- Log enough server-side events to investigate abuse without collecting unnecessary personal data.
