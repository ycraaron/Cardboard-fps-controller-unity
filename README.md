Part 1: Description

I.The code is from Unity sample asset-FirstPersonController, I make some changes to fit with cardboard.

II.It allows you to move using keyboard and select object in game world using gaze input.

III.To enable auto walk, uncomment the line "//m_Input.y=1;" in FixedUpdate() function.

Things need to be done in the future:

In order to play the game using mobile devices, we need to add touch input.
Implement touch-move: touch screen, move foward.
Part 2:
Steps to build a VR first person controller in unity for cardboard:

Assuming that you have already installed Unity 5.3 or above and Java:

Download GVR cardboard unity sdk from the link: https://developers.google.com/vr/unity/download
Build a new project.
Import Gvr package you just downloaded.
Import Unity FPS controller from menu-Assets-Import Packages-Characters.
Now you can choose A or B to set up (Suggest to choose B first)

A.

Drag Gvrmain from project path: Assets - GoogleVR - prefabs to Hierarchy.
Drag FPScontroller prefab from project path: Standard Assets - Characters -FirstPersonCharacter - Prefabs
Delete the main camera in the Hierarchy.
Delete child node named FirstPersonCharacter in FPScontroller prefab
Drag the FPScontroller prefab root node(FPScontroller) to Gvrmain
Drag Gvrmain's child node Head to FPScontroller.
Drag GvrPerticle from project path Assets - GoogleVR - prefabs - UI to the Head
In Hierarchy, click creat - UI - Eventsystem
In inspector(with Eventsystem selected), click add component, search GazeInput and choose GazeInputModule
Choose FPSController, replace the script attached to it: FirstPersonController.cs with the file in this repo.
B.

Open demo scene in path Assets-GoogleVR-DemoScenes-HeadSetDemo
Drag FPScontroller prefab from project path: Standard Assets - Characters -FirstPersonCharacter - Prefabs
Delete child node named FirstPersonCharacter in FPScontroller prefab
Drag the FPScontroller prefab root node(FPScontroller) to Gvrmain
Drag Gvrmain's child node Head to FPScontroller.
Choose FPSController, replace the script attached to it: FirstPersonController.cs with the file in this repo.
Try to play around with it!
