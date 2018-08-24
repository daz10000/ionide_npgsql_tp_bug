open FSharp.Data.Npgsql

type Db = NpgsqlConnection<"Host=localhost;Username=foo;Password=bar;Database=mydb">

[<EntryPoint>]
let main argv =
    0 
