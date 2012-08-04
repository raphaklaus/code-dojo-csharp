using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class BankProcess 
    {
        public HundredNote hundredn = new HundredNote();
        public FiftyNote fiftyn = new FiftyNote();
        public TwentyNote twentyn = new TwentyNote();
        public TenNote ten = new TenNote();
        public FiveNote fiven = new FiveNote();
        public TwoNote twon = new TwoNote();
        public OneNote onen = new OneNote();
        

        public string doProcess(int remain)
        {
            // Initializing the class properties. - Inicializando as propriedades básicas da classe.
            Setup();
            // Starts the verification over hundred, and going down...
            // Começa do 100, e vai verificando para os valores abaixo até chegar em resto = 0.
            return hundredn.doVerify(remain);    
        }

        public void Setup()
        {
            // The order. - As ordens.
            hundredn.next = fiftyn;
            fiftyn.next = twentyn;
            twentyn.next = ten;
            ten.next = fiven;
            fiven.next = twon;
            twon.next = onen;

            // The obj values. - O valor de cada objeto.
            hundredn.BankNote = 100;
            fiftyn.BankNote = 50;
            twentyn.BankNote = 20;
            ten.BankNote = 10;
            fiven.BankNote = 5;
            twon.BankNote = 2;
            onen.BankNote = 1;
        }

    }

    public class HundredNote : BankTemplate
    {
        
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 100 ";
        }
    }

    public class FiftyNote : BankTemplate
    {
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 50 ";
        }
    }

    public class TwentyNote : BankTemplate
    {
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 20 ";
        }
    }

    public class TenNote : BankTemplate
    {
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 10 ";
        }
    }


    public class FiveNote : BankTemplate
    {
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 5 ";
        }
    }


    public class TwoNote : BankTemplate
    {
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 2 ";
        }
    }

    public class OneNote : BankTemplate
    {
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 1 ";
        }
    }


    public class Last : BankTemplate
    {
        public override string MonetarySymbol()
        {
            return "R$ ";
        }

        public override string NoteType()
        {
            return " Em nota de 1 ";
        }
    }

}
