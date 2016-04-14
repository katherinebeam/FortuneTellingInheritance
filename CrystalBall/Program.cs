using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBall
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneTeller fortuneTeller = new FortuneTeller();
            Crystalball crystallBall = new Crystalball();
            fortuneTeller.Greet();

            fortuneTeller.StartService((Service)crystallBall);
            crystallBall.Work();
            crystallBall.Show();
            fortuneTeller.Farewell();
            TarotCard tarot = new TarotCard();
            tarot.ReadFortune();
        }
    }
}
