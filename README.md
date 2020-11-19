## StabilityValley

This unity project simulate the [Valley of stability](https://en.wikipedia.org/wiki/Valley_of_stability).

### Requirements
This project was made with [Unity](https://unity3d.com/get-unity/download/archive) version `2018.2.9f1`.

### Project scenes


### Project structure

```
├───Assets
│   ├───Animation
│   ├───Editor
│   ├───images
│   │   └───Materials
│   ├───Materials
│   ├───Models
│   │   └───Materials
│   ├───Prefabs
│   ├───SampleScenes
│   │   ├───AudioMixers
│   │   ├───Materials
│   │   ├───Menu
│   │   │   ├───Prefabs
│   │   │   ├───Scripts
│   │   │   └───Sprites
│   │   ├───Models
│   │   │   └───Materials
│   │   ├───Navmesh
│   │   ├───Prefabs
│   │   ├───Scenes
│   │   │   └───CharacterThirdPersonAI
│   │   ├───Scripts
│   │   ├───Shaders
│   │   └───Textures
│   ├───Scenes
│   ├───Scripts
│   │   ├───AssetCloud
│   │   │   └───Materials
│   │   ├───_2D
│   │   ├───_ApplicationComponents
│   │   └───_ScriptHelper
│   ├───Shaders
│   ├───Skyboxes
│   │   └───Sky_02
│   ├───splash
│   ├───Splines
│   │   ├───Resources
│   │   │   └───Materials
│   │   └───Scripts
│   │       ├───Editor
│   │       ├───HelperClasses
│   │       └───SplineClasses
│   ├───Standard Assets
│   │   ├───2D
│   │   │   ├───Animations
│   │   │   ├───Animator
│   │   │   ├───Materials
│   │   │   ├───PhysicsMaterials
│   │   │   ├───Prefabs
│   │   │   ├───Scripts
│   │   │   └───Sprites
│   │   ├───Cameras
│   │   │   ├───Prefabs
│   │   │   └───Scripts
│   │   ├───Characters
│   │   │   ├───FirstPersonCharacter
│   │   │   │   ├───Audio
│   │   │   │   ├───Prefabs
│   │   │   │   └───Scripts
│   │   │   ├───RollerBall
│   │   │   │   ├───Materials
│   │   │   │   ├───Models
│   │   │   │   ├───Prefabs
│   │   │   │   ├───Scripts
│   │   │   │   └───Textures
│   │   │   └───ThirdPersonCharacter
│   │   │       ├───Animation
│   │   │       ├───Animator
│   │   │       ├───Materials
│   │   │       ├───Models
│   │   │       ├───Prefabs
│   │   │       ├───Scripts
│   │   │       └───Textures
│   │   ├───CrossPlatformInput
│   │   │   ├───Prefabs
│   │   │   ├───Scripts
│   │   │   │   └───PlatformSpecific
│   │   │   └───Sprites
│   │   ├───Editor
│   │   │   ├───CrossPlatformInput
│   │   │   └───Water
│   │   │       └───Water4
│   │   ├───Effects
│   │   │   ├───GlassRefraction
│   │   │   │   ├───Materials
│   │   │   │   ├───Shaders
│   │   │   │   └───Textures
│   │   │   ├───ImageEffects
│   │   │   ├───LightCookies
│   │   │   │   └───Textures
│   │   │   ├───LightFlares
│   │   │   │   ├───Flares
│   │   │   │   ├───Materials
│   │   │   │   └───Textures
│   │   │   ├───Projectors
│   │   │   │   ├───Materials
│   │   │   │   ├───Prefabs
│   │   │   │   ├───Shaders
│   │   │   │   └───Textures
│   │   │   ├───TessellationShaders
│   │   │   │   ├───Materials
│   │   │   │   ├───Models
│   │   │   │   ├───Scenes
│   │   │   │   ├───Shaders
│   │   │   │   └───Textures
│   │   │   └───ToonShading
│   │   │       ├───Materials
│   │   │       ├───Shaders
│   │   │       └───Textures
│   │   ├───Environment
│   │   │   ├───SpeedTree
│   │   │   │   ├───Broadleaf
│   │   │   │   │   ├───Broadleaf_Desktop Materials
│   │   │   │   │   │   ├───LOD0
│   │   │   │   │   │   ├───LOD1
│   │   │   │   │   │   └───LOD2
│   │   │   │   │   └───Broadleaf_Mobile Materials
│   │   │   │   │       ├───LOD0
│   │   │   │   │       ├───LOD1
│   │   │   │   │       └───LOD2
│   │   │   │   ├───Conifer
│   │   │   │   │   └───Conifer_Desktop Materials
│   │   │   │   │       ├───LOD0
│   │   │   │   │       ├───LOD1
│   │   │   │   │       └───LOD2
│   │   │   │   └───Palm
│   │   │   │       └───Palm_Desktop Materials
│   │   │   │           ├───LOD0
│   │   │   │           ├───LOD1
│   │   │   │           └───LOD2
│   │   │   ├───TerrainAssets
│   │   │   │   ├───BillboardTextures
│   │   │   │   └───SurfaceTextures
│   │   │   ├───Water
│   │   │   │   ├───Water
│   │   │   │   │   ├───Materials
│   │   │   │   │   ├───Models
│   │   │   │   │   ├───Prefabs
│   │   │   │   │   ├───Scripts
│   │   │   │   │   ├───Shaders
│   │   │   │   │   └───Textures
│   │   │   │   └───Water4
│   │   │   │       ├───Materials
│   │   │   │       ├───Models
│   │   │   │       ├───Prefabs
│   │   │   │       ├───Shaders
│   │   │   │       └───Textures
│   │   │   └───Water (Basic)
│   │   │       ├───Materials
│   │   │       ├───Models
│   │   │       ├───Prefabs
│   │   │       ├───Scripts
│   │   │       ├───Shaders
│   │   │       └───Textures
│   │   ├───Fonts
│   │   │   └───OpenSans
│   │   ├───ParticleSystems
│   │   │   ├───Materials
│   │   │   ├───Prefabs
│   │   │   ├───Scripts
│   │   │   ├───Shaders
│   │   │   └───Textures
│   │   ├───PhysicsMaterials
│   │   ├───Prototyping
│   │   │   ├───Materials
│   │   │   ├───Models
│   │   │   ├───Prefabs
│   │   │   ├───Shaders
│   │   │   └───Textures
│   │   ├───Utility
│   │   │   └───Prefabs
│   │   └───Vehicles
│   │       ├───Aircraft
│   │       │   ├───Animation
│   │       │   ├───Audio
│   │       │   ├───Materials
│   │       │   ├───Models
│   │       │   ├───Prefabs
│   │       │   ├───Scripts
│   │       │   └───Textures
│   │       └───Car
│   │           ├───Audio
│   │           ├───Materials
│   │           ├───Models
│   │           ├───Prefabs
│   │           ├───Scripts
│   │           ├───Shaders
│   │           └───Textures
│   └───video
├───Packages
└───ProjectSettings
```
