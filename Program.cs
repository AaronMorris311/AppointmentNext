using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AaronMorris_C969_Task1
{
    static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());

		}
	}
}
