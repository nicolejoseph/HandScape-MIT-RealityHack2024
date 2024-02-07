# HandScape: MIT Reality Hack 2024

As part of the "Hack the Party" category, HandScape is an interactive art installation designed for the Sunday night party at MIT Reality Hack 2024. It allows users to connect through artistic expression.
Check out our team's [DevPost](https://devpost.com/software/handscape) for more info on the project journey, inspiration, and story :-)
## Setup
Starting off, we combined Ultraleap's hand tracking camera and software with Unity to set up a baseline experience that allows users to pinch their fingers and generate digital paint strokes. Using C#, we experimented with writing scripts that adjusted the paint stroke's colors, width, and appearance. This [Ultraleap documentation](https://docs.ultraleap.com/xr-and-tabletop/xr/unity/getting-started/index.html) walks through useful plugins and example scenes to set up simple XR experiences. The hand tracking camera was also extremely accurate and had great field of view.

When thinking about the night club this art installation would be displayed in, we later decided to add sound interactivity using Keijiro Takahashi's [Reaktion](https://github.com/keijiro/Reaktion), an audio reactive animation toolkit for Unity. This [Reaktion Introductory Tutorial](https://www.youtube.com/watch?v=PCNcL02mJ-E&t=121s) by Gregory Osborne was an invaluable resource. With this, we were able to make the paint strokes of each message "dance" with the beat drop.
### Hardware Required

- An [Ultraleap Hand Tracking Camera](https://www.ultraleap.com/tracking/?_gl=1*o7ieca*_ga*MTUwMTQ5NjM0LjE3MDYyODQ1ODI.*_ga_5G8B19JLWG*MTcwNzM0MzY3OS4xMy4xLjE3MDczNDQzNzguNjAuMC4w)
- A computer that meets the [Tracking Requirements](https://leap2.ultraleap.com/gemini-downloads/?_gl=1*1hmlyhh*_ga*MTUwMTQ5NjM0LjE3MDYyODQ1ODI.*_ga_5G8B19JLWG*MTcwNzM0MzY3OS4xMy4xLjE3MDczNDQ0MjIuMTYuMC4w)
  - This project runs on both Windows and mac
- Any kind of microphone
  - Laptop microphone works fine
- A projector and a wall (for the projections to be displayed on to)
- A few loooooong cables

### Software Dependencies

- Unity `2021` or newer
- Ultraleap Gemini `V5.2+` [Hand Tracking Software](https://leap2.ultraleap.com/gemini-downloads/?_gl=1*1hmlyhh*_ga*MTUwMTQ5NjM0LjE3MDYyODQ1ODI.*_ga_5G8B19JLWG*MTcwNzM0MzY3OS4xMy4xLjE3MDczNDQ0MjIuMTYuMC4w)
- Unity's XR Plugin Management
- Keijiro Takahashi's [Reaktion](https://github.com/keijiro/Reaktion) toolkit

## Run

1. Connect Ultraleap hand tracking camera to computer
   - Before opening up the Unity project, you can ensure the camera works via the Ultraleap Control Panel
2. Connect microphone of choice
    - Ensure that the microphone is picked up in Unity
4. Play the project in Unity and have fun!


## Shout-Outs

Special shout out to Kris Pilcher for always pointing us in the right direction regarding hardware, software, and user experience; Gregory Osborne for his sick Unity skills and explanations; Pip, Lazlo, and Rory from the Ultraleap team for promptly coming to the rescue to debug our code & for sharing a whole bunch of links to their plugins, documentation, and 3rd party tooling details! 

