using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1.Model
{
    class Vedomost
    {
        int numstud;
        Student[] workers;
        string spis;
        public Vedomost()
        {
            string surname;
            string name;
            int nomk;
            string gruppa;
            bool sdal;
            int num1;
            int num2;
            int num3;
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "list.txt");
            StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            numstud = int.Parse(sr.ReadLine());
            workers = new Student[numstud];
            Console.WriteLine();
            for (int i = 0; i < workers.Length; i++)
            {
                surname = sr.ReadLine();
                name = sr.ReadLine();
                nomk = int.Parse(sr.ReadLine());
                gruppa = sr.ReadLine();
                sdal = Boolean.Parse(sr.ReadLine());
                num1 = int.Parse(sr.ReadLine());
                num2 = int.Parse(sr.ReadLine());
                num3 = int.Parse(sr.ReadLine());
                workers[i] = new Student(surname,name, nomk,
                    gruppa, sdal,num1,num2,num3);
            }
        }
        public string ShowStatement()
        {
            spis = "";
            for (int i = 0; i < workers.Length; i++)
            {
                spis +=  workers[i].ShowStudent();
                workers[i].ShowStudent();
                Console.WriteLine();
            }
            return spis;
        }
        public string Step()
        {
            spis = $"";
            for (int i = 1; i < workers.Length; i++)
            {
                if (workers[i].Num1() > 3 & workers[i].Num2() > 3 & workers[i].Num3() > 3)
                    if (workers[i].Sdal() == "сдан")
                        spis += workers[i].ShowStudent();
            }
            return spis;
        }
        public string Otlich()
        {
            spis = "";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Num1() == 5 & workers[i].Num2() == 5 & workers[i].Num3() == 5)
                {
                    if (workers[i].Sdal() == "сдан")
                    {
                        spis += workers[i].ShowStudent();
                    }
                }
            }
            return spis;
        }
        public string NeOtl()
        {
            spis = "";
          
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Num1() > 3 & workers[i].Num2() > 3 & workers[i].Num3() > 3)
                    if (workers[i].Sdal() == "сдан")
                        spis = spis;
                    else
                        spis += workers[i].ShowStudent();
            }
            return spis;
        }
       
    }
}

