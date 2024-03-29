﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioLavoroListe
{
    public class Lavoratore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public char Genere { get; set; }
        public float Stipendio { get; set; }
        public int AnniAnzianità { get; set; }

        //Costruttore della classe LAVORATORE;
        public Lavoratore(string nome, string cognome, char genere, float stipendio, int anniAnzianità)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Genere = genere;
            this.Stipendio = stipendio;
            this.AnniAnzianità = anniAnzianità;
        }
     
        public Lavoratore()
        {

        }

        public override string ToString()
        {
            return Nome + ", " + Cognome + ", " + Genere + ", " + Stipendio + ", " + AnniAnzianità + "\n";
        }
        public void listaLavoratori()  //ARRAY
        {

            try
            {
                Lavoratore[] lavoratori = new Lavoratore[4];

                lavoratori[0] = new Lavoratore("Federico", "Sacco", 'M', 15600, 2);
                lavoratori[1] = new Lavoratore("Matteo", "Verdi", 'M', 13400, 1);
                lavoratori[2] = new Lavoratore("Cristian", "Lo Capo", 'M', 25320, 30);
                lavoratori[3] = new Lavoratore("Jacopo", "Lento", 'M', 40150, 49);

                for (int i = 0; i < lavoratori.Length; i++)
                {
                    Console.WriteLine(lavoratori[i].Nome
                        + lavoratori[i].Cognome
                        + lavoratori[i].Genere
                        + lavoratori[i].Stipendio
                        + lavoratori[i].AnniAnzianità
                     );
                }
            }
            catch (ArrayTypeMismatchException aex)
            {
                Console.WriteLine("Errore nella visualizzazione della lista lista lavoratori");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Grazie di tutto, alla prossima");
            }
        }

        private static void inserimentoStipendio(Lavoratore[] l, float[] s)
        {
            for (int i = 0; i < l.Length; i++)
            {
                s[i] = l[i].Stipendio;
            }
        }

        private static object OrderBy(float stipendio)
        {
            throw new NotImplementedException();
        }

        public float stipendioMensile()
        {
            float stipendioMensileTot = 0;

            stipendioMensileTot = (Stipendio / 12);
            return stipendioMensileTot;

        }

        /*
        public override string ToString()
        {
            return ;
        }
        */
    }
}
