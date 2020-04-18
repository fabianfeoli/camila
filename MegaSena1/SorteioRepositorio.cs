using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MegaSena1
{
    public class SorteioRepositorio

    {
        public Boolean CarregarDoArquivo(string nomearquivo)
        {
            StreamReader rdr = new StreamReader(nomearquivo);
            int contador = 0;



            while (!rdr.EndOfStream)
            {
                string lida = rdr.ReadLine();
                if (lida.Contains("<tr>"))
                {

                    contador++;

                    try
                    {
                        if (contador > 1)
                        {
                            Sorteio sorteio = new Sorteio();
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            int posicao1 = lida.IndexOf(">") + 1;
                            int posicao2 = lida.IndexOf("<", posicao1);
                            string aux = lida.Substring(posicao1, posicao2 - posicao1);
                            int temp = 0;
                            if (int.TryParse(aux, out temp))
                            {
                                sorteio.NrSorteio = temp;
                                //  Console.WriteLine(sorteio.NrSorteio);
                            }
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            posicao1 = lida.IndexOf(">") + 1;
                            posicao2 = lida.IndexOf("<", posicao1);

                            if (posicao2 > posicao1)
                            {
                                aux = lida.Substring(posicao1, posicao2 - posicao1);
                                //  Console.WriteLine(aux);
                            }
                            DateTime data = DateTime.Today;


                            if (DateTime.TryParse(aux, out data))
                            {
                                sorteio.DtSorteio = data;
                                //   Console.WriteLine(sorteio.DtSorteio);
                            }
                            // Dezena 1
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            posicao1 = lida.IndexOf(">") + 1;
                            posicao2 = lida.IndexOf("<", posicao1);
                            aux = lida.Substring(posicao1, posicao2 - posicao1);
                            temp = 0;
                            if (int.TryParse(aux, out temp))
                            {
                                sorteio.Dez1 = temp;
                                //  Console.WriteLine(sorteio.Dez1);
                            }
                            // Dezena 2
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            posicao1 = lida.IndexOf(">") + 1;
                            posicao2 = lida.IndexOf("<", posicao1);
                            aux = lida.Substring(posicao1, posicao2 - posicao1);
                            temp = 0;
                            if (int.TryParse(aux, out temp))
                            {
                                sorteio.Dez2 = temp;
                                //    Console.WriteLine(sorteio.Dez2);
                            }
                            // Dezena 3
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            posicao1 = lida.IndexOf(">") + 1;
                            posicao2 = lida.IndexOf("<", posicao1);
                            aux = lida.Substring(posicao1, posicao2 - posicao1);
                            temp = 0;
                            if (int.TryParse(aux, out temp))
                            {
                                sorteio.Dez3 = temp;
                                //  Console.WriteLine(sorteio.Dez3);
                            }
                            // Dezena 4
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            posicao1 = lida.IndexOf(">") + 1;
                            posicao2 = lida.IndexOf("<", posicao1);
                            aux = lida.Substring(posicao1, posicao2 - posicao1);
                            temp = 0;
                            if (int.TryParse(aux, out temp))
                            {
                                sorteio.Dez4 = temp;
                                //  Console.WriteLine(sorteio.Dez4);
                            }
                            // Dezena 5
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            posicao1 = lida.IndexOf(">") + 1;
                            posicao2 = lida.IndexOf("<", posicao1);
                            aux = lida.Substring(posicao1, posicao2 - posicao1);
                            temp = 0;
                            if (int.TryParse(aux, out temp))
                            {
                                sorteio.Dez5 = temp;
                                // Console.WriteLine(sorteio.Dez5);
                            }
                            // Dezena 6
                            rdr.ReadLine();
                            lida = rdr.ReadLine();
                            posicao1 = lida.IndexOf(">") + 1;
                            posicao2 = lida.IndexOf("<", posicao1);
                            aux = lida.Substring(posicao1, posicao2 - posicao1);
                            temp = 0;
                            if (int.TryParse(aux, out temp))
                            {
                                sorteio.Dez6 = temp;
                                //  Console.WriteLine(sorteio.Dez6);
                            }
                            Console.WriteLine("sorteio {0} em {1}, numeros {2}, {3}, {4}, {5}, {6}, {7}", sorteio.NrSorteio,
                                sorteio.DtSorteio, sorteio.Dez1, sorteio.Dez2, sorteio.Dez3, sorteio.Dez4, sorteio.Dez5,
                                sorteio.Dez6);

                        }
                    }
                    catch
                    {
                        continue;

                    }

                }

            }

            return false;
        }

    }
}
