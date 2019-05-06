// Learn more about F# at http://fsharp.org

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running


[<MemoryDiagnoser>]
type Bench() =
    [<Benchmark(Baseline=true)>]
    member __.Original() = Old.exec [| "7" |]

    [<Benchmark>]
    member __.New() = New.exec [| "7" |]

[<EntryPoint>]
let main argv =
    let summary = BenchmarkRunner.Run<Bench>()
    printfn "%A" summary

    // printfn "Old"
    // Old.exec [|"7"|]

    // printfn "\nNew"
    // New.exec [|"7"|]

    0 // return an integer exit code
