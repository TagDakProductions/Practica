using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1.Model
{
    class Student
    {
        string surname;
        string name;
        int nomk;
        string gruppa;
        bool sdal;
        int num1;
        int num2;
        int num3;
        string sdalo;
       
        public Student(string surname, string name, int nomk, string gruppa, bool sdal,int num1,int num2,int num3)
        {
           
            this.surname = surname;
            this.name = name;
            this.nomk =nomk;
            this.gruppa = gruppa;
            this.sdal = sdal;
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public string Name()
        {
            return name;
        }
        public string Surname()
        {
            return surname;
        }
        public int Nomk()
        {
            return nomk;
        }
        public string Gruppa()
        {
           
            return gruppa;
        }
        public string Sdal()
        {
            if (sdal == true)
                sdalo = "сдан";
            else
                sdalo = "не сдан";
            return sdalo;
        }
        public int Num1()
        {
            return num1;
        }
        public int Num2()
        {
            return num2;
        }
        public int Num3()
        {
            return num3;
        }
        public string ShowStudent ()
        {
            string s;
            s = $"Фамилия {surname}\n";
            s += $"Имя {name}\n";
            s += $"Курс {nomk}\n";
            s += $"Группа {nomk} \n";
            s += $"зачет {sdalo}\n";
            s += $" {num1}\n";
            s += $" {num2}\n";
            s += $" {num3}\n";

            return s;
        }

    }
}

