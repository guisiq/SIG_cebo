namespace SIGCeboDescktopAPP
{
	internal static class Program
	{

		internal static FrmTelaprincipal FrmTelaprincipal = new FrmTelaprincipal();
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			//Application.Run(new inicial());
			Application.Run(FrmTelaprincipal);
		}
	}
}