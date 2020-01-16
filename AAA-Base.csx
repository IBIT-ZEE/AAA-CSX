/*
RoslynPad issues that namespaces can not be used in scripts!!!
so use a base classe AAA
and partial inner classes
so 
    AAA.Forms
    AAA.Forms.Flow
    AAA.Forms.Table
    +
    AAA.Forms.Button
    AAA.Forms.Textbox
    AAA.Windows

*/

#load "AAA-Strings.csx"


public class AAA { }


String[] x = { "1", "22", "333", "4444", "55555" };


Console.Write( x.Joiner() );
Console.Write( x.Joiner( ",+++ " ) );


