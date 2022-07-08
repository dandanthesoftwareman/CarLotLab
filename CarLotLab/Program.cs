using CarLotLab;

//list of vehicles
List<Car> carList = new List<Car>()
{
    new Car("Tesla", "Model 3", 2022,50000),
    new Car("Ford","F-150", 2022, 45000),
    new Car("Lamborghini","Urus",2022,300000),
    new UsedCar("Toyota","Supra",1998,100000,10000),
    new UsedCar("Acura","NSX",1996,80000,30000),
    new UsedCar("Ferrari", "Testarossa",1986,70000,120000),
};

ListCars();
Console.WriteLine("Which car would you like to buy? Please enter a number.");
int choice = int.Parse(Console.ReadLine());
Console.WriteLine();
for(int i = 0; i < carList.Count; i++)
{
    if(i +1 == choice)
    {
        Console.WriteLine(carList[i]);
    }
}
Remove(choice);
Console.WriteLine();
ListCars();
Console.WriteLine("Awesome! Our finance department will contact you regarding the paperwork.\nHave a nice day!");
Console.Read();



//methods

//loops through list and prints out each member and index in list
void ListCars()
{
    for(int i = 0; i < carList.Count; i++)
    {
        
        Console.WriteLine($"{i + 1}. {carList[i]}");
    }

}

//user enters an integer which then removes the vehicle at that index
void Remove(int choice)
{
    carList.Remove(carList[choice -1]);
}