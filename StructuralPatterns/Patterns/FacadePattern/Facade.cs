using StructualPatterns.FacadePattern.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.FacadePattern
{
    internal class Facade
    {
        private MakeTheTableReady _makeTheTableReady;
        private MakeTheFoodReady _makeTheFoodReady;


        public void MakeTheTable()
        {
            _makeTheTableReady.PlacePlates();
            _makeTheTableReady.PlaceForks();
            _makeTheTableReady.PlaceKnives();

            _makeTheFoodReady.MakeTheDuck();
            _makeTheFoodReady.MakeTheGreens();
            _makeTheFoodReady.MakeThePotatos();
        }
    }
}
