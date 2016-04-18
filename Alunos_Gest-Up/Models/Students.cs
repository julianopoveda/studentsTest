using System;
using System.Collections.Generic;

namespace Alunos_Gest_Up.Models
{
    public class Students
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get { return new DateTime(DateTime.Today.Subtract(DataNascimento).Ticks).Year; } }

        public Students(string nome, DateTime dataNascimento, int seed)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            //Gerador de matricula baseado no horário do cadastro para facilitar
            Matricula = (int)Math.Sqrt(DateTime.Now.Ticks) + seed;
        }
    }

    public class StudentsMock
    {
        private List<Students> Students { get; set; }

        public StudentsMock()
        {
            Students = new List<Students>();

            int seed = 0;

            Students.Add(new Students("Abel Macedo", new DateTime(1990, 12, 25),seed++));
            Students.Add(new Students("Julio César", new DateTime(1985, 02, 01), seed++));
            Students.Add(new Students("Flavio Augusto", new DateTime(1980, 07, 31), seed++));
            Students.Add(new Students("Marie Currie", new DateTime(1992, 05, 01), seed++));
            Students.Add(new Students("Isabel Dutra", new DateTime(1990, 04, 21), seed++));

            Students.Add(new Students("Fernando Melo", new DateTime(1986, 09, 20), seed++));
            Students.Add(new Students("Eduardo León", new DateTime(1989, 11, 02), seed++));
            Students.Add(new Students("Hugo de León", new DateTime(1991, 09, 07), seed++));
            Students.Add(new Students("Átila de Oliveira", new DateTime(1978, 03, 15), seed++));
            Students.Add(new Students("Quijote Mancha", new DateTime(1981, 01, 01), seed++));

            Students.Add(new Students("Vitória Castro", new DateTime(1987, 12, 25), seed++));
            Students.Add(new Students("Césa Augusto", new DateTime(1993, 08, 19), seed++));
            Students.Add(new Students("Jean Jackes Russeau", new DateTime(1989, 10, 30), seed++));
            Students.Add(new Students("Herber Vianna", new DateTime(1988, 10, 03), seed++));
            Students.Add(new Students("Janis Joplin", new DateTime(1979, 06, 05), seed++));

            Students.Add(new Students("Salvador Dali", new DateTime(1984, 02, 28), seed++));
            Students.Add(new Students("Ludwig Van Bethoven", new DateTime(1984, 10, 14), seed++));
            Students.Add(new Students("Marilia Pera", new DateTime(1993, 08, 01), seed++));
            Students.Add(new Students("Diego Armando Maradona", new DateTime(1991, 01, 12), seed++));
            Students.Add(new Students("Ada Locelace", new DateTime(1979, 12, 11), seed++));
        }

        public List<Students> findAll()
        {
            return Students;
        }
    }
}