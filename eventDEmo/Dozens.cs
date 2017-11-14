using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventDEmo
{

    // subscriber class
    class Dozens
    {
        public int DozensCount { get; private set; }

        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            // subscriber event
            // โดยเชื่อม event ที่จะถูกยิงมาจาก  publisher (ด้านซ้าย) เข้ากับ method (ด้านขวา) ของเครื่องหมาย = 
            incrementer.CountedADozen += IncrementDozensCount;
        }

        // method รองรับ event อยู่ใน subscriber class
        void IncrementDozensCount()
        {
            DozensCount++;
        }
    }
}
