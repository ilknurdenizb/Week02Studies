
//Writes 10 motivational messages using a while loop
int i = 0;
while (i < 10) // Loop until i is less than 10
{ Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!"); // Print motivational message
    i++;  // Increment i by 1
}
Console.WriteLine("------------------------------------------------------------------------");

int j = 0;
while (j < 20)
{
    Console.WriteLine(j + 1); // Print numbers from 1 to 20
    j++; // Increment j by 1
}

Console.WriteLine("------------------------------------------------------------------------");

int k = 0; // Initialize k to 0
while (k <= 20) // Loop until k is less than 20
{  if (k % 2 == 0 ) // Check if k is even
    { Console.WriteLine(k); // Print even numbers from 1 to 20
    }
    k++; // Increment k by 1
}

Console.WriteLine("------------------------------------------------------------------------");

int total = 0; // Initialize total to 0
int l = 50; // Initialize l to 50
while (l <= 150) // Loop until l is greater than 100
{ total += l; // Add l to total
    l++; // Increment l by 1
}
Console.WriteLine("50 ile 150 arasındaki  sayıların toplamı: " + total); // Print the total sum from 50 to 150
Console.WriteLine("------------------------------------------------------------------------");

int evenSum = 0; // Initialize evenSum to 0
int oddSum = 0; // Initialize oddsSum to 0
int m = 1; // Initialize m to 1
while (m <= 120) // Loop until m is greater than 120
{ if (m % 2 == 0) // Check if m is even
    { evenSum += m; // Add m to evenSum
    }
    else // If m is odd
    { oddSum += m; // Add m to oddSum
    }
    m++; // Increment m by 1
}
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenSum); // Print the sum of even numbers from 1 to 120
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " +oddSum); // Print the sum of odd numbers from 1 to 120