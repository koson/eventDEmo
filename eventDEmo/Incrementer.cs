using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventDEmo
{

    // publisher class
    // 1. declare delegate เนื่องจากมันจะส่ง event ไปยังที่ที่ไม่รู้จุดหมายปลายทาง
    // ประกาศรูปแบบของ event handler function
    delegate void Handler();

    class Incrementer
    {
        // 2. declare event handler
        // กำหนดชื่อให้กับ event handler delegate (ที่จะทำงานเมื่อเกิด event)
        public event Handler CountedADozen;

        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%12 == 0 &&  CountedADozen != null)
                {
                    // 3. สร้าง event 
                    CountedADozen();
                }
            }


        }
    }
}
