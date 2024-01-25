namespace Havlat82.BugabooLibrary.ConsoleDebugApp.Console
{
    public struct Struct
    {


        #region Informace o structu + design best practices pro struct

        /*
        Struct (struktura) = hodnotový datový typ 
        => ukládá se v zásobníku (Stack)
        => logicky reprezentuje jednu hodnotu (jako datový typ int nebo double)
        => když je instance struktury předána metodě, je vždy předána hodnotou
        => nemůže mít inicializátory pro nestatické položky // int number = 0; je neplatné přiřazení
        => může mít inicializátory pro statické položky
        
        
        
        

        Linky na webu:
        https://medium.com/@norm.bryar/truly-leverage-c-structs-part-1-4a3f707c40ee
        https://medium.com/@norm.bryar/truly-leverage-c-structs-part-2-5e808b5be5bd
        https://www.infoworld.com/article/3042500/how-to-work-with-structs-in-c.html
        https://josipmisko.com/posts/c-sharp-struct
        https://stackoverflow.com/questions/52140671/c-sharp-struct-best-practices-possible-contradiction
        https://blog.submain.com/c_struct/
        https://getyourbitstogether.com/structs/
        https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct
        https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/struct
        https://www.bytehide.com/blog/struct-vs-class-csharp

        https://stackoverflow.com/questions/150479/order-of-items-in-classes-fields-properties-constructors-methods

        */

        #endregion Informace o structu + design best practices pro struct

        #region Povolené položky v datovém typu struct a jejich řazení podle StyleCopu

        //The documentation notes that if the prescribed order isn't suitable - say,
        //multiple interfaces are being implemented, and the interface methods and properties
        //should be grouped together - then use a partial class
        //to group the related methods and properties together.

        //public const
        //internal const
        //private const

        //public static readonly field
        //public static field
        //public readonly field
        //public field
        //internal static readonly field
        //internal static field
        //internal readonly field
        //internal field
        //private static readonly field
        //private static field
        //private readonly field
        //private field

        //static constructor
        //public constructor
        //internal constructor
        //private constructor

        //public delegate
        //internal delegate
        //private delegate

        //public static event
        //public event
        //internal static event
        //internal event
        //private static event
        //private event

        //public enum
        //internal enum
        //private enum

        //inteface implementations

        //public static property
        //public readonly property (jen getter)
        //public property
        //internal static property
        //internal readonly property (jen getter)
        //internal property
        //private static property
        //private readonly property (jen getter)
        //private property

        //public readonly indexer (jen getter)
        //public indexer
        //internal readonly indexer (jen getter)
        //internal indexer
        //private readonly indexer (jen getter)
        //private indexer

        //public static methods
        //public methods
        //internal static methods
        //internal methods
        //private static methods
        //private methods

        //public readonly struct
        //public struct
        //internal readonly struct
        //internal struct
        //private readonly struct
        //private struct

        //public static class
        //public class
        //internal static class
        //internal class
        //private static class
        //private class

        #endregion Povolené položky v datovém typu struct a jejich řazení podle StyleCopu


    }
}