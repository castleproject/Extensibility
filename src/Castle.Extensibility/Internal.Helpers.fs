﻿[<AutoOpen>]
module Helpers
    
    open System
    open System.Collections.Generic
    open System.Linq
    open System.Reflection
    open System.Dynamic
    open System.Security
    open System.Reflection
    open System.Runtime.CompilerServices
    open System.Runtime.InteropServices

    // [<assembly: PrimaryInteropAssemblyAttribute(1, 0)>]
    [<assembly: Guid("6ba98de8-52cf-4826-b1e0-8fe20318f2de")>]
    [<assembly: AssemblyVersion("0.1.0.0")>]
    [<assembly: AssemblyFileVersion("0.1.0.0")>]
    [<assembly: AllowPartiallyTrustedCallers>]
    [<assembly: SecurityRules(SecurityRuleSet.Level2)>]
    do
        // 
        ()


    let inline (==) a b = Object.ReferenceEquals(a, b)
    let inline (!=) a b = not (Object.ReferenceEquals(a, b))

    let inline (<!>) (a:'a) (b:'a) = 
        if a <> null then a else b 