﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FAWinFormsLogin.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FAWinFormsLogin.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to CREATE TABLE dbinfo(
        ///	version INT
        ///);
        ///
        ///CREATE TABLE logins(
        ///	site_id INT,
        ///	cookie VARCHAR(255),
        ///	username VARCHAR(64),
        ///	password VARCHAR(128)
        ///);
        ///
        ///CREATE TABLE locations(
        ///	
        ///	source VARCHAR(255),
        ///	pagesource VARCHAR(255),
        ///	path VARCHAR(255)
        ///);
        ///
        ///CREATE TABLE sites(
        ///	site_id INT,
        ///	site VARCHAR(64) NOT NULL
        ///);
        ///
        ///CREATE TABLE watchlist(
        ///	site_id INT,
        ///	author VARCHAR(64),
        ///	watchlist_user VARCHAR(64),
        ///	done BIT DEFAULT 0
        ///);.
        /// </summary>
        internal static string SQL_001 {
            get {
                return ResourceManager.GetString("SQL_001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE INDEX pagesource_index ON locations(pagesource);.
        /// </summary>
        internal static string SQL_002 {
            get {
                return ResourceManager.GetString("SQL_002", resourceCulture);
            }
        }
    }
}
