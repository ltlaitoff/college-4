using System;
using System.Net.Sockets;
using System.IO;


class SocketClient
{
	static void Main(string[] args)
	{
		TcpClient tcpClient;
		NetworkStream networkStream;
		StreamReader streamReader;
		StreamWriter streamWriter;

		try
		{
			tcpClient = new TcpClient("localhost", 5555);
			networkStream = tcpClient.GetStream();
			streamReader = new StreamReader(networkStream);
			streamWriter = new StreamWriter(networkStream);
			streamWriter.WriteLine("Message from the Client...");
			Console.WriteLine("[CLIENT]: Message has been sended");
			streamWriter.Flush();
		}
		catch (SocketException ex)
		{
			Console.WriteLine("[CLIENT]: " + ex);
		}

		Console.Read();
	}
}