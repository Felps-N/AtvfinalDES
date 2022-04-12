using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Hospitalar
{
    class Menu
    {
        public string escolha;
        Paciente[] P = new Paciente[11];
        Paciente paux;

    public string escolhamenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opcções abaixo para o sistema");
            Console.WriteLine("C - Cadastrar Paciente");
            Console.WriteLine("L - Listar Pacientes");
            Console.WriteLine("A - Alterar Dados dos Paciente");
            Console.WriteLine("T - Atender Paciente");
            Console.WriteLine("Q - Encerrar Programa");
            escolha = Console.ReadLine();
            Console.Clear();
            return escolha.ToUpper();
        }
       
        public void funcaomenu()
        {
            
            if (escolha == "C" || escolha == "c")
            {
                for (int i = 0; i<10; i++)
                {
                    if (P[i] == null)
                    {
                        P[i] = new Paciente();
                        P[i].cadastrar();
                        P[i].preferencia();
                        i = 10;
                    }
                    else if(P[9] != null)
                    {
                        Console.WriteLine("Lista Lotada");
                        Console.ReadKey();
                    }
                }

                /*if (P[0] == null)
                {
                    P[0] = new Paciente();
                    P[0].cadastrar();
                    P[0].preferencia();
                }
                else if (P[1] == null)
                {
                    P[1] = new Paciente();
                    P[1].cadastrar();
                    P[1].preferencia();
                }
                else if (P[2] == null)
                {
                    P[2] = new Paciente();
                    P[2].cadastrar();
                    P[2].preferencia();
                }
                else if (P[3] == null)
                {
                    P[3] = new Paciente();
                    P[3].cadastrar();
                    P[3].preferencia();
                }
                else if (P[4] == null)
                {
                    P[4] = new Paciente();
                    P[4].cadastrar();
                    P[4].preferencia();
                }
                else if (P[5] == null)
                {
                    P[5] = new Paciente();
                    P[5].cadastrar();
                    P[5].preferencia();
                }
                else if (P[6] == null)
                {
                    P[6] = new Paciente();
                    P[6].cadastrar();
                    P[6].preferencia();
                }
                else if (P[7] == null)
                {
                    P[7] = new Paciente();
                    P[7].cadastrar();
                    P[7].preferencia();
                }
                else if (P[8] == null)
                {
                    P[8] = new Paciente();
                    P[8].cadastrar();
                    P[8].preferencia();
                }
                else if (P[9] == null)
                {
                    P[9] = new Paciente();
                    P[9].cadastrar();
                    P[9].preferencia();
                }
                else
                {
                    Console.WriteLine("Lista Lotada");
                    Console.ReadKey();
                }*/

                for (int k = 0; k < 10; k++)
                {
                    for (int j = k + 1; j < 10; j++)
                    {
                        if (P[j] != null)
                        {
                            if (P[k].preferencialbool == false && P[j].preferencialbool == true)
                            {
                                paux = P[k];
                                P[k] = P[j];
                                P[j] = paux;
                            }
                        }
                    }
                }

            }
            else if (escolha == "L" || escolha == "l")
            {
                Console.WriteLine("-----Lista dos Pacientes-----");
                for (int i = 0; i < 10; i++)
                {
                    if (P[i] != null)
                    {
                        P[i].listar();
                        Console.WriteLine("Sua posição na fila é: {0}", i);
                        Console.WriteLine("  ");
                    }
                }
                if (P[0] == null)
                {
                    Console.WriteLine("Nenhum Paciente Cadastrado");
                }
                Console.ReadKey();
                /*if (P[0] != null)
                {
                    //P[0] = P[0];
                    P[0].listar();
                }
                if (P[1] != null)
                {
                    //P[1] = P[1];
                    P[1].listar();
                }
                if (P[2] != null)
                {
                    //P[2] = P[2];
                    P[2].listar();
                }
                if (P[3] != null)
                {
                    //P[3] = P[3];
                    P[3].listar();
                }
                if (P[4] != null)
                {
                    //P[4] = P[4];
                    P[4].listar();
                }
                if (P[5] != null)
                {
                    //P[5] = P[5];
                    P[5].listar();
                }
                if (P[6] != null)
                {
                    //P[6] = P[6];
                    P[6].listar();
                }
                if (P[7] != null)
                {
                    //P[7] = P[7];
                    P[7].listar();
                }
                if (P[8] != null)
                {
                    //P[8] = P[8];
                    P[8].listar();
                }
                if (P[9] != null)
                {
                    //P[9] = P[9];
                    P[9].listar();
                }
                if(P[0] == null)
                {
                    Console.WriteLine("Nenhum Paciente Cadastrado");
                }*/
            }
            else if (escolha == "A" || escolha == "a")
            {
                if (P[0] == null)
                {
                    Console.WriteLine("Nenhum Paciente Cadastrado");
                    Console.ReadKey();
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (P[i] != null)
                        {
                            P[i].alteracao();
                            Console.WriteLine(" - Posição: {0}", i);
                        }
                    }
                    Console.WriteLine("Escolha a posição do paciente para alterar os dados");
                    int p;
                    p = int.Parse(Console.ReadLine());
                    //P[p] = new Paciente();
                    P[p].novocadastrar();
                    P[p].preferencia();
                    for (int k = 0; k < 10; k++)
                    {
                        for (int j = k + 1; j < 10; j++)
                        {
                            if (P[j] != null)
                            {
                                if (P[k].preferencialbool == false && P[j].preferencialbool == true)
                                {
                                    paux = P[k];
                                    P[k] = P[j];
                                    P[j] = paux;
                                }
                            }
                        }
                    }
                }
               

            }
            else if (escolha == "T" || escolha == "t")
            {
                Console.WriteLine("Dados do Paciente Atendido:");
                if(P[0] != null)
                {
                    //P[0] = P[0];
                    P[0].listar();
                    Console.ReadKey();
                    int e = 1;
                    for (int s = 0; s < 9; s++)
                    {
                        P[s] = P[e];
                        e++;
                    }
                    for (int y = 9; y > -1; y--)
                    {
                        //P[y] = P[y];
                        if (P[y] != null)
                        {
                            if (P[y].preferencialbool == null)
                            {
                                P[y] = null;
                            }
                        }
                        if(P[9] != null)
                        {
                            P[9] = null;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum Paciente Cadastrado");
                    Console.ReadKey();
                }
            }
        }
    }
}
