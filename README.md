## StabilityValley

This unity project simulate the [Valley of stability](https://en.wikipedia.org/wiki/Valley_of_stability) β, introducing the concepts of stability for an element and for an isotope. With the help of this representation, an astronomer can introduce the basic concepts like the decay process beta and the neutron capture process slow and fast in a very easy way.

### Requirements
This project was made with [Unity](https://unity3d.com/get-unity/download/archive) version `2018.2.9f1`.
The models are made with [blender](https://www.blender.org/download/previous-versions/) version `2.78`.

### Project scenes

There are 4 unity scenes: `Intro`, `FastProcess_blender_ext1`, `SlowProcess_blender_ext1`:
* The `Intro` scene is the introduction of the simulation that is a morphing image of the valley of stability. 
* The `FastProcess_blender_ext1` is a simulated fast process shown on a valley of stability model.
* The `SlowProcess_blender_ext1`  is a simulated slow process shown on a valley of stability model.

### Project structure

```
├───Assets
│   ├───Animation ## animation made for the stop point during the processes
│   ├───Editor ## scripts coming from assets
│   ├───images ## images shown during the processes
│   ├───Materials ## materials used in the scenes
│   ├───Models ## not used
│   ├───Prefabs ## prefabs used in the 
│   ├───SampleScenes ## not used
│   ├───Scenes 
│   ├───Scripts ## from assets
│   ├───Shaders ## for the color of the valley of stability model
│   ├───Skyboxes ## black sky
│   ├───splash ## for splash screen
│   ├───Splines ## used to move the camera
│   ├───Standard Assets ## from unity
│   └───video ## for introduction 
├───Packages ## from unity
└───ProjectSettings ## from unity
```
