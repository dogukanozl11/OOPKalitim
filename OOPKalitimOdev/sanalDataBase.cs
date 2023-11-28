﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdev
{
    public static class sanalDataBase
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrunEkle(baseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }
        public static bool dbBarkodKontrol(string barkod)
        {
            bool kontrol =false;
            if (db != null && db.Count>0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseClass bc = (baseClass)db[i];
                    if (bc.barkod == barkod)
                    {
                        kontrol = true;
                    }
                }

            }
            return kontrol;
        }
    }
}
