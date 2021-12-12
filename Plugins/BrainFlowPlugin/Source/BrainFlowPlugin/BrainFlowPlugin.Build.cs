// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class BrainFlowPlugin : ModuleRules
{
	public BrainFlowPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        PublicIncludePaths.AddRange(new string[] { "D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Public"  });

       
        PublicIncludePaths.AddRange(new string[] { "D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/inc" });


        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/Brainflow.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/DataHandler.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/BoardController.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/MLModule.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/MuseLib.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/BrainBitLib.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/BrainFlowBluetooth.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/DSPFilters.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/WaveLib.lib");
        PublicAdditionalLibraries.Add("D:/UE_4.26/Projects/MyProject8/Plugins/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/GanglionLib.lib");

        RuntimeDependencies.Add("$(TargetOutputDir)/BoardController.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "BoardController.dll"));
        RuntimeDependencies.Add("$(TargetOutputDir)/DataHandler.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "DataHandler.dll"));
        RuntimeDependencies.Add("$(TargetOutputDir)/GanglionLib.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "GanglionLib.dll"));
        //RuntimeDependencies.Add("$(TargetOutputDir)/gforce64.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "gforce64.dll"));
        //RuntimeDependencies.Add("$(TargetOutputDir)/gForceSDKWrapper.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "gForceSDKWrapper.dll"));
        RuntimeDependencies.Add("$(TargetOutputDir)/neurosdk-x64.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "neurosdk-x64.dll"));
        RuntimeDependencies.Add("$(TargetOutputDir)/Unicorn.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "Unicorn.dll"));
        RuntimeDependencies.Add("$(TargetOutputDir)/BrainBitLib.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "BrainBitLib.dll"));
        RuntimeDependencies.Add("$(TargetOutputDir)/eego-SDK.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "eego-SDK.dll"));
        
    }
}
