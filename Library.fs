﻿module NativeLibrary
open System.Runtime.InteropServices
open System
     
[<NativeCallable(EntryPoint = "add", CallingConvention = CallingConvention.Cdecl)>]
let Add (a: int) (b: int) : int =
    a + b
    
[<NativeCallable(EntryPoint = "write_line", CallingConvention = CallingConvention.Cdecl)>]
let WriteLine (pString: IntPtr) : int =
    try
        let str = Marshal.PtrToStringAnsi(pString)
        Console.WriteLine(str)
        0
    with
    | _ -> -1