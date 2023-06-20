
PasswordValidator.Validate();

class PasswordValidator
{
    public string Password { get; set; }

    public PasswordValidator(string password)
    {
        Password = password;
    }

    public static void Validate()
    {
        while (true)
        {
            Console.Write("Write a new password: ");
            string passwordInput = Console.ReadLine();
            PasswordValidator pw = new PasswordValidator(passwordInput);

            bool rule1 = passwordInput.Length >= 6 && passwordInput.Length <= 13;
            bool ruleTwo = true; 
            bool letterT = false;
            bool digitAmpersand = false;

            foreach (char character in passwordInput)
            {
                bool upperChar = char.IsUpper(character);
                bool lowerChar = char.IsLower(character);
                bool digitChar = char.IsDigit(character);
                bool symbolChar = char.IsSymbol(character);


                if (!(upperChar || lowerChar || digitChar || symbolChar))
                {
                    ruleTwo = false;
                }

                if (character == 'T')
                {
                    letterT = true;
                }

                if (character == '&')
                {
                    digitAmpersand = true;
                }
            }

            if (rule1 && ruleTwo && !letterT && !digitAmpersand)
            {
                Console.WriteLine("The password meets all the rules. Password allowed.");
            }
            else
            {
                Console.WriteLine("The password doesn't meets all the rules. Password not allowed.");
            }
        }
    }
}