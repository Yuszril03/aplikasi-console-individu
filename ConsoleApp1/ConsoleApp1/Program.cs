using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program 
    {
       
        static void Main(string[] args)
        {

            Data konten = new Data();
            List<string> DataSementara = new List<string>();
            //Inisialisasi Data
            konten.dataUtama.Add(new List<String>());
            konten.dataUtama[0].Add("Samsung A20");
            konten.dataUtama[0].Add("Samsung");
            konten.dataUtama[0].Add("4GB");
            konten.dataUtama[0].Add("128GB");
            konten.dataUtama[0].Add("12 MP");
            konten.dataUtama[0].Add("5000");
            konten.dataUtama[0].Add("15000000");


            int jml = 0;
            Login:
            int hasilLogin = konten.Login();
            if (hasilLogin == 1)
            {
                goto MenuUtama;
            }
            else
            {
                if (jml < 3)
                {
                    jml++;
                    goto Login;
                }
                else
                {
                    Console.WriteLine("Maaf Anda sudah login 3x salah");
                    Environment.Exit(0);
                }

            }
            Int16 pilihan;
        MenuUtama:
            jml = 0;
            Console.Clear();
            int menu;
            try
            {
                menu = konten.menuData();
                switch (menu)
                {
                    case 1:
                        try
                        {
                            Console.Clear();
                            konten.tampilData();
                            Console.Write("Tekan 0 untuk kembali : ");
                            pilihan = Int16.Parse(Console.ReadLine());
                            if (pilihan == 0)
                            {
                                goto MenuUtama;
                            }
                            else
                            {
                                goto case 1;
                            }
                        }
                        catch (FormatException e)
                        {

                            konten.InputanSalah();
                            Console.Write("Tekan tombol dalam keybord apa saja ....");
                            string key = Console.ReadKey().Key.ToString();
                            if (key != "")
                            {
                                goto case 1;
                            }
                        }

                        break;
                    case 2:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("|        Menu Pencarian      |");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("| 1 | Berdasarkan Nama       |");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("| 2 | Berdasarkan Merk       |");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("| 3 | Kembali menu utama     |");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("\nSilakan pilih menu : ");
                            int hasil = int.Parse(Console.ReadLine());
                            if (hasil == 1)
                            {
                                Console.WriteLine("");
                                Console.Write("Silakan Nama Handphone : ");
                                string nama = Console.ReadLine();
                                if (nama != "")
                                {
                                    try
                                    {
                                        Console.WriteLine("");
                                        konten.cariData(nama, 1);
                                        //dataKaryawan.Add(hasil);
                                        Console.WriteLine("");
                                        Console.Write("Tekan 0 untuk kembali...");
                                        pilihan = Int16.Parse(Console.ReadLine());
                                        if (pilihan == 0)
                                        {
                                            Console.Clear();
                                            goto MenuUtama;
                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                    }
                                    catch (FormatException e)
                                    {

                                        konten.InputanSalah();
                                        Console.Write("Tekan tombol dalam keybord apa saja ....");
                                        string key = Console.ReadKey().Key.ToString();
                                        if (key != "")
                                        {
                                            goto case 2;
                                        }
                                    }
                                }
                                else
                                {

                                    konten.InputanKosong();
                                    Console.Write("Tekan tombol dalam keybord apa saja ....");
                                    string key = Console.ReadKey().Key.ToString();
                                    if (key != "")
                                    {
                                        goto case 2;
                                    }
                                }

                            }
                            else if (hasil == 2)
                            {
                                Console.WriteLine("");
                                Console.Write("Silakan Merk Handphone : ");
                                string nama = Console.ReadLine();
                                if (nama != "")
                                {
                                    try
                                    {
                                        Console.WriteLine("");
                                        konten.cariData(nama, 2);
                                        //dataKaryawan.Add(hasil);
                                        Console.WriteLine("");
                                        Console.Write("Tekan 0 untuk kembali...");
                                        pilihan = Int16.Parse(Console.ReadLine());
                                        if (pilihan == 0)
                                        {
                                            Console.Clear();
                                            goto MenuUtama;
                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                    }
                                    catch (FormatException e)
                                    {

                                        konten.InputanSalah();
                                        Console.Write("Tekan tombol dalam keybord apa saja ....");
                                        string key = Console.ReadKey().Key.ToString();
                                        if (key != "")
                                        {
                                            goto case 2;
                                        }
                                    }
                                }
                                else
                                {

                                    konten.InputanKosong();
                                    Console.Write("Tekan tombol dalam keybord apa saja ....");
                                    string key = Console.ReadKey().Key.ToString();
                                    if (key != "")
                                    {
                                        goto case 2;
                                    }
                                }


                            }
                            else if (hasil == 3)
                            {
                                Console.Clear();
                                goto MenuUtama;
                            }
                            else
                            {
                                Console.Clear();
                                goto case 2;
                            }
                        }
                        catch (FormatException e)
                        {

                            konten.InputanSalah();
                            Console.Write("Tekan tombol dalam keybord apa saja ....");
                            string key = Console.ReadKey().Key.ToString();
                            if (key != "")
                            {
                                goto case 2;
                            }
                        }


                        break;
                    case 3:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.Write("Mengkonfirmasi apakah ingin menambahkan data ? (y/n) :");
                            string konfirmasi = Console.ReadLine();
                            if (konfirmasi == "y" || konfirmasi == "Y")
                            {
                                DataSementara.Clear();
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("       Tambahkan Data Handphone");
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("1. Masukan Nama Handphone : ");
                                DataSementara.Add(Console.ReadLine());
                                Console.WriteLine("2. Masukan Merk Handphone : ");
                                DataSementara.Add(Console.ReadLine());
                                Console.WriteLine("3. Masukan RAM Handphone : ");
                                DataSementara.Add(Console.ReadLine());
                                Console.WriteLine("4. Masukan ROM Handphone : ");
                                DataSementara.Add(Console.ReadLine());
                                Console.WriteLine("5. Masukan Kamera Handphone : ");
                                DataSementara.Add(Console.ReadLine());
                                Console.WriteLine("6. Masukan Baterai Handphone : ");
                                DataSementara.Add(Console.ReadLine());
                                Console.WriteLine("7. Masukan Harga Handphone : ");
                                DataSementara.Add(Console.ReadLine());
                                int coutt = 0;
                                foreach (string datad in DataSementara)
                                {
                                    if (datad == "")
                                    {
                                        coutt++;
                                    }
                                }
                                if (coutt == 0)
                                {
                                    try
                                    {
                                        konten.dataUtama.Add(new List<String>());
                                        konten.dataUtama[konten.dataUtama.Count-1].Add(DataSementara[0]);
                                        konten.dataUtama[konten.dataUtama.Count-1].Add(DataSementara[1]);
                                        konten.dataUtama[konten.dataUtama.Count-1].Add(DataSementara[2]);
                                        konten.dataUtama[konten.dataUtama.Count-1].Add(DataSementara[3]);
                                        konten.dataUtama[konten.dataUtama.Count-1].Add(DataSementara[4]);
                                        konten.dataUtama[konten.dataUtama.Count-1].Add(DataSementara[5]);
                                        konten.dataUtama[konten.dataUtama.Count-1].Add(DataSementara[6]);
                                        konten.BerhasilSimpan();
                                        Console.Write("Tekan 0 untuk kembali... ");
                                        pilihan = Int16.Parse(Console.ReadLine());

                                        if (pilihan == 0)
                                        {
                                            Console.Clear();
                                            goto MenuUtama;
                                        }
                                        else
                                        {
                                            goto case 3;
                                        }
                                    }
                                    catch (FormatException e)
                                    {

                                        konten.InputanSalah();
                                        Console.Write("Tekan tombol dalam keybord apa saja ....");
                                        string key = Console.ReadKey().Key.ToString();
                                        if (key != "")
                                        {
                                            goto case 3;
                                        }
                                    }
                                }
                                else
                                {
                                    konten.InputanKosong();
                                    Console.Write("Tekan tombol dalam keybord apa saja ....");
                                    string key = Console.ReadKey().Key.ToString();
                                    if (key != "")
                                    {
                                        goto case 3;
                                    }
                                }

                            }
                            else if (konfirmasi == "n" || konfirmasi == "N")
                            {
                                Console.Clear();
                                goto MenuUtama;
                            }
                            else
                            {
                                konten.InputanSalah();
                                Console.Write("Tekan tombol dalam keybord apa saja ....");
                                string key = Console.ReadKey().Key.ToString();
                                if (key != "")
                                {
                                    goto case 3;
                                }
                            }
                        }
                        catch (NullReferenceException e)
                        {
                            konten.InputanSalah();
                            Console.Write("Tekan tombol dalam keybord apa saja ....");
                            string key = Console.ReadKey().Key.ToString();
                            if (key != "")
                            {
                                goto case 3;
                            }

                        }

                        break;
                    case 4:
                        try
                        {
                            Console.Clear();
                            DataSementara.Clear();
                            konten.tampilData();
                            Console.WriteLine("");
                            Console.WriteLine("*Note");
                            Console.WriteLine("- Jika ingin kembali menu utama isi ( 0 )");
                            Console.WriteLine("");
                            Console.Write("Pilih Salah Satu Data Berdasarkan No urut : ");
                            int no = int.Parse(Console.ReadLine());
                            if (no == 0)
                            {
                                Console.Clear();
                                goto MenuUtama;
                            }
                            else
                            {
                                if (konten.dataUtama.Count > (no - 1))
                                {
                                    Console.Clear();
                                    konten.cariData(konten.dataUtama[no - 1][0], 1);
                                    Console.WriteLine("");
                                    Console.WriteLine("*Note");
                                    Console.WriteLine("- Jika Tidak Ingin Mengganti suatu kolom maka beri tanda (-)");
                                    Console.WriteLine("");
                                    Console.Write("1. [" + konten.dataUtama[no - 1][0] + "] =>  ");
                                    string kolom1 = Console.ReadLine();
                                    DataSementara.Add(konten.cekData(kolom1, konten.dataUtama[no - 1][0]));
                                    Console.Write("2. [" + konten.dataUtama[no - 1][1] + "] =>  ");
                                    string kolom2 = Console.ReadLine();
                                    DataSementara.Add(konten.cekData(kolom2, konten.dataUtama[no - 1][1]));
                                    Console.Write("3. [" + konten.dataUtama[no - 1][2] + "] =>  ");
                                    string kolom3 = Console.ReadLine();
                                    DataSementara.Add(konten.cekData(kolom3, konten.dataUtama[no - 1][2]));
                                    Console.Write("4. [" + konten.dataUtama[no - 1][3] + "] =>  ");
                                    string kolom4 = Console.ReadLine();
                                    DataSementara.Add(konten.cekData(kolom4, konten.dataUtama[no - 1][3]));
                                    Console.Write("5. [" + konten.dataUtama[no - 1][4] + "] =>  ");
                                    string kolom5 = Console.ReadLine();
                                    DataSementara.Add(konten.cekData(kolom5, konten.dataUtama[no - 1][4]));
                                    Console.Write("6. [" + konten.dataUtama[no - 1][5] + "] =>  ");
                                    string kolom6 = Console.ReadLine();
                                    DataSementara.Add(konten.cekData(kolom6, konten.dataUtama[no - 1][5]));
                                    Console.Write("7. [" + konten.dataUtama[no - 1][6] + "] =>  ");
                                    string kolom7 = Console.ReadLine();
                                    DataSementara.Add(konten.cekData(kolom7, konten.dataUtama[no - 1][6]));
                                    int coutt = 0;
                                    foreach (string datad in DataSementara)
                                    {
                                        if (datad == "")
                                        {
                                            coutt++;
                                        }
                                    }
                                    if (coutt == 0)
                                    {
                                        try
                                        {
                                            konten.dataUtama[no - 1][0] = DataSementara[0];
                                            konten.dataUtama[no - 1][1] = DataSementara[1];
                                            konten.dataUtama[no - 1][2] = DataSementara[2];
                                            konten.dataUtama[no - 1][3] = DataSementara[3];
                                            konten.dataUtama[no - 1][4] = DataSementara[4];
                                            konten.dataUtama[no - 1][5] = DataSementara[5];
                                            konten.dataUtama[no - 1][6] = DataSementara[6];
                                            konten.BerhasilUpdate();
                                            Console.Write("Tekan 0 untuk kembali... ");
                                            pilihan = Int16.Parse(Console.ReadLine());

                                            if (pilihan == 0)
                                            {
                                                Console.Clear();
                                                goto MenuUtama;
                                            }
                                            else
                                            {
                                                goto case 4;
                                            }
                                        }
                                        catch (FormatException e)
                                        {

                                            konten.InputanSalah();
                                            Console.Write("Tekan tombol dalam keybord apa saja ....");
                                            string key = Console.ReadKey().Key.ToString();
                                            if (key != "")
                                            {
                                                goto case 4;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        konten.InputanKosong();
                                        Console.Write("Tekan tombol dalam keybord apa saja ....");
                                        string key = Console.ReadKey().Key.ToString();
                                        if (key != "")
                                        {
                                            goto case 4;
                                        }
                                    }
                                }
                                else
                                {
                                    konten.IndexNull();
                                    Console.Write("Tekan tombol dalam keybord apa saja ....");
                                    string key = Console.ReadKey().Key.ToString();
                                    if (key != "")
                                    {
                                        goto case 4;
                                    }
                                }
                            }
                        }
                        catch (FormatException e)
                        {

                            konten.InputanSalah();
                            Console.Write("Tekan tombol dalam keybord apa saja ....");
                            string key = Console.ReadKey().Key.ToString();
                            if (key != "")
                            {
                                goto case 4;
                            }
                        }
                        break;
                    case 5:
                        Console.Clear();
                        konten.tampilData();
                        Console.WriteLine("");
                        Console.WriteLine("*Note");
                        Console.WriteLine("- Jika ingin kembali menu utama isi ( 0 )");
                        Console.WriteLine("");
                        Console.Write("Pilih Salah Satu Data Berdasarkan No urut : ");
                        int no2 = int.Parse(Console.ReadLine());
                        try
                        {
                            if (no2 == 0)
                            {
                                Console.Clear();
                                goto MenuUtama;
                            }
                            else
                            {
                                if (konten.dataUtama.Count > (no2 - 1))
                                {
                                    Console.Clear();
                                    konten.cariData(konten.dataUtama[no2 - 1][0], 1);
                                    Console.WriteLine("");
                                    Console.Write("Apakah Anda Yakin Untuk Menghapusnya ? (y/n) : ");
                                    string konfirmasiData = Console.ReadLine();
                                    if (konfirmasiData == "y" || konfirmasiData == "Y")
                                    {
                                        try
                                        {
                                            konten.dataUtama.RemoveAt(no2 - 1);
                                            konten.BerhasilTerhapus();
                                            Console.Write("Tekan 0 untuk kembali... ");
                                            pilihan = Int16.Parse(Console.ReadLine());

                                            if (pilihan == 0)
                                            {
                                                Console.Clear();
                                                goto MenuUtama;
                                            }
                                            else
                                            {
                                                goto case 5;
                                            }
                                        }
                                        catch (FormatException e)
                                        {


                                            konten.InputanSalah();
                                            Console.Write("Tekan tombol dalam keybord apa saja ....");
                                            string key = Console.ReadKey().Key.ToString();
                                            if (key != "")
                                            {
                                                goto case 5;
                                            }
                                        }
                                    }
                                    else if (konfirmasiData == "n" || konfirmasiData == "N")
                                    {
                                        Console.Clear();
                                        goto MenuUtama;
                                    }
                                    else
                                    {
                                        konten.InputanSalah();
                                        Console.Write("Tekan tombol dalam keybord apa saja ....");
                                        string key = Console.ReadKey().Key.ToString();
                                        if (key != "")
                                        {
                                            goto case 5;
                                        }
                                    }
                                }
                                else
                                {
                                    konten.IndexNull();
                                    Console.Write("Tekan tombol dalam keybord apa saja ....");
                                    string key = Console.ReadKey().Key.ToString();
                                    if (key != "")
                                    {
                                        goto case 5;
                                    }
                                }
                            }
                        }
                        catch (FormatException e)
                        {

                            konten.InputanSalah();
                            Console.Write("Tekan tombol dalam keybord apa saja ....");
                            string key = Console.ReadKey().Key.ToString();
                            if (key != "")
                            {
                                goto case 5;
                            }
                        }
                        break;
                    case 6:
                        jml = 0;
                        goto Login;
                        break;
                    default:
                        goto MenuUtama;
                        break;
                }
            }
            catch (FormatException e)
            {
                konten.InputanSalah();
                Console.Write("Tekan tombol dalam keybord apa saja ....");
                string key = Console.ReadKey().Key.ToString();
                if (key != "")
                {
                    goto MenuUtama;
                }

            }

        }
      
    }
}
