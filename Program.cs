namespace TicTacToe;

class TicTacToe
{
    private static char[,] _playField =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };


    private static int _turns;
    
    static void Main()
    {
        int player = 2;
        int input = 0;
        bool inputCorrect;

        do
        {
            if (player == 2)
            {
                player = 1;
                EnterXorO('O',input);
            }
            else if(player == 1)
            {
                player = 2;
                EnterXorO('X',input);
            }
            SetField();
            
            char[] playerChars = { 'X', 'O' };
            foreach (char playerChar in playerChars)
            {
                if ((_playField[0, 0] == playerChar && _playField[0, 1] == playerChar && _playField[0, 2] == playerChar) ||
                    (_playField[1, 0] == playerChar && _playField[1, 1] == playerChar && _playField[1, 2] == playerChar) ||
                    (_playField[2, 0] == playerChar && _playField[2, 1] == playerChar && _playField[2, 2] == playerChar) ||
                    (_playField[0, 0] == playerChar && _playField[1, 0] == playerChar && _playField[2, 0] == playerChar) ||
                    (_playField[0, 1] == playerChar && _playField[1, 1] == playerChar && _playField[2, 1] == playerChar) ||
                    (_playField[0, 2] == playerChar && _playField[1, 2] == playerChar && _playField[2, 2] == playerChar) ||
                    (_playField[0, 0] == playerChar && _playField[1, 1] == playerChar && _playField[2, 2] == playerChar) ||
                    (_playField[0, 2] == playerChar && _playField[1, 1] == playerChar && _playField[2, 0] == playerChar))
                {
                    if (playerChar == 'X')
                    {
                        Console.WriteLine("Player 2 has won!");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 has won!");
                    }
                    Console.WriteLine("Play again? Press any key to continue: ");
                    Console.ReadKey();
                    ResetField();
                    break;
                    
                }
                if (_turns == 10)
                {
                    Console.WriteLine("DRAW!!");
                    Console.WriteLine("Play again? Press any key to continue: ");
                    Console.ReadKey();
                    ResetField();
                    break;
                }
            }
            
            do
            {
                Console.WriteLine($"Player {player}: Choose your field!");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (input == 1 && _playField[0, 0] == '1')
                    inputCorrect = true;
                else if (input == 2 && _playField[0, 1] == '2')
                    inputCorrect = true;
                else if (input == 3 && _playField[0, 2] == '3')
                    inputCorrect = true;
                else if (input == 4 && _playField[1, 0] == '4')
                    inputCorrect = true;
                else if (input == 5 && _playField[1, 1] == '5')
                    inputCorrect = true;
                else if (input == 6 && _playField[1, 2] == '6')
                    inputCorrect = true;
                else if (input == 7 && _playField[2, 0] == '7')
                    inputCorrect = true;
                else if (input == 8 && _playField[2, 1] == '8')
                    inputCorrect = true;
                else if (input == 9 && _playField[2, 2] == '9')
                    inputCorrect = true;
                else
                {
                    Console.WriteLine("Please use another field.");
                    inputCorrect = false;
                }
            } while (!inputCorrect);
        } while (true);
    }

    public static void ResetField()
    {
        char[,] initPlayField =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        _turns = 0;
        _playField = initPlayField;
        SetField();
    }

    public static void SetField()
    {
        Console.Clear();
        Console.WriteLine("       |       |       ");
        Console.WriteLine("   {0}   |   {1}   |    {2}  ", _playField[0,0],_playField[0,1],_playField[0,2]);
        Console.WriteLine("_______|_______|_______");
        Console.WriteLine("       |       |       ");
        Console.WriteLine("   {0}   |   {1}   |    {2}  ", _playField[1,0], _playField[1,1], _playField[1,2]);
        Console.WriteLine("_______|_______|_______");
        Console.WriteLine("       |       |       ");
        Console.WriteLine("   {0}   |   {1}   |    {2}  ", _playField[2,0], _playField[2,1], _playField[2,2]);
        Console.WriteLine("       |       |       ");
        _turns++;
    }

    public static void EnterXorO(char playerSign, int input)
    {
        switch (input)
        {
            case 1: _playField[0, 0] = playerSign; //replaces number from 1 into an X
                break;
            case 2: _playField[0, 1] = playerSign;
                break;
            case 3: _playField[0, 2] = playerSign;
                break;
            case 4: _playField[1, 0] = playerSign;
                break;
            case 5: _playField[1, 1] = playerSign;
                break;
            case 6: _playField[1, 2] = playerSign;
                break;
            case 7: _playField[2, 0] = playerSign;
                break;
            case 8: _playField[2, 1] = playerSign;
                break;
            case 9: _playField[2, 2] = playerSign;
                break;
        }
    }
}