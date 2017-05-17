#load "../.paket/load/main.group.fsx"

open System
open System.Net
open System.Net.Http
open System.Threading.Tasks
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Host

let Run(myTimer: TimerInfo, log: TraceWriter) =
    let msg = sprintf "F# Timer trigger function executed at: %s" (let t = DateTime.Now in t.ToString())
    msg |> log.Info
    msg