// See https://aka.ms/new-console-template for more information

using Tutorial3;
using Tutorial3.Containers;

Console.WriteLine("Hello, World!");

int? a = 1;
a = null;

// var container = new Container(100.0) { Cargo = 100.0 };
List<int> list = new List<int>() {1,2,3};
Dictionary<PossibleProduct, double> dictionary = new();