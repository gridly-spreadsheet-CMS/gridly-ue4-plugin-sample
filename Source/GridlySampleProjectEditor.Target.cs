// Copyright © 2020 LocalizeDirect AB

using UnrealBuildTool;
using System.Collections.Generic;

public class GridlySampleProjectEditorTarget : TargetRules
{
	public GridlySampleProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "GridlySampleProject" } );
	}
}
