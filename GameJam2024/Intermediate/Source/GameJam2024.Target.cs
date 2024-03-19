using UnrealBuildTool;

public class GameJam2024Target : TargetRules
{
	public GameJam2024Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameJam2024");
	}
}
