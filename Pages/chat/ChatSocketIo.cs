using Quobject.SocketIoClientDotNet.Client;
using SocketIOClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class FileDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; internal set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }

        [JsonPropertyName("bytes")]
        public byte[] Bytes { get; set; }
        
    }
    public class ChatSocketIo
    {
        public async void ChatSIO()
        {
            var client = new SocketIO("http://localhost:11000/");

            client.On("hi", response =>
            {
                // You can print the returned data first to decide what to do next.
                // output: ["hi client"]
                Console.WriteLine(response);

                string text = response.GetValue<string>();

                // The socket.io server code looks like this:
                // socket.emit('hi', 'hi client');
            });

            client.On("test", response =>
            {
                // You can print the returned data first to decide what to do next.
                // output: ["ok",{"id":1,"name":"tom"}]
                Console.WriteLine(response);

                // Get the first data in the response
                string text = response.GetValue<string>();
                // Get the second data in the response
                var dto = response.GetValue<FileDTO>(1);

                // The socket.io server code looks like this:
                // socket.emit('hi', 'ok', { id: 1, name: 'tom'});
            });

            client.OnConnected += async (sender, e) =>
            {
                // Emit a string
                await client.EmitAsync("hi", "socket.io");

                // Emit a string and an object
                var dto = new FileDTO { Id = 123, Name = "bob" };
                await client.EmitAsync("register", "source", dto);
            };
            await client.ConnectAsync();
        }

    }

}

