#r "PresentationFramework"

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

// WPF/Thread fix
await Helpers.RunWpfAsync();

MainX();


[STAThread]
void MainX()
    {
      
    Window xWindow;
    xWindow = WindowX();
    xWindow.Show();
    
    var xPanel = PanelWrapX(); 
    xWindow.Content = xPanel;
    
    xPanel.Children.Add( ButtonX( "111" ) );
    xPanel.Children.Add( ButtonX( "222" ) );
    xPanel.Children.Add( ButtonX( "333" ) );
    
    // Console.Write( "x={0}, y={1}, z={2} ", x, y, z );
    Console.Read();


    int xx() => 0;


}


////////////////////////////////////////////////////////////////////////////////
//
//  FACTORY-WPF
//

// WINDOW
Window WindowX(String x = "Window") =>
    new Window() 
        { 
        Title = x,
        Background = Brushes.Khaki,
        // Content = ButtonX()
        };

// PANEL-STACK
StackPanel PanelStackX() => 
    new StackPanel()
		{
		Background = Brushes.Aquamarine,
		//Width = 256,
		Orientation = System.Windows.Controls.Orientation.Horizontal ,
		VerticalAlignment = VerticalAlignment.Center,
		Margin = new System.Windows.Thickness( 50 )
		};

// PANEL-WRAP
WrapPanel PanelWrapX() =>
    new WrapPanel()
    {
    Background = Brushes.Wheat,
    Margin = new System.Windows.Thickness( 64 )
    };

// BUTTON
Button ButtonX( String x = "Button" ) =>
    new Button()
    {
    Content = x,
    Background = Brushes.Red,
    // Margin = new System.Windows.Thickness( 64 )
    };
