



// JOIN 
// ATT*** 
// Example only... Join alredy exists in standard lib
static String Joiner( this String[] xStrings )
    {
    var x = new StringBuilder();
    foreach ( var e in xStrings ) { x.Append( e ); };
    return x.ToString();
    }
 
 
 
    