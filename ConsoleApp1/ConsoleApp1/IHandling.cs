using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IHandling
    {
        void InputanSalah();
        void InputanKosong();
        void IndexNull();
        void BerhasilSimpan();
        void BerhasilUpdate();
        void BerhasilTerhapus();
    }
}
