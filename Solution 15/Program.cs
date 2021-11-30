//15. Дано число. Проверить кратно ли оно 7 и 23

int numberA = new Random ().Next(1,1000);
Console.WriteLine(numberA);
if(numberA % 7== 0 && numberA % 23 == 0)
{
Console.WriteLine ( "число кратно 7 и 23");
}
else
{
Console.WriteLine( "не кратно 7 и 23");
}

//if(chislo%7==0)System.Console.WriteLine("{0} - кратно 7.",chislo);
