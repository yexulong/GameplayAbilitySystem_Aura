// Copyright yxl

using UnrealBuildTool;
using System.Collections.Generic;

public class test3Target : TargetRules
{
	public test3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "test3" } );
	}
}
