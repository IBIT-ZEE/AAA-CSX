
#r "System.Windows.Forms"
// PROCESS

using System;
using System.Diagnostics;
using System.Security;

// can avoid UAC if user is Administrator
// Right Click on project -> Add new item -> Application Manifest File
// [PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]

// var xPass = new SecureString();
// foreach(char e in "zeezee" ) { xPass.AppendChar( e ); }
// System.Windows.Forms.MessageBox.Show( xPass.ToString() );


var xProcess = 
    new ProcessStartInfo 
        {
        // FileName = "timedate.cpl",
        FileName = "xx.exe",
        // UserName = "zee",
        // Password = xPass,
        Domain = ".",
        Arguments = "-optionsfile=x.vnc",      
        // behave as started from explorer with "Run as Administrator"
        // Verb = "runas",
        // UseShellExecute = false,            
        // RedirectStandardError = true,
        // RedirectStandardInput = true,
        // RedirectStandardOutput = true
        };

// Process.Start( "av!.lnk" );
// Process.Start( "explorer.exe", "av!.lnk" );
// Process.Start( "vnc.lnk", "zee-tabletx" );
// Process.Start( "control.exe", "timedate.cpl", "zee", xPass, "." );
// Process.Start( "dos" );
Process.Start( xProcess );


