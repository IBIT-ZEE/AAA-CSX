using System;
using System.IO;
using System.Net;


System.Console.Write( "\n\n{0}\n\n", pingx( "10.0.0.1" ));


////////////////////////////////////////////////////////////////////////////////
//
//  N|E|T|W|O|R|K
//


// pingx( <address>, <port> )
string pingx( string[] x )
    {
    string addressArgument = null, portArgument = null;
    System.Net.Sockets.TcpClient tcpClient = null;
    
    try
    {
    addressArgument = x[0];
    portArgument = x[1];
    
    int portNumber;
    portNumber = Int32.Parse(portArgument);
    
    tcpClient = new System.Net.Sockets.TcpClient();
    tcpClient.ReceiveTimeout = tcpClient.SendTimeout = 2000;
    
    
    IPAddress address;
    if (IPAddress.TryParse(args[0], out address))
        {
        var endPoint = new System.Net.IPEndPoint(address, portNumber);
        tcpClient.Connect(endPoint);
        }
    else
        { tcpClient.Connect(addressArgument, portNumber); }
    
    Console.WriteLine("Port {0} is listening.", portArgument);
    }
    catch (Exception e)
        {
        if (e is SocketException || e is TimeoutException)
            { Console.WriteLine("Not listening on port {0}.", portArgument); }
        else
            {
            Console.WriteLine("Usage:");
            Console.WriteLine("    portquery [host|ip] [port]");
            }
        }
    finally
        {
        if (tcpClient != null)
        tcpClient.Close();
        }
    }
    
    
