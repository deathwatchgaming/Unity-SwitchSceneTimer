Scene Switch Timer (Text Legacy)
--------------------------------

Description:

Primarily, this simple script simply allows you to add a visible display timer
in your scene UI Canvas that counts down to completion and then at the end of
said timer countdown to then auto switch to the specified scene via
SceneManager. For example: say you have a small start zone scene for players
to run around in like in most battle royales just for one example and then
you want to send the player to a specific scene after a specified time, that
is what this simple script does.

Manual Setup:

Important Note: 

* The desired scene to switch to must first be defined in the build
  settings: "Add Open Scenes"!

Example:

Create 2 scenes:

1) Demo Start 
2) Demo Switched

open each and add them to build settings.

ie:

Scenes/Demo Start       0 
Scenes/Demo Switched    1

In the Demo Start Scene:

1) Create: UI -> Canvas (unless you already have a UI Canvas)

2) Create inside UI Canvas as child: -> Text (legacy)

Rename it to: Timer Text (Legacy)

Details:

Rect Trans: top center  

Position: X: 0 Y: -100 Z: 0 

Width: 200  Height: 90

* note: These will obviously possibly change depending on your canvas and
  desired location in such, so these are just mentioned for example but
  primarily you can put it anywhere you desire in your canvas ui. Same goes
  for other things like font size, color, etc as you can change for you
  desire and needs.

Text: 02:00  

* note: This will change when run so consider this as just a placeholder

Text Style: Bold

Text Size: 60

Color Hex: #FFFFF

Font Alignment: Center & Middle

3) On that Text -> Inspector: 

Add Script: SwitchSceneTimerLegacy.cs

4) Ok, now view in inspector the added scipt:

"Script": Scene Switch Timer (Script)

By default it should look like:

Script: SwitchSceneTimerLegacy.cs Scene To Load: Time Rmaining: 120 Timer Is
Running: Time Text:

5) Add desired switch to "Scene Name" in corresponding input textarea:

ie:

"Scene To Load": Demo Switched

6) Ignore "Time Remaining: 120" as that is added by default* (it can be
changed, but for now ignore it)

7) Ignore the unchecked "Timer Is Running" check box *

8) Ignore the unchecked "Timer Enabled" check box *

9) Add "Time Text":

Select:

Timer Text (Legacy) (Text)

10) Let us now talk about # 8 * & # 9 *

* Originally I had set this up to override the "Timer is Running" on start hence 
  why I originally wrote the instructions to ignore such. At the time such override 
  was in place until I could get further free time to work further on this. Ok Since 
  then I have now removed the start override and also added another checkbox (# 9) 
  called "Timer Enabled". Both of these are disabled by default and here is why: 
  Since we include both a Legacy Text variant and a TMP variant there is no way to 
  determine if the user will include both while following the instructions thus I 
  opted to keep these disabled by default and then alow the user to select what one 
  should be "enabled" and "running". If such is not desired to disable by default 
  one could change such in the source, but for now it made sense to do such.

  ok, since that is explained, let us go back to the desired variant you have setup 
  and you can now:

  10.A) Check the unchecked "Timer Is Running" check box

  10.B) Check the unchecked "Timer Enabled" check box  


Alright that is it for setup! Simple enough, right?!

You can now go ahead and load/play your start scene and watch the timer count
down and then switch to the scene you selected. Best of luck!

Final Note:

If you do not desire the debug logs display then simply comment out any and or
all of those specifically in the script, no biggie. :)


Another quick note: Say for simple example that you want to use this timer to not only switch the scene but lets say for example you wanted to take your FPSController to that switched scene rather than say have a different one setup in that scene. Well, you would simply add something like "DontDestroyOnLoad(this);" to your Awake method in your FPSController script just for one example to accomplish such easily and quickly.

Ie:

// Awake Method
public void Awake()
{
  // Do not destroy this Game Object
  DontDestroyOnLoad(this);
}


