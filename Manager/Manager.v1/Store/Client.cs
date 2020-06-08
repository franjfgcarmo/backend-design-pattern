using System;
using System.IO;
using System.Net.Sockets;

namespace Manager.v1.Store
{

	public class Client
	{

		private Socket socket;

		private PrintWriter @out;

		private StreamReader @in;

		internal Client()
		{
			try
			{
				socket = new Socket("localhost", 2020);
				Console.WriteLine("Cliente> Establecida conexion");
				Stream outStream = socket.OutputStream;
				Stream inStream = socket.InputStream;
				@out = new PrintWriter(outStream);
				@in = new StreamReader(inStream);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				Console.Write(ex.StackTrace);
				Environment.Exit(0);
			}
		}

		public virtual void Println(string value)
		{
			@out.println(value);
			@out.flush();
		}

		public virtual void Println(int value)
		{
			this.Println("" + value);
		}

		public virtual bool ReadBoolean()
		{
			bool result = false;
			try
			{
				result = bool.Parse(@in.ReadLine());
			}
			catch (IOException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
			return result;
		}

		public virtual int ReadInt()
		{
			int result = -1;
			try
			{
				result = int.Parse(@in.ReadLine());
			}
			catch (IOException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
			return result;
		}

		public virtual void close()
		{
			try
			{
				this.Println(FrameType.CLOSE.ToString());
				@in.Close();
				@out.close();
				socket.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				Console.Write(ex.StackTrace);
			}
		}
	}

}