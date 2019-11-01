﻿using AppG2.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Controller
{
    class ContacstService
    {
        public static List<ClientContact> GetClientContact(string pathDataFile)
        {
            List<ClientContact> listClients = new List<ClientContact>();
            if (File.Exists(pathDataFile))
            {
                string[] listLines = File.ReadAllLines(pathDataFile);
                foreach (string line in listLines)
                {
                    string[] rs = line.Split(new char[] { '#' });
                    ClientContact client = new ClientContact
                    {
                        FindN = rs[1],
                        Name = rs[2],
                        Phone = rs[3],
                        Email = rs[4]
                    };
                    listClients.Add(client);
                }
                return listClients;
            }
            else
            {
                throw new Exception(pathDataFile);
            }

        }
    }
}