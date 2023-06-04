int CountDown(int num)
{
    if (num == 0) return Console.WriteLine(1);
    Console.WriteLine(num); 
    return CountDown(num - 1); ;
}

CountDown(10);