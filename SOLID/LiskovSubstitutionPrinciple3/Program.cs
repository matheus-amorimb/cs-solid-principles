
using ConsoleApp1LiskovSubstitutionPrinciple3;

FlyingBirds bird1 = new Duck("Donald");
bird1.Eat();
bird1.LayEggs();
bird1.Fly();

Birds bird2 = new Penguin("Willy");
bird2.Eat();
bird2.LayEggs();
