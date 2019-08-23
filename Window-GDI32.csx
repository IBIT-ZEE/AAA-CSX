
#r "System.Windows.Forms"

using System.Windows;
using System.Windows.Forms;

var xWindow0 = new Form();

FlowLayoutPanel xPanel0 = aaaPanel();
xWindow0.Controls.Add( xPanel0 );

xPanel0.Controls.Add( aaaTextbox() );
xPanel0.Controls.Add( aaaButton() );

xWindow0.ShowDialog();

// Console.Write( "x={0}, y={1}, z={2} ", x, y, z );






///////////////////////////////////////////////////////////////////////////////

Form    aaaWindow()  => new Form()  { Text = "..." };
Button  aaaButton()  => new Button  { Text = "..." };
TextBox aaaTextbox() => new TextBox { Text = "..." };

FlowLayoutPanel aaaPanel() => 
    new FlowLayoutPanel()
		{
		BackColor = System.Drawing.Color.Indigo,
		Dock = DockStyle.Fill,
		Margin = new System.Windows.Forms.Padding(10)
		};

