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
// here "MyNameSpace" is main space and "Structs" is sub-space
namespace MyNameSpace.Structs
{    
    /// <summary>
    /// type name starts with Upper case letter
    /// each following word starts with Upper Case letter
    /// <remarks>
    /// type = class, enum, struct, delegate. interface, etc
    /// </remarks>
    /// </summary>
    public struct MyStruct
    {
        /// <summary>
        /// static variable name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        public static float MyStaticNumber = 100f;

        /// <summary>
        /// public variable name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        public double MyNumber;

        /// <summary>
        /// public read-only variable name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        public readonly bool IsInit;

        /// <summary>
        /// constructor name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        /// <param name="myNumber">
        /// parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// <remarks>
        /// NOTE pay attention to letter case difference between 'MyNumber' variable and 'myNumber' parameter
        /// </remarks>
        /// </param>
        public MyStruct(double myNumber)
        { // <- opening parenthesis, new line after method name
            MyNumber = myNumber;
            
            // function scope const variable name starts with lower case letter
            // each following word starts with Upper case letter
            // NOTE variable/const definition is close to it's usage scope 
            const bool isInit = true;
            IsInit = isInit;
        } // <- closing parenthesis, new line after last method code line
    }
}