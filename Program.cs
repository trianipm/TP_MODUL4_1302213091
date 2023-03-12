﻿using System;
using System.Collections.Generic;

class KodePos
{
    Dictionary<string, string> Kode_pos = new Dictionary<string, string>()
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Seketjati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public string getKodePos(string Kelurahan)
    {
        string kode;
        if (Kode_pos.TryGetValue(Kelurahan, out kode))
        {
            return kode;
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodepos = new KodePos();
        Console.WriteLine("Kode Pos Cijaura: " + kodepos.getKodePos("Cijaura")); // output: 40287 
        Console.WriteLine(kodepos.getKodePos("Dayeuhkolot")); // output: Kode pos tidak ditemukan.
    }
}
