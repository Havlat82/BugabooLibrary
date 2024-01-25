using Havlat82.BugabooLibrary.ConsoleDebugApp.Resources;
using System.ComponentModel;

namespace Havlat82.BugabooLibrary.ConsoleDebugApp.Console
{
    /// <summary>
    /// Enumeration of all text alignments in console output
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Alignment
    {
        /// <summary>
        /// Aligns text to Left
        /// </summary>
        [LocalizedDescription("AlignToLeft", typeof(EnumResources))]
        ToLeft,
        /// <summary>
        /// Aligns text to right
        /// </summary>
        [LocalizedDescription("AlignToRight", typeof(EnumResources))]
        ToRight,
        /// <summary>
        /// Aligns text to top
        /// </summary>
        [LocalizedDescription("AlignToTop", typeof(EnumResources))]
        ToTop,
        /// <summary>
        /// Aligns text to bottom
        /// </summary>
        [LocalizedDescription("AlignToBottom", typeof(EnumResources))]
        ToBottom,
        /// <summary>
        /// Aligns text to center
        /// </summary>
        [LocalizedDescription("AlignToCenter", typeof(EnumResources))]
        ToCenter
    }
}
