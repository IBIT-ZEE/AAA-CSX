#r "PresentationFramework"

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
