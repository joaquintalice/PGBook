BoxState state = BoxState.Locked;

while (true)
{
    Console.Write($"The chest is {state}. What do you want to do? ");
    string usrAnswer = Console.ReadLine();

    switch (usrAnswer)
    {
        case "close":
            state = BoxState.Unlocked;
            break;
        case "lock":
            state = BoxState.Locked;
            break;

        case "unlock":
            state = BoxState.Unlocked;
            break;

        case "open":
            state = BoxState.Open;
            break;
    }
}







enum BoxState
{
    Locked, 
    Unlocked,
    Open,
    
}
