﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.WebJobs.Script.WebHost.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.WebJobs.Script.WebHost.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Two or more function apps are sharing the same secrets ({0}).
        /// </summary>
        internal static string ErrorSameSecrets {
            get {
                return ResourceManager.GetString("ErrorSameSecrets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Repository has more than {0} non-decryptable secrets backups ({1}). {2}.
        /// </summary>
        internal static string ErrorTooManySecretBackups {
            get {
                return ResourceManager.GetString("ErrorTooManySecretBackups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;type&quot;: &quot;object&quot;,
        ///    &quot;properties&quot;: {
        ///        &quot;key&quot;: {
        ///            &quot;type&quot;: [
        ///                &quot;string&quot;
        ///            ]
        ///        }
        ///    },
        ///    &quot;required&quot;: [
        ///        &quot;key&quot;
        ///    ]
        ///}.
        /// </summary>
        internal static string FunctionSecretsSchemaV0 {
            get {
                return ResourceManager.GetString("FunctionSecretsSchemaV0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;definitions&quot;: {
        ///        &quot;key&quot;: {
        ///            &quot;type&quot;: [
        ///                &quot;object&quot;,
        ///                &quot;null&quot;
        ///            ],
        ///            &quot;properties&quot;: {
        ///                &quot;name&quot;: {
        ///                    &quot;type&quot;: [
        ///                        &quot;string&quot;,
        ///                        &quot;null&quot;
        ///                    ]
        ///                },
        ///                &quot;value&quot;: {
        ///                    &quot;type&quot;: [
        ///                        &quot;string&quot;,
        ///                        &quot;null&quot;
        ///                    ]
        ///                },
        ///              [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FunctionSecretsSchemaV1 {
            get {
                return ResourceManager.GetString("FunctionSecretsSchemaV1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;Your Azure Function App is up and running.&lt;/title&gt;
        ///    &lt;style type=&quot;text/css&quot;&gt;
        ///        @font-face {
        ///            font-family: &apos;SegoeLight&apos;;
        ///            src: url(//:) format(&apos;no404&apos;), url(data:font/woff;charset=utf-8;base64,d09GRgABAAAAAFbcABAAAAAAjewAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAABGRlRNAAABbAAAABsAAAAcWqtaPUdERUYAAAGIAAAAHQAAACABGAADT1MvMgAAAagAAABYAAAAYGrqcLZjbWFwAAACAAAAAaIAAAIKczqUA2N2dCAAAAOkAAAATAAAAEwOEAwRZnBnbQAAA/AAAAGxAAACZQ+0L6dnYXNwAAAFpAAAAAwAAAAMAA [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Homepage {
            get {
                return ResourceManager.GetString("Homepage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;type&quot;: &quot;object&quot;,
        ///    &quot;properties&quot;: {
        ///        &quot;masterKey&quot;: {
        ///            &quot;type&quot;: [
        ///                &quot;string&quot;
        ///            ]
        ///        },
        ///        &quot;functionKey&quot;: {
        ///            &quot;type&quot;: [
        ///                &quot;string&quot;
        ///            ]
        ///        }
        ///    },
        ///    &quot;required&quot;: [
        ///        &quot;masterKey&quot;,
        ///        &quot;functionKey&quot;
        ///    ]
        ///}.
        /// </summary>
        internal static string HostSecretsSchemaV0 {
            get {
                return ResourceManager.GetString("HostSecretsSchemaV0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;definitions&quot;: {
        ///        &quot;key&quot;: {
        ///            &quot;type&quot;: [
        ///                &quot;object&quot;,
        ///                &quot;null&quot;
        ///            ],
        ///            &quot;properties&quot;: {
        ///                &quot;name&quot;: {
        ///                    &quot;type&quot;: [
        ///                        &quot;string&quot;,
        ///                        &quot;null&quot;
        ///                    ]
        ///                },
        ///                &quot;value&quot;: {
        ///                    &quot;type&quot;: [
        ///                        &quot;string&quot;,
        ///                        &quot;null&quot;
        ///                    ]
        ///                },
        ///              [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HostSecretsSchemaV1 {
            get {
                return ResourceManager.GetString("HostSecretsSchemaV1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting host specialization.
        /// </summary>
        internal static string HostSpecializationTrace {
            get {
                return ResourceManager.GetString("HostSpecializationTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error deleting Swagger document.
        /// </summary>
        internal static string SwaggerFileDeleteError {
            get {
                return ResourceManager.GetString("SwaggerFileDeleteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading Swagger document.
        /// </summary>
        internal static string SwaggerFileReadError {
            get {
                return ResourceManager.GetString("SwaggerFileReadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error updating Swagger document.
        /// </summary>
        internal static string SwaggerFileUpdateError {
            get {
                return ResourceManager.GetString("SwaggerFileUpdateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating Swagger document....
        /// </summary>
        internal static string SwaggerGenerateDocument {
            get {
                return ResourceManager.GetString("SwaggerGenerateDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} secret &apos;{1}&apos; for &apos;{2}&apos; {3}..
        /// </summary>
        internal static string TraceAddOrUpdateFunctionSecret {
            get {
                return ResourceManager.GetString("TraceAddOrUpdateFunctionSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function (&apos;{0}&apos;) secrets do not exist. Generating secrets..
        /// </summary>
        internal static string TraceFunctionSecretGeneration {
            get {
                return ResourceManager.GetString("TraceFunctionSecretGeneration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function (&apos;{0}&apos;) keys are loaded..
        /// </summary>
        internal static string TraceFunctionsKeysLoaded {
            get {
                return ResourceManager.GetString("TraceFunctionsKeysLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host keys are loaded..
        /// </summary>
        internal static string TraceHostKeysLoaded {
            get {
                return ResourceManager.GetString("TraceHostKeysLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host secrets do not exist. Generating secrets..
        /// </summary>
        internal static string TraceHostSecretGeneration {
            get {
                return ResourceManager.GetString("TraceHostSecretGeneration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secret &apos;{0}&apos; for &apos;{1}&apos; {2}..
        /// </summary>
        internal static string TraceKeysApiSecretChange {
            get {
                return ResourceManager.GetString("TraceKeysApiSecretChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Master key {0}.
        /// </summary>
        internal static string TraceMasterKeyCreatedOrUpdated {
            get {
                return ResourceManager.GetString("TraceMasterKeyCreatedOrUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-decryptable function (&apos;{0}&apos;) secrets detected. Refreshing secrets..
        /// </summary>
        internal static string TraceNonDecryptedFunctionSecretRefresh {
            get {
                return ResourceManager.GetString("TraceNonDecryptedFunctionSecretRefresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-decryptable host secrets detected. Refreshing secrets..
        /// </summary>
        internal static string TraceNonDecryptedHostSecretRefresh {
            get {
                return ResourceManager.GetString("TraceNonDecryptedHostSecretRefresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} secret &apos;{1}&apos; deleted..
        /// </summary>
        internal static string TraceSecretDeleted {
            get {
                return ResourceManager.GetString("TraceSecretDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secrets manager initialized, repository type: {0}.
        /// </summary>
        internal static string TraceSecretsRepo {
            get {
                return ResourceManager.GetString("TraceSecretsRepo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stale function (&apos;{0}&apos;) secrets detected. Refreshing secrets..
        /// </summary>
        internal static string TraceStaleFunctionSecretRefresh {
            get {
                return ResourceManager.GetString("TraceStaleFunctionSecretRefresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stale host secrets detected. Refreshing secrets..
        /// </summary>
        internal static string TraceStaleHostSecretRefresh {
            get {
                return ResourceManager.GetString("TraceStaleHostSecretRefresh", resourceCulture);
            }
        }
    }
}
