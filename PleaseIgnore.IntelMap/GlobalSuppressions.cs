// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

// The container manages it's own internals, so Add() just throws
// NotSupportedException
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelContainer.#System.ComponentModel.IContainer.Add(System.ComponentModel.IComponent)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelContainer.#System.ComponentModel.IContainer.Add(System.ComponentModel.IComponent,System.String)")]
// Methods that /do/ call a base member, but the analyzer doesn't
// seem capable of realizing that.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelContainer.#System.ComponentModel.IContainer.Components")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelContainer.#System.ComponentModel.IContainer.Remove(System.ComponentModel.IComponent)")]
// The collection is read-only and the explicit interface implementations
// just throw NotSupportedException. 
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelCollection.#System.Collections.Generic.IList`1<PleaseIgnore.IntelMap.IntelChannel>.RemoveAt(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelCollection.#System.Collections.Generic.ICollection`1<PleaseIgnore.IntelMap.IntelChannel>.Remove(PleaseIgnore.IntelMap.IntelChannel)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelCollection.#System.Collections.Generic.IList`1<PleaseIgnore.IntelMap.IntelChannel>.Insert(System.Int32,PleaseIgnore.IntelMap.IntelChannel)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelCollection.#System.Collections.Generic.ICollection`1<PleaseIgnore.IntelMap.IntelChannel>.Clear()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelCollection.#System.Collections.Generic.ICollection`1<PleaseIgnore.IntelMap.IntelChannel>.Add(PleaseIgnore.IntelMap.IntelChannel)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelCollection.#System.Collections.Generic.ICollection`1<PleaseIgnore.IntelMap.IntelChannel>.IsReadOnly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "PleaseIgnore.IntelMap.IntelChannelCollection.#System.Collections.Generic.IList`1<PleaseIgnore.IntelMap.IntelChannel>.Item[System.Int32]")]

// Just added
