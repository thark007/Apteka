using System;
using System.Data.SqlClient;

namespace Main
{
	public abstract class ActiveRecord
	{
		static string connectionString = "Integrated Security=SSPI;" +
										"Data Source=.\\SQLEXPRESS;" +
										"Initial Catalog=Pharmacy;";
		SqlConnection sqlConnection = new SqlConnection(connectionString);

		public readonly int ID;

		public abstract void Save();
		public abstract void Reload();
		public abstract void Remove();
		protected void Open()
		{
			try
			{
				sqlConnection.Open();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		protected void Close()
		{
			try
			{
				sqlConnection.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}

