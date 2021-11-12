using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    class Marchaller
    {
        public static Dictionary<int, Marchaller> Marchallers = new();

        private int _idMarch;
        private string _brand;
        private int _burnTime;
        private string _adress;
        private DateTime _timeofReg;       //När MArchallen Registrerades
        private int _userRegM;            //Vilken användare som Registrerat Marchallen
        private DateTime _burnOutTime;

        public int IdMArch { get { return _idMarch; } }
        public string Brand { get { return _brand; } set { _brand = value; } }
        public int BurnTime { get { return _burnTime; } set { _burnTime = value; } }
        public string Adress { get { return _adress; } set { _adress = value; } }
        public DateTime TimeofReg { get { return _timeofReg;} }
        public int UserRegM { get { return _userRegM; } }
        public DateTime BurnOutTime { get { return _burnOutTime; } }

        

        public Marchaller(string brand, int burnTime, string adress)
        {
            this.Brand = brand;
            this.BurnTime = burnTime;
            this.Adress = adress;
            _idMarch = Marchallers.Count + 1;
            Marchallers.Add(_idMarch, this);

        }

    }
}
