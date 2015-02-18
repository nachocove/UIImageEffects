using System;
using ObjCRuntime;

[assembly: LinkWith ("libUIImageEffectsLibSDK.a", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.Arm64, ForceLoad = true)]
