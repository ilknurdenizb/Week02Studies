// See https://aka.ms/new-co// Print a motivational message 10 times using a for loop
for (int x = 1; x < 11; x++)  // Writing a motivational message 10 times
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");  // Write prompting message
}


Console.WriteLine("--------------------------------------------------------------------------------------------------");

// Print numbers from 1 to 20
Console.WriteLine("1 ile 20 arasındaki sayılar: "); // Print numbers from 1 to 20

for (int i = 1; i <= 20; i++) // Loop from 1 to 20
{
    Console.WriteLine(i + " ");  // Print each number followed by a space
}

Console.WriteLine("--------------------------------------------------------------------------------------------------");

// Print even numbers between 1 and 20
Console.WriteLine("1 ile 20 arasındaki çift sayılar: ");  // Print even numbers between 1 and 20
for (int k = 1; k < 20; k++)  // Loop through numbers from 1 to 20
{
    if (k % 2 == 0)  // Check if the number is even
    {
        Console.WriteLine(k + " "); // Print the even number followed by a space
    }
}

Console.WriteLine("--------------------------------------------------------------------------------------------------");

// Calculate and print the sum of numbers between 50 and 150
Console.Write("50 ile 150 arasındaki sayıların toplamı:  "); // Print the sum of numbers between 50 and 150
int sum = 0;  // Initialize sum to 0
for (int j = 51; j < 150; j++)  // Loop through numbers from 51 to 149
{
    sum = sum + j;  // Add each number to the sum
}
Console.WriteLine(sum + " "); // Print the total sum

Console.WriteLine("--------------------------------------------------------------------------------------------------");

// Calculate and print the sum of even and odd numbers between 1 and 120
int oddsum = 0; // Initialize odd sum to 0
for (int o = 1; o < 120; o++)  // Loop through numbers from 1 to 119
{
    if (o % 2 == 0)  // Check if the number is even
    {
        oddsum = oddsum + o;  // Add the even number to the odd sum

    }
}

int evensum = 0;  // Initialize even sum to 0

for (int o = 1; o < 120; o++) // Loop through numbers from 1 to 119
{
    if (o % 2 != 0) // Check if the number is odd
    {
        evensum = evensum + o; // Add the odd number to the even sum

    }
}
Console.WriteLine("Çift sayılar toplamı:" + oddsum);  // Print the sum of even numbers
Console.WriteLine("\n\nTek sayılar toplamı:" + evensum); // Print the sum of odd numbers

Console.WriteLine("--------------------------------------------------------------------------------------------------");
