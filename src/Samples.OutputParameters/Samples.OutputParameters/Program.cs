using System;

namespace Samples.OutputParameters
{
	class Program
	{
		public static int Main(string[] args)
		{
			string currentDirectory;
      		string machineName;
      		string osVersion;
      		string userName;
      		int exitCode;
      Console.WriteLine(Environment.NewLine);
      SetEnviromentProperties(out currentDirectory,
         out machineName,
         out osVersion,
         out userName,
         out exitCode);
      Console.WriteLine("Printing enviroment properties...");
      Console.WriteLine("------------------------------------------");
      Console.WriteLine("Current directory: [{0}]",currentDirectory);
      Console.WriteLine("Machine name:      [{0}]",machineName);
      Console.WriteLine("OS Version:        [{0}]", osVersion);
      Console.WriteLine("User name:         [{0}]",userName);
      Console.WriteLine("Exit code:         [{0}]",exitCode);
      Console.WriteLine("------------------------------------------");
      return 0;
		}
		
		static void SetEnviromentProperties(out string currentDirectory,
    out string machineName,
    out string osVersion,
    out string userName,
    out int exitCode)
    {
      //setting values to the variables
      currentDirectory = Environment.CurrentDirectory;
      machineName = Environment.MachineName;
      osVersion = Environment.OSVersion.ToString();
      userName = Environment.UserName;
      exitCode = Environment.ExitCode;
      
    }
	}
}