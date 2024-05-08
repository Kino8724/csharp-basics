// For Loops, Foreach Loops, and While Loops

// For Loops
List<int> nums = [1, 2, 3];
for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}

// Foreach Loops
Console.WriteLine("Foreach Loop:");
foreach (int num in nums)
{
    Console.WriteLine(num);
}

// While Loops
Console.WriteLine("While Loop:");
int n = 0;
while ( n < nums.Count)
{
    Console.WriteLine(nums[n]);
    n++;
}