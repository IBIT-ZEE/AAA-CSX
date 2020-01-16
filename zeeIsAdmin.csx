#r "PresentationFramework"

using System;
using System.Windows;
using System.Security;
using System.Security.Principal;

await Helpers.CreateWpfDispatcherAsync();

new Application().Run( new Window0() );

class Window0:Window
    {

    public Window0()
        { 
        if ( IsAdministrator() ) 
            { System.Windows.MessageBox.Show( "ADMIN***\n\n" ); }
        else
            { System.Windows.MessageBox.Show( "NOT-ADMIN***\n\n" ); }

        }

    public bool IsAdministrator()
        {
        WindowsIdentity x = WindowsIdentity.GetCurrent();
        WindowsPrincipal principal = new WindowsPrincipal( x );
        return principal.IsInRole( WindowsBuiltInRole.Administrator );
        }
        
    }


/*
use Impersonation to elevate the state
?how to get xToken 

using( WindowsIdentity.GetCurrent().Impersonate() ) { ... }
-or-
WindowsIdentity identity = new WindowsIdentity( xToken );
WindowsImpersonationContext context = identity.Impersonate();


???
string user = “test”;
string password = “password”;
string machine = “thepc”;
int returnedToken;
// Try to log on.
if (LogonUser(user,machine,password,3,0,out returnedToken))
    {
    IntPtr token = new IntPtr(returnedToken);
    lblLegend.Text = “Token = ” + token.ToString();
    }
*/