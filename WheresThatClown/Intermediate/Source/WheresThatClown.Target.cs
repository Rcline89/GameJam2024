using UnrealBuildTool;

public class WheresThatClownTarget : TargetRules
{
	public WheresThatClownTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("WheresThatClown");
	}
}
