namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            string answer = "";

            answer += determineNenner(input, 3, "Foo");
            answer += determineNenner(input, 5, "Bar");
            answer += determineNenner(input, 7, "Qix");


            string inputInString = input.ToString();
            for(int i = 0; i < inputInString.Length; i++)
            {
                addWordIfNumberIsFound(inputInString[i], '3', "Foo");
                addWordIfNumberIsFound(inputInString[i], '5', "Bar");
                addWordIfNumberIsFound(inputInString[i], '7', "Qix");
            }

            return answer == "" ? input.ToString() : answer;
        }

        private bool isDividableThrough(double input, double dividor)
        {
            return input % dividor == 0;
        }

        private string determineNenner(double input, double dividor, string word)
        {
            if (isDividableThrough(input, dividor))
            {
                return word;
            }
            return "";
        }

        private string addWordIfNumberIsFound(char number, char targetNumber ,string word)
        {
            if (number == targetNumber)
            {
                return word;
            }
            return "";
        }

    }
}