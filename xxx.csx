#r "System.Windows.Forms"

using System;
using System.IO;
using System.Windows.Forms;


var x = 1;


Print( f1() );
Print( Enumerable.Range(1,100).Sum() );


// Form f = new System.Windows.Forms.Form();
// f.ShowDialog();



////////////////////////////////////////////////////////////////////////////////////////

DateTime f1() { return System.DateTime.Now; }

void Print( Object x ) { System.Console.Write( x ); }






