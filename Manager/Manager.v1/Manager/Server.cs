using Manager.v1.Utils;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Manager.v1.Manager
{ 
	public class Server
	{

		

		private Socket handler;

		private StreamReader @out;

		private StreamReader @in;
		public static string data = null;
		public Server()
		{
			try
			{
				byte[] bytes = new Byte[1024];
				// Establish the local endpoint for the socket.  
				// The DNS name of the computer  
				// running the listener is "host.contoso.com". 
				IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
				IPAddress ipAddress = ipHostInfo.AddressList[0];
				IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 2020);

				// Create a TCP/IP socket.  
				Socket listener = new Socket(ipAddress.AddressFamily,
					SocketType.Stream, ProtocolType.Tcp);

				listener.Bind(localEndPoint);
				listener.Listen(100);


				// Start listening for connections.  
				while (true)
				{
					Console.WriteLine("Waiting for a connection...");
					// Program is suspended while waiting for an incoming connection.  
					handler = listener.Accept();
					data = null;

					// An incoming connection needs to be processed.  
					while (true)
					{
						int bytesRec = handler.Receive(bytes);
						data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
						if (data.IndexOf("<EOF>") > -1)
						{
							break;
						}
					}

					// Show the data on the console.  
					Console.WriteLine("Text received : {0}", data);

					// Echo the data back to the client.  
					byte[] msg = Encoding.ASCII.GetBytes(data);

					handler.Send(msg);
				
				}
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.ToString());
				Console.Write(ex.StackTrace);
			}
		}

		public virtual string ReadLine()
		{
			string result = null;
			try
			{
				result = @in.ReadLine();
			}
			catch (IOException)
			{
				Console.WriteLine("Error en servidor!!! Lectura de string");
			}
			return result;
		}

		public virtual void Println(int value)
		{
			Console.WriteLine("" + value);
			//@out.flush();
		}

		public virtual void Println(bool value)
		{
			Console.WriteLine("" + value);
			//@out.flush();
		}

		public virtual void Close()
		{
			try
			{
				@in.Close();
				@out.Close();
				handler.Shutdown(SocketShutdown.Both);
				handler.Close();
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.ToString());
				Console.Write(ex.StackTrace);
			}
		}
	}

}