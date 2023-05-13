//await PrintAsync();
//

//PrintMessage("Hello Bob");
//PrintMessage("Hello Tom");
//PrintMessage("Hello Sam");
/*
var bob = PrintAsync("Hello Bob");
var tom = PrintAsync("Hello Tom");
var sam = PrintAsync("Hello Sam");

await bob;
await tom;
await sam;
*/
/*
Func<string, Task> PrintLambdaAsync = async (message) =>
{
    await Task.Delay(3000);
    await Console.Out.WriteLineAsync(message);
};
*/
//var t = PrintLambdaAsync("Tom");
//var s = PrintLambdaAsync("Sam");
//var b = PrintLambdaAsync("Bob");

//await Task.WhenAll(t, s, b);

//var a1 = AmountAsync(50);
//var a2 = AmountAsync(50);
/*
var a1 = AmountAsync(50);
var a2 = AmountAsync(60);
var a3 = AmountAsync(70);

var results = await Task.WhenAny(a1, a2, a3);
Console.WriteLine(results.Result);
*/
//for(int i = 0; i < results.Length; i++)
//    Console.WriteLine(results[i]);


//Console.WriteLine($"{await a1.AsTask()} {await a2.AsTask()}");


try
{
    var p1 = PrintAsync("Hello");
    var p2 = PrintAsync("Hi");
    var p3 = PrintAsync("Good by");

    await p1;
    await p2;
    await p3;
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Other code");


async Task PrintAsync(string message)
{
    if (message.Length < 3)
        throw new Exception($"{message} small length");
    await Task.Delay(3000);
    await Task.Run(() => PrintMessage(message));
}

void PrintMessage(string message)
{
    Thread.Sleep(3000);
    Console.WriteLine(message);
}

async Task<int> AmountAsync(int number)
{
    
    int amount = 0;
    for (int i = 1; i <= number; i++)
    {
        await Task.Delay(100);
        amount += i;
    }
        
    return amount;
}

async ValueTask<int> AmountValueAsync(int number)
{

    int amount = 0;
    for (int i = 1; i <= number; i++)
    {
        await Task.Delay(100);
        amount += i;
    }

    return amount;
}