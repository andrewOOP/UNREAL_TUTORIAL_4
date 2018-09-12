// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UNREAL_TUTORIAL_4EditorTarget : TargetRules
{
	public UNREAL_TUTORIAL_4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "UNREAL_TUTORIAL_4" } );
	}
}
