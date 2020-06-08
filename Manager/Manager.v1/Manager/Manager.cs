using Manager.v1.Utils;

namespace Manager.v1.Manager
{
	public abstract class Manager
	{

		protected internal IStore store;

		protected internal Manager()
		{
			store = this.CreateStore();
		}

		protected internal abstract IStore CreateStore();

		public virtual void Manage()
		{
			int option;
			do
			{
				this.ShowStore();
				option = this.ExecuteMenu();
				if (option != 3)
				{
					int code = LimitedIntDialog.Instance().Read("Código? ", 100);
					int amount = LimitedIntDialog.Instance().Read("Cantidad? ", 100);
					switch (option)
					{
					case 1:
						store.Add(code, amount);
						break;
					case 2:
						if (store.Exist(code, amount))
						{
							store.Remove(code, amount);
						}
						else
						{
							IO.Instance().Writeln("Error!!! No hay existencias");
						}
						break;
					}
				}
			} while (option != 3);
		}

		private void ShowStore()
		{
			int[][] list = store.List();
			IO.Instance().Writeln("STORE");
			foreach (int[] product in list)
			{
				IO.Instance().Writeln("Código: " + product[0] + ", cantidad:" + product[1]);
			}
			IO.Instance().Writeln();
		}

		private int ExecuteMenu()
		{
			IO.Instance().Writeln("1. Alta de producto");
			IO.Instance().Writeln("2. Baja de producto");
			IO.Instance().Writeln("3. Salir");
			int option = LimitedIntDialog.Instance().Read("Opción? ", 3);
			return option;
		}

	}

}