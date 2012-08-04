using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public abstract class BankTemplate : INote
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private int _note;

        public int BankNote
        {
            get { return _note; }
            set { _note = value; }
        }

        private int _reminder;

        public int Reminder
        {
            get { return _reminder; }
            set { _reminder = value; }
        }

        private int _division;

        public int Division
        {
            get { return _division; }
            set { _division = value; }
        }

        public INote next { get; set; }

        // Strategy here.
        public string doVerify(int remain)
        {
            Value = remain;

            if (Value % BankNote < remain)
            {
                Division = Value / BankNote;
                Reminder = Value % BankNote;
                if (Reminder == 0)
                    return Division + NoteType();
                return Division + NoteType() + next.doVerify(Reminder);
            }
            else
            {
                return next.doVerify(Value);
            }
            
        }

        // Abstract so we can define it in a concrete class. Like the Template Design Pattern.
        // Abstrato, de forma que possamos definir o desejado nas classes concretas, e aqui ser apenas um molde,
        // conforme o padrão Template.
        public abstract string MonetarySymbol();

        public abstract string NoteType();

    }
}
