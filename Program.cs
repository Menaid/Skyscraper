

// * Del 1.0 
//string? input = Console.ReadLine();

/*
int realFloor = 14;
int fakeFloors = 0;

for (int count = 1; count <= realFloor + fakeFloors; count++)
{
   
    if (count % 10 == 4)
    {
        fakeFloors++;
    }

    if (count % 100 == 13)
    {
        fakeFloors++;
    }

    Console.WriteLine("floor: " + count + " is actually: " + (count + fakeFloors));
    Console.WriteLine("checking every floor between 1 and " + (realFloor + fakeFloors));

}
    Console.WriteLine("Your  floor  is: " + (realFloor + fakeFloors));

*/
int realFloor = 14;
int fakeFloors = 0;
int while_fake_floors = 0;
int while_count = 1;
    
while (while_count <= realFloor + while_fake_floors)
{
    
    if (while_count % 10 == 4)
    {
        while_fake_floors++;
    }
    
    if (while_count % 100 == 13)
    {
        while_fake_floors++;
    }
    while_count++;
}
    

/*
 
Del 1.1

var f = 13;
   

    if (f % 10 == 4)
    {
        f = f + 1;
    Console.WriteLine(f);
    }

    else if (f % 100 == 13)
    {
        f = f + 2;
        Console.WriteLine(f);
    }

    else if (f % 10 != 4 && f % 100 != 13)
    {
        Console.WriteLine(f);
        f = f + 1;
    }

*/




/*Del 2.0

var f = 16;

if (f % 10 == 4 || f % 100 == 13)
{
    Console.WriteLine("Kan ej omvandla till riktigt våningsnummer");
}

else if (f % 10 == 5 || f % 100 == 14)
{
    f--;
    Console.WriteLine(f); 
}

else
{
    Console.WriteLine(f);
}

*/

//Del 2.1


/*
var f = 1;

while (f <= 500)
{
    Console.WriteLine(f);
}

if (f % 10 == 5 || f % 100 == 14)
{
    f--;
    Console.WriteLine(f);
}

else if (f % 10 == 4 || f % 100 == 13)
{
    Console.WriteLine("Kan ej omvanlda till riktigt våningsnummer");
}

else
{
    Console.WriteLine(f);
}

*/