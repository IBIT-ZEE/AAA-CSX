/*

TightVNC Connect back to ibit.dynu.net (5500/default)

Tested 2020.01.07, OK

*/

using System.Diagnostics;

var xProcess = 
    new ProcessStartInfo 
        {
        FileName = "tvnserver32.exe",
        // FileName = "tvnserver64.exe",
        // UserName = "zee",
        // Password = xPass,
        Domain = ".",
        // Arguments = "-optionsfile=x.vnc",
        Arguments = "-controlservice -connect ibit.dynu.net",
        // behave as started from explorer with "Run as Administrator"
        // Verb = "runas",
        // UseShellExecute = false,            
        // RedirectStandardError = true,
        // RedirectStandardInput = true,
        // RedirectStandardOutput = true
        
        //Hides GUI
        // WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        
        //Hides console
        // CreateNoWindow = true;                   
        };

// Process.Start( "control.exe", "timedate.cpl", "zee", xPass, "." );
Process.Start( xProcess );

