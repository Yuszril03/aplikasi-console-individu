using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Data : Application, IHandling
    {
        public List<List<string>> dataUtama = new List<List<string>>();

        public void BerhasilSimpan()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          Berhasil Tersimpan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }

        public void BerhasilTerhapus()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          Berhasil Terhapus");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }

        public void BerhasilUpdate()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          Berhasil Tersimpan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }

        public override void cariData(string cari, int jenis)
        {
            if (jenis == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("                                   Data Produk Handphone");
                int no = 1;
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("No | Nama            | Merk        | RAM   | ROM     | Kamera    |  Baterai  | Harga ");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                if (dataUtama.Count == 0)
                {
                    Console.WriteLine("                                 Maaf Data Tidak Tersedia  ");
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                else
                {
                    int z = 0;
                    int coutCari = 0;
                    for (int i = 0; i < dataUtama.Count; i++)
                    {
                        coutCari = 0;
                        string temp = dataUtama[i][0];
                        for (int j = 0; j < cari.Length; j++)
                        {
                            if (cari[j] == temp[j])
                            {
                                coutCari++;
                            }
                        }

                        if (coutCari == cari.Length)
                        {
                            Console.WriteLine((1 + z) + "  | " + dataUtama[i][0] + "     | " + dataUtama[i][1] + "     | " + dataUtama[i][2] + "   | " + dataUtama[i][3] + "   | " + dataUtama[i][4] + "     | " + dataUtama[i][5] + "      | " + dataUtama[i][6]);
                            z++;
                        }
                    }
                    if (z == 0)
                    {
                        Console.WriteLine("                                 Maaf Data Tidak Tersedia  ");
                    }

                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("                                   Data Produk Handphone");
                int no = 1;
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("No | Nama            | Merk        | RAM   | ROM     | Kamera    |  Baterai  | Harga ");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                if (dataUtama.Count == 0)
                {
                    Console.WriteLine("                                 Maaf Data Tidak Tersedia  ");
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                else
                {
                    int z = 0;
                    int coutCari = 0;
                    for (int i = 0; i < dataUtama.Count; i++)
                    {
                        coutCari = 0;
                        string temp = dataUtama[i][1];
                        for (int j = 0; j < cari.Length; j++)
                        {
                            if (cari[j] == temp[j])
                            {
                                coutCari++;
                            }
                        }
                        if (coutCari == cari.Length)
                        {
                            Console.WriteLine((1 + z) + "  | " + dataUtama[i][0] + "     | " + dataUtama[i][1] + "     | " + dataUtama[i][2] + "   | " + dataUtama[i][3] + "   | " + dataUtama[i][4] + "     | " + dataUtama[i][5] + "      | " + dataUtama[i][6]);
                            z++;
                        }
                    }
                    if (z == 0)
                    {
                        Console.WriteLine("                                 Maaf Data Tidak Tersedia  ");
                    }

                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
            }
        }

        public override string cekData(string data, string dataAsli)
        {
            if (data == "-")
            {
                return dataAsli;
            }
            else
            {
                return data;
            }
        }

        public void IndexNull()
        {
            Console.WriteLine("\n  ---------------------------------------------");
            Console.WriteLine("  |             Index Tidak ada !!            |");
            Console.WriteLine("  ---------------------------------------------");
            Console.WriteLine("");
        }

        public void InputanKosong()
        {
            Console.WriteLine("\n  ---------------------------------------------");
            Console.WriteLine("  |    Inputan yang anda masukan kosong !!    |");
            Console.WriteLine("  ---------------------------------------------");
            Console.WriteLine("");
        }

        public void InputanSalah()
        {
            Console.WriteLine("\n  ---------------------------------------------");
            Console.WriteLine("  | Inputan yang anda masukan tidak sesuai !! |");
            Console.WriteLine("  ---------------------------------------------");
            Console.WriteLine("");
        }

        public override int Login()
        {
            int hasil = 0;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("          Aplikasi Managemen Produk Handphone ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Masukan Username : ");
            string username = Console.ReadLine();
            Console.Write("Masukan Password : ");
            string pass = Console.ReadLine();
            if (username == "Admin" && pass == "Admin")
            {
                hasil = 1;
            }
            else if (username == "" || pass == "")
            {
                Data isi = new Data();
                isi.InputanSalah();
                Console.Write("Tekan tombol dalam keybord apa saja ....");
                string key = Console.ReadKey().Key.ToString();
                if (key != "")
                {
                    hasil = 0;
                }
            }
            else
            {
                hasil = 0;

            }
            return hasil; 
        }
    
    

        public override int menuData()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("|    Aplikasi Managemen Data Handphone    |");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| 1. | Tampil Data Handphone              |");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| 2. | Mencari Data Handphone             |");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| 3. | Tambah Data Handphone              |");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| 4. | Edit Data Handphone                |");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| 5. | Hapus Data Handphone               |");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| 6. | Keluar                             |");
            Console.WriteLine("-------------------------------------------");
            Console.Write("\nSilakan Pilih Menu : ");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }

        public override void tampilData()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("                                   Data Produk Handphone");
            int no = 1;
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("No | Nama            | Merk        | RAM   | ROM     | Kamera    |  Baterai  | Harga ");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            if (dataUtama.Count == 0)
            {
                Console.WriteLine("                                 Maaf Data Tidak Tersedia  ");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("");
            }
            else
            {

                for (int i = 0; i < dataUtama.Count; i++)
                {
                    Console.WriteLine((1 + i) + "  | " + dataUtama[i][0] + "     | " + dataUtama[i][1] + "     | " + dataUtama[i][2] + "   | " + dataUtama[i][3] + "   | " + dataUtama[i][4] + "     | " + dataUtama[i][5] + "      | " + dataUtama[i][6]);
                }

                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}
