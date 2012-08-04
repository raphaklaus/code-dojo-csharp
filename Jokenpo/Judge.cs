using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDojoJokenpo
{
    public class Judge
    {
        
	public IGameObj rock;
	public IGameObj paper;
	public IGameObj scissors;
	public IGameObj draw;
        
        public string result;

        public string doJudge(string param1, string param2)
        {

            rock = new RockWin();
            paper = new PaperWin();
            scissors = new ScissorsWin();
            draw = new DrawGame();
            

            rock.next = paper;
            paper.next = scissors;
            scissors.next = draw;


            result = rock.doWin(param1, param2);

            return result;

            // Let's try to leave this kind of practice away...
            // Vamos tentar deixar esse tipo de prática de lado...


            //if (param1 == param2)
            //{
            //    return "Draw";
            //}

            //if (param1 == "Rock" && param2 == "Paper")
            //{
            //    return "Rock wins.";
            //}

            //if (param1 == "Rock" && param2 == "Scissors")
            //{
            //    return "Scissors wins.";
            //}

            
        
        }

    }

    // All classes includes in itself the concept of strategy and chain of responsability design pattern.
    // Todas classes incluem em si mesmas os conceitos de padrão de projeto estratégia e cadeia de responsabilidade.

    public class RockWin : IGameObj
    {
        public IGameObj next { get; set; }
        public string doWin(string param1, string param2)
        {
            if ((param1 == "Rock" || param2 == "Rock") && (param1 == "Scissors" || param2 == "Scissors"))
                return "Rock Wins.";
            return next.doWin(param1, param2);
        }
    }

    
    public class PaperWin : IGameObj
    {
        public IGameObj next { get; set; }
        public string doWin(string param1, string param2)
        {
            if ((param1 == "Paper" || param2 == "Paper") && (param1 == "Rock" || param2 == "Rock"))
                return "Paper Wins.";
            return next.doWin(param1, param2);
        }
    }

    public class ScissorsWin : IGameObj
    {
        public IGameObj next { get; set; }
        public string doWin(string param1, string param2)
        {
            if ((param1 == "Scissors" || param2 == "Scissors") && (param1 == "Paper" || param2 == "Paper"))
                return "Scissors Wins.";
            return next.doWin(param1, param2);
        }
    }

    public class DrawGame : IGameObj
    {
        public IGameObj next { get; set; }
        public string doWin(string param1, string param2)
        {
            if (param1 == param2)
                return "Draw Game!";
            return "";
        }

    }


}