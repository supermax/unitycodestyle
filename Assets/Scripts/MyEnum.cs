/******************************************************************************
    Style Guidelines:
        * Readability - code is easy to read and to understand
        * Standardisation - all team members are aligned with same code style
        * Self-descriptive code - code is easy to understand without comments
        * Debuggable - code is easy to debug (IDE friendly)
 ******************************************************************************/

// types are defined within the scope of namespace
// space name starts with Upper case letter
// each following word starts with upper Case letter
// sub-spaces are divided by '.' (dot)
// here "MyNameSpace" is main space and "Enums" is sub-space
namespace MyNameSpace.Enums
{
    /// <summary>
    /// type name starts with Upper case letter
    /// each following word starts with Upper Case letter
    /// <remarks>
    /// type = class, enum, struct, delegate. interface, etc
    /// </remarks>
    /// </summary>
    public enum MyEnum
    {
        /// <summary>
        /// enum member name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        EnumMember1,
        
        EnumMember2
    }
}