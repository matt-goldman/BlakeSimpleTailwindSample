namespace BlakeSimpleTailwindSample.Utils;

public static class MetadataExtensions
{
    public static string GetValueOr(this IDictionary<string, string>? metadata, string key, string fallback) =>
        metadata?.TryGetValue(key, out var value) == true ? value : fallback;
}
