// 
Console.WriteLine("Задайте размер массива.");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];
int positiv = 0;
int negaitiv = 0;

var newRnd = Random();
for(int i = 0;i < size;i++)
{
    nums[i] = Random.Next(-9,10);
    Console.WriteLine((nums[i]) + " ");
}
for(int i = 0;i < nums.Length;i++)
{
    if(nums[i]> 0) positiv += nums[i];
    else negaitiv += nums[i] ;
}
