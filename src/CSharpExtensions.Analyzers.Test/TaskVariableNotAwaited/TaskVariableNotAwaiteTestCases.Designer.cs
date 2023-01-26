﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpExtensions.Analyzers.Test.TaskVariableNotAwaited {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TaskVariableNotAwaiteTestCases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TaskVariableNotAwaiteTestCases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CSharpExtensions.Analyzers.Test.TaskVariableNotAwaited.TaskVariableNotAwaiteTestC" +
                            "ases", typeof(TaskVariableNotAwaiteTestCases).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var [|t1|] = Task.Delay(10);
        ///            await Task.Delay(10);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string _001_UnawaitedTask {
            get {
                return ResourceManager.GetString("_001_UnawaitedTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var [|t1|] = Task.Delay(10);
        ///            await Task.Delay(10);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///            await t1;
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string _002_AwaitedTask {
            get {
                return ResourceManager.GetString("_002_AwaitedTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var [|t1|] = Task.Delay(10);
        ///            var t2 = Task.Delay(10);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///            await Task.WhenAll(t1, t2);
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string _003_Task_WhenCall {
            get {
                return ResourceManager.GetString("_003_Task_WhenCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var [|t1|] = Task.Delay(10);
        ///            await Task.Delay(10);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///            t1.Wait();
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string _004_SyncWait {
            get {
                return ResourceManager.GetString("_004_SyncWait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var t1 = Task.Delay(10);
        ///            var [|t2|] = CalculateAsync();
        ///            await Task.Delay(10);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///            await Task.WhenAny(t1, t2);
        ///        }
        ///
        ///        private static Task&lt;int&gt; CalculateAsync() =&gt; throw null;
        ///    }
        ///}.
        /// </summary>
        internal static string _005_AwaitMixed {
            get {
                return ResourceManager.GetString("_005_AwaitMixed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var [|t2|] = CalculateAsync();
        ///            await Task.Delay(10);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///            Swallow(t2);
        ///        }
        ///
        ///
        ///        private static Task&lt;int&gt; CalculateAsync() =&gt; throw null;
        ///        private static void Swallow(Task&lt;int&gt; a) =&gt; throw null;
        ///    }
        ///}.
        /// </summary>
        internal static string _006_PassedToMethod {
            get {
                return ResourceManager.GetString("_006_PassedToMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var [|arr|] = new []
        ///            {
        ///                Task.Delay(10),
        ///                Task.Delay(20)
        ///            }
        ///            await Task.Delay(20);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///        }
        ///
        ///        private static Task&lt;int&gt; CalculateAsync() =&gt; throw null;
        ///        private static void Swallow(Task&lt;int&gt; a) =&gt; throw null;
        ///    }
        ///}.
        /// </summary>
        internal static string _007_TaskArray {
            get {
                return ResourceManager.GetString("_007_TaskArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public async Task Test()
        ///        {
        ///            var [|a|] = Task.Delay(10);
        ///            var b = a;
        ///            await Task.Delay(20);
        ///            Console.WriteLine(&quot;Finish&quot;);
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string _008_AssignedToOther {
            get {
                return ResourceManager.GetString("_008_AssignedToOther", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Threading.Tasks;
        ///
        ///namespace TestNamespace
        ///{
        ///    class SampleClass
        ///    {
        ///        public Task Test()
        ///        {
        ///            var [|t2|] = CalculateAsync();
        ///            if(DateTime.Now.IsDaylightSavingTime())
        ///            {
        ///                return t2;
        ///            }
        ///            return Task.CompletedTask;
        ///        }
        ///
        ///
        ///        private static Task&lt;int&gt; CalculateAsync() =&gt; throw null;
        ///        private static void Swallow(Task&lt;int&gt; a) =&gt; throw null;
        ///    }
        ///}.
        /// </summary>
        internal static string _009_ReturnedTask {
            get {
                return ResourceManager.GetString("_009_ReturnedTask", resourceCulture);
            }
        }
    }
}