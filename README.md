# RotMG-Net-Lib	# RotMG-Net-Lib
Realm of the Mad God Networking C# Library	Realm of the Mad God Networking C# Library


You can use this library to implement your own Realm of the Mad God bots.	RotMG-Net-Lib is an updated and fully working C# port of the RotMG networking logic. 


Check this if you want to use Java library: https://github.com/tripleys/RotMG-Net-JLib	It is used in our [community-driven RotMG port](https://github.com/RealmDev/RotMG-Clone).


Example class:	
```csharp	
    class Program	
    {	
        static void Main(string[] args)	
        {	
            Packets.Load("Packets.json");	
        	
            Reconnect reconnect = new Reconnect()	
            {	
                Host = "54.93.78.148",	
                Port = 2050,	
                GameId = -2,	
                KeyTime = 0,	
                Key = new byte[0]	
            };	
            NetClient client = new NetClient(reconnect);	
            client.Hook(PacketType.Failure, (p) =>	
            {	
                Console.WriteLine("Failure: " + ((FailurePacket)p).ErrorDescription);	
            });	
            client.Hook(PacketType.MapInfo, (p) =>	
            {	
                LoadPacket load = new LoadPacket()	
                {	
                    CharId = 2,	
                    IsFromArena = false	
                };	
                client.SendPacket(load);	
            });	
            client.Hook(PacketType.Update, (p) =>	
            {	
                client.SendPacket(new UpdateAckPacket());	
            });	
            client.Hook(PacketType.NewTick, (p) =>	
            {	
                Console.WriteLine("NEW_TICK, id: " + ((NewTickPacket) p).TickId);	
            });	
            HelloPacket hello = new HelloPacket()	
            {	
                BuildVersion = "X31.2.3",	
                GameId = reconnect.GameId,	
                Guid = RSA.Instance.Encrypt("your email"),	
                Password = RSA.Instance.Encrypt("your password"),	
                Secret = RSA.Instance.Encrypt(""),	
                GameNet = "rotmg",	
                PlayPlatform = "rotmg"	
            };	


            client.SendPacket(hello);	# Contributors


            Console.ReadKey();	
        }	Originally created by [tripleys](https://github.com/tripleys/RotMG-Net-Lib)
    }