#load "AAA-WPF.csx"

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

await Helpers.CreateWpfDispatcherAsync();

MainX();


[STAThread]
void MainX()
    {
    
    Window xWindow;
    xWindow = WindowX();
    xWindow.ShowDialog();
    
    var xPanel = PanelWrapX(); 
    xWindow.Content = xPanel;
    
    xPanel.Children.Add( ButtonX( "111" ) );
    xPanel.Children.Add( ButtonX( "222" ) );
    xPanel.Children.Add( ButtonX( "333" ) );
    
    // Console.Write( "x={0}, y={1}, z={2} ", x, y, z );
    
    
    int xx() => 0; 

    
    }

