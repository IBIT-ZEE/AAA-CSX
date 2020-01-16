/*

TightVNC Connect back to ibit.dynu.net (5500/default)

Invoke-Expression 
    -Command 
        c:\apl\!TOOLS\_NETWORK\_REMOTE\TightVNC\tvnserver64.exe 
            -controlservice 
            -connect ibit.dynu.net
*/

using System.Diagnostics;

var xProcess = 
    new ProcessStartInfo 
        {
        // FileName = "timedate.cpl",
        FileName = "xx.exe",
        // UserName = "zee",
        // Password = xPass,
        Domain = ".",
        // Arguments = "-optionsfile=x.vnc",
        Arguments = "-connect ibit.dynu.net",
        // behave as started from explorer with "Run as Administrator"
        // Verb = "runas",
        // UseShellExecute = false,            
        // RedirectStandardError = true,
        // RedirectStandardInput = true,
        // RedirectStandardOutput = true
        };

// Process.Start( "control.exe", "timedate.cpl", "zee", xPass, "." );
Process.Start( xProcess );

