﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WDSE.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WDSE.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to function Coords(el) {
        ///    this.left = parseInt(el.offset().left);
        ///    this.top = parseInt(el.offset().top);
        ///    this.right = parseInt(this.left + el.outerWidth());
        ///    this.bottom = parseInt(this.top + el.outerHeight());
        ///}
        ///
        ///Coords.prototype.toString = function () {
        ///    const x = Math.max(this.left, 0);
        ///    const y = Math.max(this.top, 0);
        ///    return JSON.stringify({
        ///        x: x,
        ///        y: y,
        ///        width: this.right - x,
        ///        height: this.bottom - y
        ///    });
        ///};
        ///
        ///return [(new Coords($( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetElementCoordinates {
            get {
                return ResourceManager.GetString("GetElementCoordinates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var ele = document.createElement(&quot;script&quot;);
        ///ele.src = &quot;https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js&quot;;
        ///var body = document.getElementsByTagName(&quot;head&quot;)[0];
        ///body.appendChild(ele);.
        /// </summary>
        internal static string SetJQuery {
            get {
                return ResourceManager.GetString("SetJQuery", resourceCulture);
            }
        }
    }
}
