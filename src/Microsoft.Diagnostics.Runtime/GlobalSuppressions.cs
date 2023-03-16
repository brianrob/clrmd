// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;
[assembly: SuppressMessage("ApiDesign", "RS0026:Do not add multiple public overloads with optional parameters", Justification = "Backwards compatability", Scope = "member", Target = "~M:Microsoft.Diagnostics.Runtime.DataTarget.LoadDump(System.String,Microsoft.Diagnostics.Runtime.CacheOptions)~Microsoft.Diagnostics.Runtime.DataTarget")]
[assembly: SuppressMessage("ApiDesign", "RS0026:Do not add multiple public overloads with optional parameters", Justification = "Backwards compatability", Scope = "member", Target = "~M:Microsoft.Diagnostics.Runtime.DataTarget.LoadDump(System.String,System.IO.Stream,Microsoft.Diagnostics.Runtime.CacheOptions,System.Boolean)~Microsoft.Diagnostics.Runtime.DataTarget")]
[assembly: SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "vtable", Scope = "member", Target = "~F:Microsoft.Diagnostics.Runtime.Utilities.IUnknownVTable.AddRef")]
[assembly: SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Fixing this would be a breaking change", Scope = "member", Target = "~P:Microsoft.Diagnostics.Runtime.ClrReference.Object")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "IID_ is intentional", Scope = "member", Target = "~F:Microsoft.Diagnostics.Runtime.DacInterface.MetadataImport.IID_IMetaDataImport")]