#r "System.Windows.Forms"

using System.Windows;
using System.Windows.Forms;


// lets simplify control creation
// control always has a render surface
public partial class AAA
    {
    
    public class Forms 
        {
        public static Form    Form()    => new Form()  { Text = "..." };    
        public static Button  Button()  => new Button  { Text = "..." };
        public static TextBox Textbox() => new TextBox { Text = "..." };
        }

    }


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
