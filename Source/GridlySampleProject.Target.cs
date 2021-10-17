// Copyright (c) 2021 LocalizeDirect AB

using UnrealBuildTool;
using System.Collections.Generic;

public class GridlySampleProjectTarget : TargetRules
{
	public GridlySampleProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "GridlySampleProject" } );
	}
}
