#load "AAA-Forms.csx"

using System.Windows;
using System.Windows.Forms;


var xForm = AAA.Forms ;


var xWindow0 = new Form();

FlowLayoutPanel xPanel0 = aaaPanel();
xWindow0.Controls.Add( xPanel0 );

xPanel0.Controls.Add( aaaTextbox() );
xPanel0.Controls.Add( aaaButton() );

xWindow0.ShowDialog();

// Console.Write( "x={0}, y={1}, z={2} ", x, y, z );


