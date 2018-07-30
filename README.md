# verge-dotnet
```
____   _________________________   ________ ___________
\   \ /   /\_   _____/\______   \ /  _____/ \_   _____/
 \   Y   /  |    __)_  |       _//   \  ___  |    __)_
  \     /   |        \ |    |   \\    \_\  \ |        \ 2018 VERGE
   \___/   /_______  / |____|_  / \______  //_______  /
                   \/         \/         \/         \/
```
# A dotnet VERGE RPCClient
dotnet-verge is a VERGE RPCclient for dotnet

It is a fork of the excellent Kapitalize Bitcoin Client (now removed from GitHub) intended for use with VERGE. The purpose of this repository is:

* Provide a one-stop resource for the dotnet developer to get started with VERGE integration.
* Prevent would-be VERGE web developers worrying whether a VERGE client will work out of the box, or have to construct their own.
* Promote dotnet development of VERGE web apps.
* Identify and address any incompatibilities with the VERGE APIs that exist now, and/or in the future.

## Dependencies

You'll need a running instance of [verged](https://github.com/vergecurrency/verge) to connect with.

## Examples

Some code examples follow below

```js
IVergeClient client = new VergeClient(username, password, url, port);
var response = await client.GetInfo();
```

```js
Console.WriteLine("Hello HODL!");
IVergeClient client = new VergeClient("testuser", "testpass", "http://127.0.0.1", 20102);
try
{
    var response = client.GetInfo().Result;
    Console.WriteLine(response.Content);
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e);
}
Console.ReadKey();
```


```

## Bounties

[VERGE](http://www.vergecurrency.com) donation address is DQAFGhEwQ8W9aq4dqfetqGQ5coTviaFKdx

Donations in [verge](http://www.vergecurrency.com) will be used for bounties, and holding. As a side note: I encourage all GitHub repository owners to post a donation address so their community can easily support development financially.



