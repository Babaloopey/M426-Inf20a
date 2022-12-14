using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
        private string Fifteen = "Fifteen";
        private string Thirty = "Thirty";
        private string Forty = "Forty";
        private string Love = "Love";
        private string Connectionsign = "-";

        private int player1point;
        private string player1res = "";
        private string player1Name;

        private int player2point;
        private string player2res = "";
        private string player2Name;

        public TennisGameManager(string player1Name,
            string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string Score_Getter()
        {
            string writtenScore = "";

            if (player1point == player2point)
            {
                writtenScore = CalculatePlayersWithSameScore();
            }
            else
            {
                writtenScore = GetGenericScore();
            }

            if (IsPlayer1Win())
            {
                writtenScore = "Win for player1";
            }
            writtenScore = ReturnWinForPlayerOneIfWon(writtenScore, player1point, player2point);
            return writtenScore;
        }

        private string CalculatePlayersWithSameScore()
        {
            if (IsPlayersBelowThree())
            {
                string result = TextScoreOfPoints(player1point);
                return (result += "-All");
            }
            else if (IsPlayersScoreThreeOrMore())
            {
                return "Deuce";
            }
            return "";
        }

        private bool IsPlayersBelowThree()
        {
            return player1point < 3;
        }
        private bool IsPlayersScoreThreeOrMore()
        {
            return player1point > 2;
        }


        private string GetAndConnectTextScoreOfPlayers()
        {
            player1res = TextScoreOfPoints(player1point);
            player2res = TextScoreOfPoints(player2point);

            return (player1res + Connectionsign + player2res);
        }

        private string TextScoreOfPoints(int playerPoints)
        {
            string playerRes = "";
            if (playerPoints == 0)
                playerRes = Love;
            if (playerPoints == 1)
                playerRes = Fifteen;
            if (playerPoints == 2)
                playerRes = Thirty;
            if (playerPoints == 3)
                playerRes = Forty;

            return playerRes;
        }


        private string GetGenericScore()
        {
            string writtenScore = "";
            writtenScore = GetAndConnectTextScoreOfPlayers();

            if (player1point > player2point && player2point >= 3)
            {
                writtenScore = "Advantage player1";
            }

            if (player2point > player1point && player1point >= 3)
            {
                writtenScore = "Advantage player2";
            }
            return writtenScore;
        }

        private bool IsPlayer1Win()
        {
            return player1point >= 4 && player2point >= 0 && (player1point - player2point) >= 2;
        }


        public string ReturnWinForPlayerOneIfWon(string s, int q, int y)
        {
            if (y >= 4 && q >= 0 && (y - q) >= 2)
            {
                return "Win for player2";
            }
            return s;
        }

        public void SetPlayer1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                FirstPlayerScore();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                SecondPlayerScore();
            }
        }

        private void FirstPlayerScore()
        {
            player1point++;
        }
        private void SecondPlayerScore()
        {
            player2point++;
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1")
            {
                FirstPlayerScore();
            }
            else
                SecondPlayerScore();
        }

    }
}

