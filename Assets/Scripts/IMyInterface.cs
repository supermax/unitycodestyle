/******************************************************************************
    Style Guidelines:
        * Readability - code is easy to read and to understand
        * Standardisation - all team members are aligned with same code style
        * Self-descriptive code - code is easy to understand without comments
        * Debuggable - code is easy to debug (IDE friendly)
 ******************************************************************************/

// using (imports) of other namespaces will be wrapped with region "Using"
#region Using
using MyNameSpace.Delegates;
#endregion

// types are defined within the scope of namespace
// space name starts with Upper case letter
// each following word starts with Upper Case letter
// sub-spaces are divided by '.' (dot)
// here "MyNameSpace" is main space and "Interfaces" is sub-space
namespace MyNameSpace.Interfaces
{
    /// <summary>
    /// type name starts with Upper case letter
    /// each following word starts with Upper case letter
    /// <remarks>
    /// type = class, enum, struct, delegate. interface, etc
    /// </remarks>
    /// </summary>
    public interface IMyInterface
    {
        /// <summary>
        /// public event name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        event MyDelegate MyEvent;

        /// <summary>
        /// property name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// <remarks>
        /// getter or setter will be defined if public access is necessary
        /// </remarks>
        /// </summary>
        int MyIntProperty { get; }

        /// <summary>
        /// method name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        /// <param name="numericValue">
        /// parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </param>
        void MyMethod(int numericValue);
    }
}
