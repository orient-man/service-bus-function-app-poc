#load "../.paket/load/main.group.fsx"

open System
open System.Net
open System.Net.Http
open System.Threading.Tasks
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Host

let Run(mySbMsg: string, log: TraceWriter) =
    log.Info(sprintf "F# ServiceBus function processed message: %s" mySbMsg)