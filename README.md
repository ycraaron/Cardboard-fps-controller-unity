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

1.Download GVR cardboard unity sdk from the link: https://developers.google.com/vr/unity/download

2.Build a new project.

3.Import Gvr package you just downloaded.

4.Import Unity FPS controller from menu-Assets-Import Packages-Characters.

Now you can choose A or B to set up (Suggest to choose B first)

A.

5.Drag Gvrmain from project path: Assets - GoogleVR - prefabs to Hierarchy.

6.Drag FPScontroller prefab from project path: Standard Assets - Characters -FirstPersonCharacter - Prefabs

7.Delete the main camera in the Hierarchy.

8.Delete child node named FirstPersonCharacter in FPScontroller prefab

9.Drag the FPScontroller prefab root node(FPScontroller) to Gvrmain

10.Drag Gvrmain's child node Head to FPScontroller.

11.Drag GvrPerticle from project path Assets - GoogleVR - prefabs - UI to the Head

12.In Hierarchy, click creat - UI - Eventsystem

13.In inspector(with Eventsystem selected), click add component, search GazeInput and choose GazeInputModule

14.Choose FPSController, replace the script attached to it: FirstPersonController.cs with the file in this repo.

15.Create a new plane and expand it to (x,y,z) = (100,1,100)

B.

5.Open demo scene in path Assets-GoogleVR-DemoScenes-HeadSetDemo-DemoScene

6.Drag FPScontroller prefab from project path: Standard Assets - Characters -FirstPersonCharacter - Prefabs

7.Delete child node named FirstPersonCharacter in FPScontroller prefab

8.Drag the FPScontroller prefab root node(FPScontroller) to Gvrmain

9.Drag Gvrmain's child node Head to FPScontroller.

10.Choose FPSController, replace the script attached to it: FirstPersonController.cs with the file in this repo.

11.Delete the main camera in hierarchy

12.Expand the plane to (x,y,z)->(100,1,100)

13.Select FpsController in hierarchy, drag Head to the variable head in script

Try to play around with it!
