using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Application
    {
        public abstract string cekData(string data, string dataAsli);

        public abstract void cariData(   string cari, int jenis);

        public abstract void tampilData();

        public abstract int menuData();

        public abstract int Login();
    }
}
