﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESH.Log.Parser.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ValidationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ESH.Log.Parser.Resources.ValidationResources", typeof(ValidationResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid filter date range.
        /// </summary>
        public static string ERR_Filter_Invalid_Date_Range {
            get {
                return ResourceManager.GetString("ERR_Filter_Invalid_Date_Range", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid filter source messages.
        /// </summary>
        public static string ERR_Filter_Invalid_Source_Messages {
            get {
                return ResourceManager.GetString("ERR_Filter_Invalid_Source_Messages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Validation Target.
        /// </summary>
        public static string ERR_Invalid_Target {
            get {
                return ResourceManager.GetString("ERR_Invalid_Target", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required log file does not exist in the path you specified.
        /// </summary>
        public static string ERR_Log_File_Not_Exist {
            get {
                return ResourceManager.GetString("ERR_Log_File_Not_Exist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line format is invalid to be parsed.
        /// </summary>
        public static string ERR_Parser_Invalid_Format {
            get {
                return ResourceManager.GetString("ERR_Parser_Invalid_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target of parsing is either null or invalid.
        /// </summary>
        public static string ERR_Parser_Invalid_Parsing_Target {
            get {
                return ResourceManager.GetString("ERR_Parser_Invalid_Parsing_Target", resourceCulture);
            }
        }
    }
}
