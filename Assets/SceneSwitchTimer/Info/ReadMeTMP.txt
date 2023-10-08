Scene Switch Timer (Text Mesh Pro)
-----------------------------------

Description:

Primarily, this simple script simply allows you to add a visible display timer in your scene UI Canvas that counts down to completion and then at the end of said timer countdown to then auto switch to the specified scene via SceneManager. For example: say you have a small start zone scene for players to run around in like in most battle royales just for one example and then you want to send the player to a specific scene after a specified time, that is what this simple script does.

Manual Setup:

Important Note: 

* The desired scene to switch to must first be defined in the build settings: "Add Open Scenes"!

Example:

Create 2 scenes:

1) Demo Start
2) Demo Switched

open each and add them to build settings.

ie:

Scenes/Demo Start       0
Scenes/Demo Switched    1

In the Demo Start Scene:

1) Create: UI -> Canvas (unless you alread have a UI Canvas)

2) Create inside UI Canvas as child: -> Text Mesh Pro (TMP)

Rename it to: Timer Text (TMP)

Details:

Rect Trans: top center  

Position: X: 0 Y: -100 Z: 0

Width: 230  Height: 90

Text: 120.00

Text Style: Bold

Text Size: 60

Vertex Color Hex: #FFFFF

Font Alignment: Center & Middle

3) On that Text -> Inspector: 

Add Script: SwitchSceneTimerTMP.cs

4) Ok, now view in inspector the added scipt:

"Script": Scene Switch Timer (Script)

By default it should look like:

Script: SwitchSceneTimerTMP.cs
Scene To Load:
Time Rmaining: 120
Timer Is Running:
Time Text:

5) Add desired switch to "Scene Name" in corresponding input textarea:

ie:

"Scene To Load": Demo Switched

6) Ignore "Time Remaining: 120" as that is added by default* (it can be changed, but for now ignore it)

7) Ignore the unchecked "Timer Is Running" check box 

8) Add "Time Text":

Select:

Timer Text (TMP) (Text)

Alright that is it for setup! Simple enough, right?!

You can now go ahead and load/play your start scene and watch the timer count down and then switch to the scene you selected. Best of luck!

Final Note:

If you do not desire the debug logs display then simply comment out any and or all of those specifically in the script, no biggie. :)
