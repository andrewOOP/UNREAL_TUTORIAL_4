# UNREAL_TUTORIAL_4
Player Input and Pawns

## What I learned
I learned how to add player control to pawns from C++ code, how binding works to the player input in project settings, and how code in the constructor is handled (it's run when the object is placed in the scene, not when the game is run)

## Notes
* Doesn’t do a good job at fully explaining the code, but I understood it after looking it over

* Need to include #include "Camera/CameraComponent.h" for the camera

* Better camera angle:
	OurCamera->SetRelativeLocation(FVector(-250.0f, 0.0f, 150.0f));
	OurCamera->SetRelativeRotation(FRotator(-25.0f, 0.0f, 0.0f));

* I learned that once you put a Pawn in the scene and you edit values in the constructor, you have to delete it and place a new one in the scene for the values to update, which makes sense, since it’s the constructor you’re editing. i.e. don’t put hardcoded values in the constructor I guess if you want to change them

* InputComponent throws an error, but it’s false positive
