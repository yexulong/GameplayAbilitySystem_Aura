// Copyright yxl

using UnrealBuildTool;
using System.Collections.Generic;

public class test3EditorTarget : TargetRules
{
	public test3EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "test3" } );
	}
}
