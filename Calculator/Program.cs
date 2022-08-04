// See https://aka.ms/new-console-template for more information
// CLI Calculator by KX

using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Calculator;

var calc = new Calculator.Calculator();

calc.ShowMessage( "Calculator MK1" );
calc.ShowMessage( "Please use spaces between numbers / operators" );

calc.GetOperator();
calc.GetNumbers();
// calc.DoOpperation();
calc.ShowResult();

//Debug
// foreach (var number in calc.numbers)
// {
//     Console.WriteLine( number );
// }
