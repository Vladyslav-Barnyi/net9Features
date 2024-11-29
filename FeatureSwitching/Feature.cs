using System.Diagnostics.CodeAnalysis;

namespace FeatureSwitching;

public class Feature
{
    [FeatureSwitchDefinition("Feature.IsEnabled")]
    internal static bool isFeatureEnabled =>
        !AppContext.TryGetSwitch("Feature.IsEnabled", out var isEnabled) || isEnabled;
    internal static void IncreaseSalary()
    {
        Console.WriteLine("Salary increased!");
    }
}