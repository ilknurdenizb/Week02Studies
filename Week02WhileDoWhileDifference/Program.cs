//while loop for writing motivational messages according to user input limit
Console.Write("Lütfen bir limit değeri giriniz: ");
int limitwhile = Convert.ToInt32(Console.ReadLine()); // Read the limit from user input
int recorder = 0; // Initialize recorder to 0
while (recorder < limitwhile) // Loop until recorder is less than limit
{ 
    Console.WriteLine("Ben bir Patika'lıyım"); // Print motivational message
    recorder++; // Increment recorder by 1
}

Console.WriteLine("------------------------------------------------------------------------");

//do-while loop for writing motivational messages according to user input limit
Console.Write("Lütfen bir limit değeri giriniz: ");
int limitdo = Convert.ToInt32(Console.ReadLine()); // Read the limit from user input
int recorder2 = 0; // Initialize recorder2 to 0
do
{ 
    Console.WriteLine("Ben bir Patika'lıyım"); // Print motivational message
    recorder2++; // Increment recorder2 by 1
} while (recorder2 < limitdo); // Loop until recorder2 is less than limitdo

//The Main Difference
//When we tried to use user input as -5 for limit, the do-while loop still executed once, while the while loop did not execute at all.
//That is the main difference between while and do-while loops. The while loop checks the condition before executing the block, while the do-while loop executes the block at least once before checking the condition. 
