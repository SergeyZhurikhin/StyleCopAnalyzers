﻿// <auto-generated/>

#nullable enable
using System.Reflection;


namespace StyleCop.Analyzers.Settings
{
    internal static partial class SettingsResources
    {
        private static global::System.Resources.ResourceManager? s_resourceManager;
        public static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(SettingsResources)));
        public static global::System.Globalization.CultureInfo? Culture { get; set; }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [return: global::System.Diagnostics.CodeAnalysis.NotNullIfNotNull("defaultValue")]
        internal static string? GetResourceString(string resourceKey, string? defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture) ?? defaultValue;
        /// <summary>Add StyleCop settings file to the project</summary>
        public static string @SettingsFileCodeFix => GetResourceString("SettingsFileCodeFix")!;

    }
}
