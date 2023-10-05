string PrintNaturalNumbers (int number)
{
    
    if (number == 1)
        {
            return "1.";
        }
    else return  $"{number}, " + PrintNaturalNumbers(number-1) ;
   
};

Console.WriteLine(PrintNaturalNumbers(10));
