


// Example only... Join alredy exists in standard lib
// OPTIONAL PARAMETERS
static String Joiner( this String[] xStrings, string xGlue = "" )
    {
    var x = new StringBuilder();
    foreach ( var e in xStrings ) 
        { 
        x.Append( e ); 
        x.Append( xGlue ); 
        };
    return x.ToString();
    }
 
 
 
 