﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrashReporter.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrashReporter.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Additional information.
        /// </summary>
        internal static string AdditionalInformation {
            get {
                return ResourceManager.GetString("AdditionalInformation", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap arrow {
            get {
                object obj = ResourceManager.GetObject("arrow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration has not been provided.
        /// </summary>
        internal static string ConfigurationAbsent {
            get {
                return ResourceManager.GetString("ConfigurationAbsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration can only be provided once.
        /// </summary>
        internal static string ConfigurationAlreadyProvided {
            get {
                return ResourceManager.GetString("ConfigurationAlreadyProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting....
        /// </summary>
        internal static string Connecting {
            get {
                return ResourceManager.GetString("Connecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to submit the exception ({0})..
        /// </summary>
        internal static string CouldNotSubmitException {
            get {
                return ResourceManager.GetString("CouldNotSubmitException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CrashReporter.NET.
        /// </summary>
        internal static string CrashReporter {
            get {
                return ResourceManager.GetString("CrashReporter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done.
        /// </summary>
        internal static string Done {
            get {
                return ResourceManager.GetString("Done", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap error {
            get {
                object obj = ResourceManager.GetObject("error", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting response....
        /// </summary>
        internal static string GettingResponse {
            get {
                return ResourceManager.GetString("GettingResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending request....
        /// </summary>
        internal static string SendingRequest {
            get {
                return ResourceManager.GetString("SendingRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to submit the report to the server.
        /// </summary>
        internal static string SendReportFailed {
            get {
                return ResourceManager.GetString("SendReportFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URL is required.
        /// </summary>
        internal static string UrlIsRequired {
            get {
                return ResourceManager.GetString("UrlIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version is required.
        /// </summary>
        internal static string VersionIsRequired {
            get {
                return ResourceManager.GetString("VersionIsRequired", resourceCulture);
            }
        }
    }
}