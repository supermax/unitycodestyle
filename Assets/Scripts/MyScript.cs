/******************************************************************************
    Style Guidelines:
        * Readability - code is easy to read and to understand
        * Standardisation - all team members are aligned with same code style
        * Self-descriptive code - code is easy to understand without comments
        * Debuggable - code is easy to debug (IDE friendly)
 ******************************************************************************/

// using (imports) of other namespaces will be wrapped with region "Using"
#region Using
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#endregion

// types are defined within the scope of namespace
// space name starts with Upper case letter
// each following word starts with Upper Case letter
// sub-spaces are divided by '.' (dot)
// here "MyNameSpace" is main space and "Scripts" is sub-space
namespace MyNameSpace.Scripts
{
    /// <summary>
    /// type name starts with Upper case letter
    /// each following word starts with Upper case letter
    /// <remarks>
    /// type = class, enum, struct, delegate. interface, etc
    /// </remarks>
    /// </summary>
    public class MyScript : MonoBehaviour
    {
        /// <summary>
        /// private variable name starts with "_" (underscore) character
        /// and with lower case letter afterwards
        /// each following word starts with Upper case letter
        /// </summary>
        private Coroutine _myCoroutine;

        /// <summary>
        /// serializable variable signed with attribute <see cref="SerializeField"/>
        /// if variable is not required for access in child class, it can remain 'private'
        /// naming convention -- similar to private variables
        ///  </summary>
        /// <remarks>
        /// public property 'MyColor' will allow access to '_myColor' value from other types
        /// </remarks>
        [SerializeField]
        private Color _myColor;

        /// <summary>
        /// 'MyColor' returns value of '_myColor'
        /// no setter == not possible to change '_myColor' from another type
        /// naming convention -- similar to public properties
        /// </summary>
        public Color MyColor => _myColor;

        /// <summary>
        /// method name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// <remarks>
        /// unity event methods are 'private' by default
        /// </remarks>
        /// </summary>
        private void Start()
        {
            Debug.LogFormat("{0} started.", nameof(MyScript));

            // opt-1: start 'MyCoroutine' directly and instantiate list in same line
            StartCoroutine(MyCoroutine(new List<GameObject>{gameObject}));

            // opt-2: capture list in local variable for debugging purposes
            var gameObjects = new List<GameObject>{gameObject};
            // start 'MyCoroutine' and capture 'StartCoroutine' result in class variable
            _myCoroutine = StartCoroutine(MyCoroutine(gameObjects));
        }

        /// <summary>
        /// method name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        public void StopMyCoroutine()
        {
            // do not execute function's code in case '_myCoroutine' is null
            if (_myCoroutine == null)
            {
                // this instruction is between parenthesis in order to allow easy breakpoint
                return;
            }
            StopCoroutine(_myCoroutine);
            _myCoroutine = null;
        }

        /// <summary>
        /// method name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        /// <param name="gameObjects">
        /// parameter name starts with lower case letter
        /// each following word starts with Upper case letter
        /// </param>
        /// <remarks>
        /// this function is 'static', since it does not need to access to any members of this class
        /// </remarks>
        private static IEnumerator MyCoroutine(IEnumerable<GameObject> gameObjects)
        {
            // 'var' here can help in future refactoring, if we'll pass other type of list
            foreach (var gameObj in gameObjects)
            {
                // TODO do something with game object and wait one frame
                yield return null;
            }
        }
    }
}
