// See https://aka.ms/new-console-template for more information
// CLI Calculator by KX

using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Calculator;

var calc = new Calculator.Calculator();
var stop = false;

while ( !stop ) 
{
    calc.ShowMessage( "***************************************" );
    calc.ShowMessage( "****         - Calculator -        ****" );
    calc.ShowMessage( "**** Accepts integers and decimals ****" );
    calc.ShowMessage( "***************************************" );
    calc.GetOperator();
    calc.GetNumbers();
    calc.DoOpperation();
    calc.ShowResult();
    calc.ShowMessage( "****                               ****" );
    calc.ShowMessage( "***************************************" );
    
    Console.WriteLine("****       exit ? y/n      ****" );
    Console.WriteLine("**** ");

    var check = Console.ReadLine();

    if (check == "y")
    {
        stop = true;
    }
    calc.reset();
}


