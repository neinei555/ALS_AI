// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ALS_AI : ModuleRules
{
	public ALS_AI(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ALS_AI",
			"ALS_AI/Variant_Platforming",
			"ALS_AI/Variant_Platforming/Animation",
			"ALS_AI/Variant_Combat",
			"ALS_AI/Variant_Combat/AI",
			"ALS_AI/Variant_Combat/Animation",
			"ALS_AI/Variant_Combat/Gameplay",
			"ALS_AI/Variant_Combat/Interfaces",
			"ALS_AI/Variant_Combat/UI",
			"ALS_AI/Variant_SideScrolling",
			"ALS_AI/Variant_SideScrolling/AI",
			"ALS_AI/Variant_SideScrolling/Gameplay",
			"ALS_AI/Variant_SideScrolling/Interfaces",
			"ALS_AI/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
