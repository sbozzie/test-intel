﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestIntelReporter.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TestIntelReporter.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon AppIcon {
            get {
                object obj = ResourceManager.GetObject("AppIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Intel Server rejected your username and password.  Click to change your login information..
        /// </summary>
        internal static string Auth_NotificationText {
            get {
                return ResourceManager.GetString("Auth_NotificationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Intel Reporting Tool.
        /// </summary>
        internal static string Auth_NotificationTitle {
            get {
                return ResourceManager.GetString("Auth_NotificationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server seems to be convinced that you are a Goon spy.  Of course, there are more mundane explainations like you changed your password or AUTH is simply having a bad day.  Check your username and password then try again..
        /// </summary>
        internal static string Authenticate_Auth {
            get {
                return ResourceManager.GetString("Authenticate_Auth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I wasn&apos;t able to make it to the fight in time due to traffic control.  Try again and if you keep having this problem, spam Awol Aurix until this message disappears..
        /// </summary>
        internal static string Authenticate_Network {
            get {
                return ResourceManager.GetString("Authenticate_Network", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:N0} Lost.
        /// </summary>
        internal static string DropCount_Many {
            get {
                return ResourceManager.GetString("DropCount_Many", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:N0} Lost.
        /// </summary>
        internal static string DropCount_One {
            get {
                return ResourceManager.GetString("DropCount_One", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None Lost.
        /// </summary>
        internal static string DropCount_Zero {
            get {
                return ResourceManager.GetString("DropCount_Zero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:N0} Sent.
        /// </summary>
        internal static string IntelCount_Many {
            get {
                return ResourceManager.GetString("IntelCount_Many", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:N0} Sent.
        /// </summary>
        internal static string IntelCount_One {
            get {
                return ResourceManager.GetString("IntelCount_One", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing Sent.
        /// </summary>
        internal static string IntelCount_Zero {
            get {
                return ResourceManager.GetString("IntelCount_Zero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server seems to be convinced that you are a Goon spy.  Of course, there are more mundane explainations like you changed your password or AUTH is simply having a bad day.  Because I like you, I&apos;ll keep trying to log in every couple of minutes to see if AUTH is feeling better..
        /// </summary>
        internal static string IntelStatus_Auth {
            get {
                return ResourceManager.GetString("IntelStatus_Auth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spai!.
        /// </summary>
        internal static string IntelStatus_AuthTitle {
            get {
                return ResourceManager.GetString("IntelStatus_AuthTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I&apos;m trying to get Intel to the server, but Traffic Control keeps getting in my way.  Since EVE is clearly running, it must be a problem with the Intel server.  Go spam Awol Aurix until this message disappears..
        /// </summary>
        internal static string IntelStatus_Error {
            get {
                return ResourceManager.GetString("IntelStatus_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FC, Traffic Control!.
        /// </summary>
        internal static string IntelStatus_ErrorTitle {
            get {
                return ResourceManager.GetString("IntelStatus_ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pizza&apos;s at fault.  It has to be.  The program broke and I don&apos;t know why.  Restart it and let the code diplo (namely, Ranisa Kazuko) know if it happens again..
        /// </summary>
        internal static string IntelStatus_Fatal {
            get {
                return ResourceManager.GetString("IntelStatus_Fatal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AWOX in Progress!.
        /// </summary>
        internal static string IntelStatus_FatalTitle {
            get {
                return ResourceManager.GetString("IntelStatus_FatalTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Since EVE isn&apos;t running, I don&apos;t have any source of intel to report to the server so I am taking a break.  That must be some seriously good forum drama to keep you away from EVE for this long..
        /// </summary>
        internal static string IntelStatus_Idle {
            get {
                return ResourceManager.GetString("IntelStatus_Idle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toxic Forum Drama.
        /// </summary>
        internal static string IntelStatus_IdleTitle {
            get {
                return ResourceManager.GetString("IntelStatus_IdleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I can&apos;t seem to find the EVE chat logs, I know I left them around here somewhere.  Without those logs, how will I possibly know when Pizza&apos;s about to hotdrop me?  This should be idiot-proof, so let Ranisa Kazuko know the current extent of his idiocy..
        /// </summary>
        internal static string IntelStatus_Missing {
            get {
                return ResourceManager.GetString("IntelStatus_Missing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suspected Corp Theft.
        /// </summary>
        internal static string IntelStatus_MissingTitle {
            get {
                return ResourceManager.GetString("IntelStatus_MissingTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Due to either some profound change in the game mechanics or bugs in the intel reporting software, a new version of the reporting tool has been released.  It&apos;s probably CCP&apos;s fault.
        ///
        ///Version Running: {0}
        ///New Version: {1}
        ///Download URL: {2}.
        /// </summary>
        internal static string IntelStatus_Version {
            get {
                return ResourceManager.GetString("IntelStatus_Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to :CCP:.
        /// </summary>
        internal static string IntelStatus_VersionTitle {
            get {
                return ResourceManager.GetString("IntelStatus_VersionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Imaging.Metafile.
        /// </summary>
        internal static System.Drawing.Imaging.Metafile MiddleManagementDino {
            get {
                object obj = ResourceManager.GetObject("MiddleManagementDino", resourceCulture);
                return ((System.Drawing.Imaging.Metafile)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Intel Reporting Tool (Active).
        /// </summary>
        internal static string NotifyIcon_Active {
            get {
                return ResourceManager.GetString("NotifyIcon_Active", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Intel Reporting Tool (Login Rejected).
        /// </summary>
        internal static string NotifyIcon_AuthError {
            get {
                return ResourceManager.GetString("NotifyIcon_AuthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Intel Reporting Tool (Error).
        /// </summary>
        internal static string NotifyIcon_Error {
            get {
                return ResourceManager.GetString("NotifyIcon_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Intel Reporting Tool (Idle).
        /// </summary>
        internal static string NotifyIcon_Inactive {
            get {
                return ResourceManager.GetString("NotifyIcon_Inactive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Intel Reporting Tool (Update Available).
        /// </summary>
        internal static string NotifyIcon_Upgrade {
            get {
                return ResourceManager.GetString("NotifyIcon_Upgrade", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:N0} Sightings of DBRB.
        /// </summary>
        internal static string NoveltyCount_Many {
            get {
                return ResourceManager.GetString("NoveltyCount_Many", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One Sighting of DBRB.
        /// </summary>
        internal static string NoveltyCount_One {
            get {
                return ResourceManager.GetString("NoveltyCount_One", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Sightings of DBRB.
        /// </summary>
        internal static string NoveltyCount_Zero {
            get {
                return ResourceManager.GetString("NoveltyCount_Zero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  // .
        /// </summary>
        internal static string Stats_Join {
            get {
                return ResourceManager.GetString("Stats_Join", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to the Test Alliance Intel Map..
        /// </summary>
        internal static string StatusString_Active {
            get {
                return ResourceManager.GetString("StatusString_Active", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server rejected the username and password..
        /// </summary>
        internal static string StatusString_AuthenticationError {
            get {
                return ResourceManager.GetString("StatusString_AuthenticationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not locate the chat log (tried {1}).
        /// </summary>
        internal static string StatusString_InvalidPath {
            get {
                return ResourceManager.GetString("StatusString_InvalidPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error communicating with server..
        /// </summary>
        internal static string StatusString_NetworkError {
            get {
                return ResourceManager.GetString("StatusString_NetworkError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reporting client is still initializing..
        /// </summary>
        internal static string StatusString_Starting {
            get {
                return ResourceManager.GetString("StatusString_Starting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client is in an unsupported state ({0}).
        /// </summary>
        internal static string StatusString_Unknown {
            get {
                return ResourceManager.GetString("StatusString_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for EVE online to start..
        /// </summary>
        internal static string StatusString_Waiting {
            get {
                return ResourceManager.GetString("StatusString_Waiting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An update to the reporting tool has been released.  Click to download the new version..
        /// </summary>
        internal static string Update_NotificationText {
            get {
                return ResourceManager.GetString("Update_NotificationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Intel Reporting Tool.
        /// </summary>
        internal static string Update_NotificationTitle {
            get {
                return ResourceManager.GetString("Update_NotificationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:N0} People Reporting.
        /// </summary>
        internal static string UserCount_Many {
            get {
                return ResourceManager.GetString("UserCount_Many", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test&apos;s Only Hope.
        /// </summary>
        internal static string UserCount_One {
            get {
                return ResourceManager.GetString("UserCount_One", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Count Invalid.
        /// </summary>
        internal static string UserCount_Zero {
            get {
                return ResourceManager.GetString("UserCount_Zero", resourceCulture);
            }
        }
    }
}
