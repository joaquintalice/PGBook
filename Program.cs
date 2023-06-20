using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

Door.Main();

public class Door
{
    public Status CurrentStatus { get; set; }
    public int Passcode { get; set; }

    public Door(Status status, int passcode)
    {
        CurrentStatus = status;
        Passcode = passcode;
    }

    public void OpenDoor()
    {
        if (CurrentStatus == Status.Close)
        {
            CurrentStatus = Status.Open;
        }
    }
    public void CloseDoor()
    {
        if (CurrentStatus == Status.Open)
        {
            CurrentStatus = Status.Close;
        }
    }
    public void LockDoor()
    {
        if (CurrentStatus == Status.Close)
        {
            CurrentStatus = Status.Lock;
        }
    }
    public void UnlockDoor()
    {
        if (CurrentStatus == Status.Lock)
        {
            Console.Write("Write the passcode to unlock: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == Passcode)
            {
                CurrentStatus = Status.Unlock;
            }
            else
            {
                Console.WriteLine("Invalid passcode, the door still locked");
            }
        }
    }
    public void ChangePasscode()
    {
        Console.Write("Insert the current passcode: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input == Passcode)
        {
            Console.Write("Put the new passcode: ");
            int newPasscode = Convert.ToInt32(Console.ReadLine());
            Passcode = newPasscode;
        }
        else
        {
            while (true)
            {
                Console.Write("Passcode incorrect. Do you want try again? (y/n): ");
                string condition = Console.ReadLine();
                if (condition == "y")
                {
                    ChangePasscode();
                    break;
                }
                else if (condition == "n")
                {
                    break;
                }
            }

        }

    }
    public static void Main()
    {
        Console.WriteLine("Insert the passcode(number) and status(open, close, lock, unlock) to your new Door");
        Console.Write("Passcode: ");
        int inputPasscode = Convert.ToInt32(Console.ReadLine());
        Console.Write("Status: ");
        string inputStatus = Console.ReadLine();
        Status initialStatus = inputStatus switch
        {
            "open" => Status.Open,
            "close" => Status.Close,
            "lock" => Status.Lock,
            "unlock" => Status.Unlock,
        };

        Door door = new Door(initialStatus, inputPasscode);

        while (true)
        {
            Console.WriteLine("Which action do you want?");
            Console.WriteLine($"Door current status: {door.CurrentStatus}");
            Console.WriteLine("1: Open the door");
            Console.WriteLine("2: Close the door");
            Console.WriteLine("3: Lock the door");
            Console.WriteLine("4: Unlock the door");
            Console.Write("Your decision: ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    door.OpenDoor();
                    break;
                case 2:
                    door.CloseDoor();
                    break;
                case 3:
                    door.LockDoor();
                    break;
                case 4:
                    door.UnlockDoor();
                    break;
            }

            
        }
    }

}
public enum Status { Open, Close, Lock, Unlock }