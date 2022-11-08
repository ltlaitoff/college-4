using System;
using System.Net.Sockets;
using System.IO;

class SocketServer
{
	public static void Main()
	{
		StreamWriter streamWriter;
		StreamReader streamReader;
		NetworkStream networkStream;
		TcpListener tcpListener = new TcpListener(5555);
		tcpListener.Start();
		Console.WriteLine("[SERVER]: The Server has started on port 5555");

		Socket serverSocket = tcpListener.AcceptSocket();

		try
		{
			if (serverSocket.Connected)
			{
				while (true)
				{
					Console.WriteLine("[SERVER]: Client connected");
					networkStream = new NetworkStream(serverSocket);
					streamWriter = new StreamWriter(networkStream);
					streamReader = new StreamReader(networkStream);
					Console.WriteLine(streamReader.ReadLine());
				}
			}
			if (serverSocket.Connected)
				serverSocket.Close();
			Console.Read();
		}
		catch (SocketException ex)
		{
			Console.WriteLine("[SERVER]: " + ex);
		}
	}
}