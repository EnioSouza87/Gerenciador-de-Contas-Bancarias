using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace trabalho_g2_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAÇÃO DE ARRAYS
            string[] contas = new string[10];
            double[] saldos = new double[10];

            //DECLARAÇÃO DE VARIAVEIS 
            int escolha = 0;
            int indiceUsuario;
            string resposta, contasAux;
            double saldosAux;

            while (escolha != 7)
            {

                Console.WriteLine("BEM VINDO AO CONTROLE DE CONTAS DO BANCO SOUZA E VEDOY");
                Console.WriteLine("================================================");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("ESCOLHA A OPÇÃO DESEJADA");
                Console.WriteLine("1 - GERENCIAR CLIENTES");
                Console.WriteLine("2 - VERIFICAR SALDO");
                Console.WriteLine("3 - REALIZAR DEPÓSITO");
                Console.WriteLine("4 - REALIZAR SAQUE");
                Console.WriteLine("5 - REALIZAR TRANSFERÊNCIA");
                Console.WriteLine("6 - EMITIR RELATÓRIO DE CLIENTES CADASTRADOS");
                Console.WriteLine("7 - FINALIZAR O PROGRAMA");

                Console.Write("ESCOLHA SUA OPÇÃO: ");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (escolha)
                {
                    case 1:

                        do
                        {
                            Console.WriteLine("ESCOLHA A OPÇÃO DESEJADA");
                            Console.WriteLine(" 1 - CADASTRAR CLIENTE");
                            Console.WriteLine(" 2 - ATUALIZAR DADOS DO CLIENTE");
                            Console.WriteLine(" 3 - VISUALIZAR DADOS DO CLIENTE");
                            Console.WriteLine(" 4 - EXCLUIR DADOS DO CLIENTE");
                            Console.WriteLine(" 5 - VOLTAR");
                            Console.Write("ESCOLHA SUA OPÇÃO: ");
                            escolha = int.Parse(Console.ReadLine());

                            switch (escolha)
                            {
                                case 1://CADASTRAR CLIENTE
                                    Console.Clear();
                                    Console.WriteLine("BEM VINDO A TELA DE CADASTRO DE CLIENTES");
                                    Console.WriteLine("================================================");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.Write("CONTINUAR O CADASTRO? - S/N - ");
                                    string continuarCadastro = Console.ReadLine();
                                    continuarCadastro = continuarCadastro.ToUpper();
                                    Console.Clear();
                                    if (continuarCadastro == "S" && contas.Length <= 10)
                                    {
                                        for (int i = 0; i < contas.Length && continuarCadastro == "S"; i++)
                                        {
                                            Console.Write("Insira o nome do cliente: ");
                                            contas[i] = Console.ReadLine();
                                            Console.Write("Insira o saldo do cliente: ");
                                            saldos[i] = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Adicionar outro Cliente? -  ");
                                            continuarCadastro = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                        }
                                    }
                                    break;

                                case 2: //ATUALIZAR CLIENTE
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("BEM VINDO A TELA DE ATUALIZAÇÃO DE CLIENTES");
                                        Console.WriteLine("================================================");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.Write("CONTINUAR ? - S/N - ");
                                        resposta = Console.ReadLine();
                                        resposta = resposta.ToUpper();
                                        if (resposta.Equals("S"))
                                        {
                                            Console.Write("QUAL O CÓDIGO DO CLIENTE? ");
                                            indiceUsuario = Convert.ToInt32(Console.ReadLine());
                                            if (indiceUsuario >= 0 && indiceUsuario < contas.Length)
                                            {
                                                Console.WriteLine("CLIENTE ATUAL: " + " " + "NOME: " + contas[indiceUsuario] + " " + "SALDO: R$ " + saldos[indiceUsuario]);
                                                Console.Write("DIGITE O NOME DO NOVO CLIENTE: ");
                                                contasAux = Console.ReadLine();
                                                Console.Clear();
                                                contas[indiceUsuario] = contasAux;
                                                Console.Write("DIGITE O SALDO DO NOVO CLIENTE: ");
                                                saldosAux = Convert.ToDouble(Console.ReadLine());
                                                Console.Clear();
                                                saldos[indiceUsuario] = saldosAux;
                                            }
                                            Console.Clear();
                                            Console.WriteLine("COD:...({0})...NOME DO CLIENTE:....{1}.......SALDO DO CLIENTE:....{2}", indiceUsuario, contas
                                                [indiceUsuario], saldos[indiceUsuario]);
                                        }
                                    } while (resposta.Equals("N"));
                                    break;

                                case 3:   //VISUALIZAR CLIENTE
                                    do
                                    {

                                        Console.Clear();
                                        Console.WriteLine("BEM VINDO A TELA DE VISUALIZAÇÃO DE CLIENTES");
                                        Console.WriteLine("================================================");
                                        Console.Write("CONTINUAR ? - S para continuar ou 1 para voltar ao MENU: ");
                                        resposta = Console.ReadLine(); //VARIAVEL PARA ARMAZENAR A RESPOSTA DO USUARIO
                                        resposta = resposta.ToUpper();
                                        if (resposta.Equals("S"))//SE A RESPOSTA DO USUARIO FOR IGUAL A S ELE FAZ O BLOCO DE INSTRUÇÕES
                                        {
                                            Console.Write("DIGITE O CÓDIGO DO CLIENTE: ");

                                            indiceUsuario = Convert.ToInt32(Console.ReadLine());//VARIAVEL EXTRA PRA ARMAZENAR O CODIGO DO CLIENTE
                                            Console.Clear();
                                            if (indiceUsuario >= 0 && indiceUsuario < contas.Length)//CONDIÇÃO PARA PERCORRER O VETOR
                                            {
                                                Console.Clear();
                                                Console.WriteLine("CÓDIGO: " + indiceUsuario + " NOME: " + contas[indiceUsuario] + " SALDO ATUAL: R$ " + saldos[indiceUsuario]);
                                                Console.WriteLine(" ");
                                                Console.WriteLine(" ");
                                                Console.WriteLine(" ");

                                            }
                                            else if (contas[indiceUsuario] == null)
                                            {
                                                Console.WriteLine("CONTA NÃO ENCONTRADA!");
                                            }
                                        }
                                    } while (resposta.Equals("N"));
                                    break;
                                case 4://EXCLUIR CLIENTE                    
                                    do
                                    {

                                        Console.Clear();
                                        Console.WriteLine("BEM VINDO A TELA DE EXCLUSÃO DE CLIENTES");
                                        Console.WriteLine("================================================");
                                        Console.Write("CONTINUAR ? - S para continuar ou 1 para voltar ao MENU: ");
                                        resposta = Console.ReadLine(); //VARIAVEL PARA ARMAZENAR A RESPOSTA DO USUARIO
                                        resposta = resposta.ToUpper();
                                        if (resposta.Equals("S"))//SE A RESPOSTA DO USUARIO FOR IGUAL A S ELE FAZ O BLOCO DE INSTRUÇÕES
                                        {
                                            Console.Write("DIGITE O CÓDIGO DO CLIENTE: ");
                                            indiceUsuario = Convert.ToInt32(Console.ReadLine());//VARIAVEL EXTRA PRA ARMAZENAR O CODIGO DO CLIENTE
                                            if (indiceUsuario >= 0 && indiceUsuario < contas.Length)//CONDIÇÃO PARA PERCORRER O VETOR
                                            {
                                                Console.Clear();
                                                Console.WriteLine("COD:...({0})...NOME DO CLIENTE:....{1}.......SALDO DO CLIENTE:....{2}", indiceUsuario, contas
                                                [indiceUsuario], saldos[indiceUsuario]);
                                                Console.WriteLine(" ");
                                                Console.WriteLine(" ");
                                                Console.Write("CONFIRMAR EXCLUSÃO DO CLIENTE? TECLE S - CONFIRMAR.......1 - VOLTAR:");
                                                resposta = Console.ReadLine();
                                                resposta = resposta.ToUpper();
                                                if (resposta.Equals("S"))
                                                {
                                                    contas[indiceUsuario] = null;
                                                    saldos[indiceUsuario] = 0;
                                                    Console.WriteLine("CONTA EXCLUÍDA COM SUCESSO!");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("CONTA NÃO ENCONTRADA!");
                                                Console.WriteLine(" ");
                                                Console.WriteLine(" ");
                                            }
                                        }
                                    } while (resposta.Equals("N"));
                                    break;
                                case 5://VOLTAR
                                    Console.Clear();
                                    break;
                                default://OPÇÃO INVALIDA
                                    Console.Clear();
                                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    break;
                            }
                        } while (escolha != 5);
                        break;

                    case 2://CONSULTA DE SALDO
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("BEM VINDO A TELA DE CONSULTA DE SALDO DE CLIENTES");
                            Console.WriteLine("================================================");
                            Console.Write("CONTINUAR ? - S para continuar ou 1 para voltar ao MENU: ");
                            resposta = Console.ReadLine(); //VARIAVEL PARA ARMAZENAR A RESPOSTA DO USUARIO
                            resposta = resposta.ToUpper();
                            if (resposta.Equals("S"))//SE A RESPOSTA DO USUARIO FOR IGUAL A S ELE FAZ O BLOCO DE INSTRUÇÕES
                            {
                                Console.Write("DIGITE O CÓDIGO DO CLIENTE: ");
                                indiceUsuario = Convert.ToInt32(Console.ReadLine());//VARIAVEL EXTRA PRA ARMAZENAR O CODIGO DO CLIENTE
                                if (indiceUsuario >= 0 && indiceUsuario < contas.Length)//CONDIÇÃO PARA PERCORRER O VETOR
                                {
                                    Console.Clear();
                                    Console.WriteLine("COD:...({0})...NOME DO CLIENTE:....{1}.......SALDO DO CLIENTE:....{2}", indiceUsuario, contas
                                    [indiceUsuario], saldos[indiceUsuario]);
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                }
                                else
                                {
                                    Console.WriteLine("CONTA NÃO ENCONTRADA!");
                                }
                            }
                        } while (resposta.Equals("N"));
                        break;

                    case 3://FUNÇÃO DEPÓSITO
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("BEM VINDO A TELA DE DEPÓSITO");
                            Console.WriteLine("================================================");
                            Console.Write("CONTINUAR ? - S para continuar ou 1 para voltar ao MENU: ");
                            resposta = Console.ReadLine(); //VARIAVEL PARA ARMAZENAR A RESPOSTA DO USUARIO
                            resposta = resposta.ToUpper();
                            if (resposta.Equals("S"))//SE A RESPOSTA DO USUARIO FOR IGUAL A S ELE FAZ O BLOCO DE INSTRUÇÕES
                            {
                                Console.Write("DIGITE O CÓDIGO DO CLIENTE: ");
                                indiceUsuario = Convert.ToInt32(Console.ReadLine());//VARIAVEL EXTRA PRA ARMAZENAR O CODIGO DO CLIENTE
                                if (indiceUsuario >= 0 && indiceUsuario < contas.Length)//CONDIÇÃO PARA PERCORRER O VETOR
                                {
                                    Console.Clear();
                                    Console.Write("DIGITE O VALOR PARA DEPÓSITO: ");
                                    double deposito = Convert.ToDouble(Console.ReadLine());
                                    if (deposito > 0)
                                    {
                                        saldos[indiceUsuario] = saldos[indiceUsuario] + deposito;
                                        Console.WriteLine("COD:...({0})...NOME DO CLIENTE:....{1}.......SALDO DO CLIENTE:....{2}", indiceUsuario, contas
                                       [indiceUsuario], saldos[indiceUsuario]);
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("NÃO FOI POSSÍVEL REALIZAR O DEPÓSITO");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("CONTA NÃO ENCONTRADA! OU VALOR INVÁLIDO");
                                }
                            }
                        } while (resposta.Equals("N"));
                        break;

                    case 4://FUNÇÃO SAQUE
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("BEM VINDO A TELA DE SAQUE");
                            Console.WriteLine("================================================");
                            Console.Write("CONTINUAR ? - S para continuar ou 1 para voltar ao MENU: ");
                            resposta = Console.ReadLine(); //VARIAVEL PARA ARMAZENAR A RESPOSTA DO USUARIO
                            resposta = resposta.ToUpper();
                            if (resposta.Equals("S"))//SE A RESPOSTA DO USUARIO FOR IGUAL A S ELE FAZ O BLOCO DE INSTRUÇÕES
                            {
                                Console.Write("DIGITE O CÓDIGO DO CLIENTE: ");
                                indiceUsuario = Convert.ToInt32(Console.ReadLine());//VARIAVEL EXTRA PRA ARMAZENAR O CODIGO DO CLIENTE
                                if (indiceUsuario >= 0 && indiceUsuario < contas.Length)//CONDIÇÃO PARA PERCORRER O VETOR
                                {
                                    Console.Clear();
                                    Console.Write("DIGITE O VALOR PARA SAQUE: ");
                                    double saque = Convert.ToDouble(Console.ReadLine());
                                    if (saque < saldos[indiceUsuario])
                                    {
                                        saldos[indiceUsuario] = saldos[indiceUsuario] - saque;
                                        Console.WriteLine("COD:...({0})...NOME DO CLIENTE:....{1}.......SALDO DO CLIENTE:....{2}", indiceUsuario, contas
                                       [indiceUsuario], saldos[indiceUsuario]);
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                    }
                                    else if (saque > saldos[indiceUsuario])
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE PARA REALIZAR O SAQUE");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("CONTA NÃO ENCONTRADA! OU VALOR INVÁLIDO");
                                }
                            }
                        } while (resposta.Equals("N"));
                        break;

                    case 5://FUNÇÃO TRANSFERÊNCIA
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("BEM VINDO A TELA DE TRANSFERÊNCIA");
                            Console.WriteLine("================================================");
                            Console.Write("CONTINUAR ? - S para continuar ou 1 para voltar ao MENU: ");
                            resposta = Console.ReadLine(); //VARIAVEL PARA ARMAZENAR A RESPOSTA DO USUARIO
                            resposta = resposta.ToUpper();
                            if (resposta.Equals("S"))
                            {
                                Console.WriteLine("DIGITE O CÓDIGO DO CLIENTE: ");
                                indiceUsuario = Convert.ToInt32(Console.ReadLine());
                                if (indiceUsuario >= 0 && indiceUsuario < contas.Length)
                                {
                                    Console.Clear();
                                    Console.WriteLine("CC: " + indiceUsuario + " NOME: " + contas[indiceUsuario] + " SALDO R$ " + saldos[indiceUsuario]);
                                    Console.WriteLine("DIGITE O VALOR A SER TRANSFERIDO: ");
                                    double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                                    saldos[indiceUsuario] = saldos[indiceUsuario] - valorTransferencia;
                                    if (valorTransferencia <= saldos[indiceUsuario])
                                    {
                                        Console.Clear();
                                        Console.WriteLine("DIGITE O CODIGO DA CONTA A SER TRANSFERIDO: ");
                                        indiceUsuario = Convert.ToInt32(Console.ReadLine());
                                        if (indiceUsuario >= 0 && indiceUsuario < contas.Length)
                                        {
                                            Console.WriteLine("CC: " + indiceUsuario + " NOME: " + contas[indiceUsuario] + " SALDO R$ " + saldos[indiceUsuario]);
                                            saldos[indiceUsuario] = saldos[indiceUsuario] + valorTransferencia;
                                            Console.WriteLine(" ");
                                            Console.WriteLine("TRANSFERÊNCIA REALIZADA COM SUCESSO!");
                                            Console.WriteLine(" ");
                                        }
                                        else
                                        {
                                            Console.WriteLine("CLIENTE NÃO ENCONTRADO");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                    }

                                }
                            }

                        } while (resposta.Equals("N"));
                        break;


                    case 6://FUNÇÃO RELATÓRIO DE CLIENTE
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("BEM VINDO A TELA DE RELATÓRIOS DE CLIENTES");
                            Console.WriteLine("================================================");
                            Console.Write("CONTINUAR ? - S para continuar ou 1 para voltar ao MENU: ");
                            resposta = Console.ReadLine(); //VARIAVEL PARA ARMAZENAR A RESPOSTA DO USUARIO
                            resposta = resposta.ToUpper();
                            if (resposta.Equals("S"))//SE A RESPOSTA DO USUARIO FOR IGUAL A S ELE FAZ O BLOCO DE INSTRUÇÕES
                            {

                                Console.Clear();
                                for (indiceUsuario = 0; indiceUsuario < contas.Length; indiceUsuario++)
                                {
                                    Console.WriteLine("COD:...({0})...NOME DO CLIENTE:....{1}.......SALDO DO CLIENTE:....{2}", indiceUsuario, contas
                                    [indiceUsuario], saldos[indiceUsuario]);



                                }
                                Console.WriteLine(" ");
                            }
                        } while (resposta.Equals("N"));
                        break;

                    case 7: // FECHAR O PROGRAMA
                        break;

                    default: // OPÇÃO INVÁLIDA
                        Console.Clear();
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        break;

                }

            }
            Console.WriteLine("OBRIGADO POR UTILIZAR O SOUZA E VEDOY BANK!");
            Console.WriteLine("VOLTE SEMPRE!");
            Console.ReadKey();
        }
    }
}
