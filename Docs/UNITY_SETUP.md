# Unity setup — first prototype

1. Install Unity Hub and a supported Unity 6 LTS release.
2. Create a 3D (URP) project named NusantaraMOBA.
3. Copy this repository's C# files into matching folders under Assets/_Game/Scripts/.
4. In Project Settings > Player > Other Settings, set Active Input Handling to Input Manager (Old) or Both, then restart the editor if prompted.
5. Create a scene named TestArena and add a Plane at (0,0,0).
6. Create a Capsule named Player at (0,1,0). Add CharacterController and MOBAHeroController.
7. Add a Camera and assign it to the controller's Follow Camera field, or tag it MainCamera.
8. Create a Capsule named TrainingTarget at (0,1,2), add HeroHealth, and keep its collider enabled.
9. Add BasicMeleeAttack to Player. Configure Target Layers to include the target's layer.
10. Press Play and verify movement, camera follow, and attacks. This repository does not yet contain a saved Unity scene or art assets.
11. Do not commit Unity Library, Temp, Obj, credentials, or signing keys.

## Troubleshooting
- No movement: check Active Input Handling and the Console.
- Camera does not follow: assign the camera or tag it MainCamera.
- Attack does nothing: ensure target has HeroHealth, its layer is included, and it is in attack range.
