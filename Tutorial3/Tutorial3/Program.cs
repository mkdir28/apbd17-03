// See https://aka.ms/new-console-template for more information

using Tutorial3;
using Tutorial3.Containers;

// Console.WriteLine("Hello, World!");
//
// int? a = 1;
// a = null;

// var container = new Container(100.0) { Cargo = 100.0 };
// List<int> list = new List<int>() {1,2,3};
// Dictionary<PossibleProduct, double> dictionary = new();

LiquidContainer liquidContainer = new LiquidContainer(12, 100, 20, 22, "KON-C-1", 120);
GasContainer gasContainer = new GasContainer(22, 120, 33, 22, "KON-C-2", 100, 3);


// Create a refrigerated container
RefrigeratedContainer container1 = new RefrigeratedContainer(PossibleProduct.Bananas, 13, 13.3, 12,
    100, 20, 22, "KON-C-1", 120);

// Create another refrigerated container
RefrigeratedContainer container2 = new RefrigeratedContainer(PossibleProduct.Fish, 2, 2, 10, 10, 20, 22,
    "KON-C-3", 50);


// Create a ship container
ShipContainer ship = new ShipContainer(30, 100, 4000, PossibleProduct.Meat, -15,
    -15, 40,100,27,40,"K0N-C-4", 200);



// Load containers onto the ship
ship.LoadContainerIntoShip(new List<RefrigeratedContainer> { container1, container2 });

// Print information about the ship and its cargo
ship.PrintInfoShip();

// Unload a container from the ship
ship.UnloadContainer(container1);

// Print updated information about the ship and its cargo
ship.PrintInfoShip();

// Replace a container on the ship with another container
RefrigeratedContainer newContainer = new RefrigeratedContainer(PossibleProduct.Chocolate, 18, 18, 10, 20, 10, 15, "KON-C-5", 30);
ship.ReplaceContainerWithGivenNumber(container2, newContainer);

// Print updated information about the ship and its cargo
ship.PrintInfoShip();

// Transfer a container between two ships
ShipContainer anotherShip = new ShipContainer(30, 100, 4000, PossibleProduct.Meat, -15,
    -15, 40,100,27,40,"K0N-C-4", 200);
ShipContainer.TransferBetweenTwoShips(ship, anotherShip, newContainer);

// Print information about both ships and their cargo after the transfer
Console.WriteLine("Information about the first ship:");
ship.PrintInfoShip();
Console.WriteLine("\nInformation about the second ship:");
anotherShip.PrintInfoShip();