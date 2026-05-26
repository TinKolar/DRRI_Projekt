// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DRRI_Projekt : ModuleRules
{
	public DRRI_Projekt(ReadOnlyTargetRules Target) : base(Target)
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
			"DRRI_Projekt",
			"DRRI_Projekt/Variant_Platforming",
			"DRRI_Projekt/Variant_Platforming/Animation",
			"DRRI_Projekt/Variant_Combat",
			"DRRI_Projekt/Variant_Combat/AI",
			"DRRI_Projekt/Variant_Combat/Animation",
			"DRRI_Projekt/Variant_Combat/Gameplay",
			"DRRI_Projekt/Variant_Combat/Interfaces",
			"DRRI_Projekt/Variant_Combat/UI",
			"DRRI_Projekt/Variant_SideScrolling",
			"DRRI_Projekt/Variant_SideScrolling/AI",
			"DRRI_Projekt/Variant_SideScrolling/Gameplay",
			"DRRI_Projekt/Variant_SideScrolling/Interfaces",
			"DRRI_Projekt/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
