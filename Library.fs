module NativeLibrary
open System.Runtime.InteropServices
open System

[<UnmanagedCallersOnly(EntryPoint = "add")>]
let Add (a: int) (b: int) : int =
    a + b
    
[<UnmanagedCallersOnly(EntryPoint = "write_line")>]
let WriteLine (pString: IntPtr) : int =
    try
        let str = Marshal.PtrToStringAnsi(pString)
        Console.WriteLine(str)
        0
    with
    | _ -> -1