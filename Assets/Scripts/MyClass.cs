/******************************************************************************
    Style Guidelines:
        * Readability - code is easy to read and to understand
        * Standardisation - all team members are aligned with same code style
        * Self-descriptive code - code is easy to understand without comments
        * Debuggable - code is easy to debug (IDE friendly)
 ******************************************************************************/

// using (imports) of other namespaces will be wrapped with region "Using"
#region Using
using System;
using MyNameSpace.Delegates;
using MyNameSpace.Interfaces;
#endregion

// types are defined within the scope of namespace
// space name starts with Upper case letter
// each following word starts with upper Case letter
// sub-spaces are divided by '.' (dot)
// here "MyNameSpace" is main space and "Classes" is sub-space
namespace MyNameSpace.Classes
{ // <- opening parenthesis, new line after namespace name
    /// <summary>
    /// type name starts with Upper case letter
    /// each following word starts with Upper case letter
    /// <remarks>
    /// type = class, enum, struct, delegate. interface, etc
    /// </remarks>
    /// </summary>
    public class MyCodeStyle : IMyInterface
    { // <- opening parenthesis, new line after type name
        /// <summary>
        /// private variable name starts with "_" (underscore) character
        /// and with lower case letter afterwards
        /// each following word starts with Upper case letter
        /// </summary>
        private int _myInt;

        /// <summary>
        /// protected variable name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        protected float MyFloat;

        /// <summary>
        /// type scope const name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        public const string MyConstString = "Hello My Style!";

        /// <summary>
        /// property name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        public int MyIntProperty
        { // <- opening parenthesis, new line after property name
            // if simple return, can save line space
            // alternative syntax: get => _myInt;
            get { return _myInt; }
            // if public setter is not necessary, private or protected will be used here
            private set
            { // <- opening parenthesis, new line after set/get instruction

                // conditional operator '?' usage
                _myInt = value >= 0 ? value : 0;

                // similar code for easier debugging and future extension
                // with parenthesis
                if (value >= 0)
                {
                    _myInt = value;
                }
                else
                {
                    _myInt = 0;
                }

                // similar code for easier debugging and future extension
                // without parenthesis
                if (value >= 0)
                    _myInt = value;
                else
                    _myInt = 0;
            } // <- closing parenthesis, new line after last set/get code line
        } // <- closing parenthesis, new line after last property code line

        /// <summary>
        /// public event name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// <remarks>
        /// this is simplified style of declaration,
        /// in case no logic in adder/remover is required
        /// </remarks>
        /// </summary>
        public event MyDelegate MyEvent;

        /// <summary>
        /// private event/delegate name starts with "_" (underscore) character
        /// and with lower case letter afterwards
        /// each following word starts with Upper case letter
        /// </summary>
        private event MyDelegate _myEvent;

        // alternative syntax to prevent null ref. exc.
        // private event MyDelegate _myEvent = delegate(int value) {  };

        /// <summary>
        /// public event name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// <remarks>
        /// this style uses expression body style with '=>' operator
        /// code block 'wraps' access for '_myEvent'
        /// </remarks>
        /// </summary>
        public event MyDelegate MyEventWrapper1
        {
            add => _myEvent += value;
            remove => _myEvent -= value;
        }

        /// <summary>
        /// public event name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// <remarks>
        /// this style uses parenthesis
        /// code block 'wraps' access for '_myEvent' and add logic code
        /// </remarks>
        /// </summary>
        public event MyDelegate MyEventWrapper2
        {
            add
            {
                // exception throwing code blocked wrapped with parenthesis to allow better debugging
                if (value == null)
                {
                    throw new NullReferenceException("Null value cannot be accepted");
                }
                _myEvent += value;
            }
            remove
            {
                // short code block, but not debugging friendly
                _myEvent -=
                    value ??
                    // throwing exception here is not a good practice
                    // see next block with better example
                    throw new NullReferenceException("Null value cannot be accepted");

                // alternative: exception throwing code blocked wrapped with parenthesis to allow better debugging
                if (value == null)
                {
                    throw new NullReferenceException("Null value cannot be accepted");
                }
                _myEvent -= value;
            }
        }

        /// <summary>
        /// method name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        /// <param name="numericValue">
        /// parameter name starts with lower case letter
        /// each following word starts with Upper case letter
        /// </param>
        public void MyMethod(int numericValue)
        { // <- opening parenthesis, new line after method name
            // TODO comment
            // BUG comment
            // NOTE comment
        } // <- closing parenthesis, new line after last method code line

        /// <summary>
        /// function name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        /// <param name="worldName">
        /// parameter name starts with lower case letter
        /// each following word starts with Upper case letter
        /// </param>
        /// <returns></returns>
        protected string MyFunction(string worldName)
        {
            // new way: string interpolation with '$' operator (predicate)
            var str1 = $"Hello {worldName}!";

            // old way: use string.Format(...) function to interpolate strings
            var str2 = string.Format("Hello {0}!", worldName);

            return str1 + str2;
        }
    } // <- closing parenthesis, new line after last type code line
} // <- closing parenthesis, new line after last space code line
