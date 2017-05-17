#load "../.paket/load/main.group.fsx"
#r "System.Runtime.Serialization"

open System
open System.Net
open System.Net.Http
open System.Threading.Tasks
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Host
open Microsoft.ServiceBus.Messaging

let Run(req: HttpRequestMessage, log: TraceWriter) =
    async {
        let! reqContent = req.Content.ReadAsStringAsync() |> Async.AwaitTask
        reqContent |> sprintf "Received Request: '%s'" |> log.Info
        return new BrokeredMessage(reqContent, Label = reqContent)
    } |> Async.StartAsTask