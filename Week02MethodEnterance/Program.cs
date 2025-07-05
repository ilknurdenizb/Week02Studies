
// Method that takes no parameter and returns nothing
void lyrics () 
    {
    Console.WriteLine("And when the seasons change\r\nWill you stand by me?");
}
lyrics();


Console.WriteLine("-------------------------------------");

// Method that takes no parameter and returns an integer
int randomNum()
{
    Random rnd = new Random();
    int num = rnd.Next(0, 200);
    int remain = num % 2;


    return remain;
}
int num2 = randomNum();
Console.WriteLine("The produced remain number: " + num2);


Console.WriteLine("-------------------------------------");
// Method that takes parameters and returns a value

int multiply ( int multiply1, int multiply2)
{
    int result = multiply1 * multiply2;
    return result;
}
int lastResult = multiply(5, 6);
Console.WriteLine("Çarpım sonucu: " +lastResult);

Console.WriteLine("-------------------------------------");

// Method that takes parameters and returns nothing
void printMessage(string name1,string surname1)
{ 
    
    Console.WriteLine("Hoş Geldiniz " + name1 + surname1);
}

printMessage("Deniz " , "Baloglu");

Console.Read(); //To prevent the console window from closing immediately