
#r "System.Windows.Forms"
// PROCESS

using System;
using System.Diagnostics;
using System.Security;

var xPass = new SecureString();

foreach(char e in "xxxyyy" ) { xPass.AppendChar( e ); }
// System.Windows.Forms.MessageBox.Show( xPass.ToString() );


var xProcess = 
    new ProcessStartInfo 
        {
        // FileName = "timedate.cpl",
        UserName = "xxx",
        Domain = ".",
        Password = xPass,
        UseShellExecute = false,
        Verb = "runas",
        // RedirectStandardError = true,
        // RedirectStandardInput = true,
        // RedirectStandardOutput = true
        };

// Process.Start( "control.exe", "timedate.cpl", "zeex", xPass, "." );
Process.Start( xProcess );


