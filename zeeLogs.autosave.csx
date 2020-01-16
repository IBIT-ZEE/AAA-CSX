

using System.Diagnostics;
using System.Diagnostics.Eventing;
using System.Diagnostics.Eventing.Reader;


EventLog xLog;
xLog = new EventLog("Application", ".");


EventRecord xData;

var xReader = new EventLogReader( "System" ); 

while( ( xData = xReader.ReadEvent() ) != null )
    {
    Console.Write( "{0} {1} {2}\n", xData.TimeCreated, xData.LevelDisplayName, xData.FormatDescription()  );
    }


/*
?external log
using (var reader = new EventLogReader(@"path\to\log.evtx", PathType.FilePath))
{
    EventRecord record;
    while((record = reader.ReadEvent()) != null)
    {
        using (record)
        {
            Console.WriteLine(
                "{0} {1}: {2}", 
                record.TimeCreated, 
                record.LevelDisplayName, 
                record.FormatDescription());
        }
    }        
}
*/