using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.NET
{
	using System;

	class Equipamento
	{
		static void Main(string[] args)
		{
			int menuInicial = 0;

			const int CAPACIDADE_REGISTROS = 100;
			int[] idEquipamento = new int[CAPACIDADE_REGISTROS];
			string[] nomesEquipamento = new string[CAPACIDADE_REGISTROS];
			double[] precosEquipamento = new double[CAPACIDADE_REGISTROS];
			int[] numerosSerieEquipamento = new int[CAPACIDADE_REGISTROS];
			DateTime[] datasFabricacaoEquipamento = new DateTime[CAPACIDADE_REGISTROS];
			string[] fabricantesEquipamento = new string[CAPACIDADE_REGISTROS];

			int[] idChamado = new int[CAPACIDADE_REGISTROS];
			string[] titulosChamado = new string[CAPACIDADE_REGISTROS];
			string[] descricoesChamado = new string[CAPACIDADE_REGISTROS];
			DateTime[] datasAberturaChamado = new DateTime[CAPACIDADE_REGISTROS];
			string[] equipamentosChamado = new string[CAPACIDADE_REGISTROS];

			while (menuInicial != 3)
			{
				Console.WriteLine("########## Menu Inicial ##########");
				Console.WriteLine("Digite a opcao desejada: \n");
				Console.WriteLine("1 - Equipamentos");
				Console.WriteLine("2 - Chamados");
				Console.WriteLine("3 - Sair");

				menuInicial = Convert.ToInt32(Console.ReadLine());
				Console.Clear();

				switch (menuInicial)
				{
					case 1:
						{
							int menuEquipamentos = 0;
							while (menuEquipamentos != 5)
							{
								Console.WriteLine("########## Menu de Equipamento ##########");
								Console.WriteLine("Digite a opcao desejada: ");
								Console.WriteLine("1 - Cadastrar");
								Console.WriteLine("2 - Editar");
								Console.WriteLine("3 - Remover");
								Console.WriteLine("4 - Listar");
								Console.WriteLine("5 - Voltar ao menu inicial");

								menuEquipamentos = Convert.ToInt32(Console.ReadLine());
								Console.Clear();

								if (menuEquipamentos == 1)
								{
									string nomeEq;
									bool nomeEqInvalido = false;
									do
									{
										Console.Write("Digite o nome do equipamento: ");
										nomeEq = Console.ReadLine();
										if (nomeEq.Length < 6)
										{
											nomeEqInvalido = true;
											Console.ForegroundColor = ConsoleColor.Red;
											Console.WriteLine("Nome inválido. Precisa ter ao menos 6 caracteres");
											Console.ResetColor();
										}
										else
                                        {
											nomeEqInvalido = false;
                                        }
									} while (nomeEqInvalido);

									Console.Write("Digite o preço do equipamento: ");
									double precoEq = Convert.ToDouble(Console.ReadLine());

									Console.Write("Digite o número de série do equipamento: ");
									int numeroSerieEq = Convert.ToInt32(Console.ReadLine());

									Console.Write("Digite a data de fabricação do equipamento: ");
									DateTime dataFabricacaoEq = Convert.ToDateTime(Console.ReadLine());

									Console.Write("Digite o fabricante do equipamento: ");
									string fabricanteEq = Console.ReadLine();

									Console.Clear();

									int i = 0;
									foreach (int id in idEquipamento)
									{	
										if (id==0)
                                        {
											idEquipamento[i] = i+1;
											nomesEquipamento[i] = nomeEq;
											precosEquipamento[i] = precoEq;
											numerosSerieEquipamento[i] = numeroSerieEq;
											datasFabricacaoEquipamento[i] = dataFabricacaoEq;
											fabricantesEquipamento[i] = fabricanteEq;
											break;
                                        }
										i++;
									}
								}
								else if (menuEquipamentos == 2)
								{
									int editarEqCampo = 0;
									int editarEq = 0;

									Console.Write("IDs dos Equipamentos Cadastrados: ");
									foreach (int id in idEquipamento)
									{
										if (id != 0)
										{
											Console.Write(id);
											Console.Write("  ");
										}

									}
									Console.WriteLine();
									Console.WriteLine("Digite o ID do equipamento que você deseja alterar: ");
									editarEq = Convert.ToInt32(Console.ReadLine());

									editarEq--;
									Console.Clear();

									Console.WriteLine("1 - Alterar nome");
									Console.WriteLine("2 - Alterar valor de aquisição");
									Console.WriteLine("3 - Alterar número de série");
									Console.WriteLine("4 - Alterar data fabricação");
									Console.WriteLine("5 - Alterar fabricante");
									editarEqCampo = Convert.ToInt32(Console.ReadLine());
									Console.Clear();

									if (editarEqCampo == 1)
									{
										Console.WriteLine("Digite o novo  nome");
										nomesEquipamento[editarEq] = Console.ReadLine();
									}
									else if (editarEqCampo == 2)
									{
										Console.WriteLine("Digite o novo valor de aquisição");
										precosEquipamento[editarEq] = Convert.ToDouble(Console.ReadLine());
									}
									else if (editarEqCampo == 3)
									{
										Console.WriteLine("Digite o novo número de série");
										numerosSerieEquipamento[editarEq] = Convert.ToInt32(Console.ReadLine());
									}
									else if (editarEqCampo == 4)
									{
										Console.WriteLine("Digite a nova data de fabricação");
										datasFabricacaoEquipamento[editarEq] = Convert.ToDateTime(Console.ReadLine());
									}
									else if (editarEqCampo == 5)
									{
										Console.WriteLine("Digite o novo fabricante");
										fabricantesEquipamento[editarEq] = Console.ReadLine();
									}
									else
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine("Nome inválido. Precisa ter ao menos 6 caracteres");
										Console.ResetColor();
										Console.Clear();
									}
								}
								else if (menuEquipamentos == 3)
								{
									int excluirEq = 0;

									Console.Write("IDs dos Equipamentos Cadastrados: ");
									foreach (int id in idEquipamento)
									{
										if (id != 0)
										{
											Console.Write(id);
											Console.Write("  ");
										}
									}
									Console.WriteLine();
									Console.WriteLine("Digite o ID do equipamento que você deseja excluir: ");
									excluirEq = Convert.ToInt32(Console.ReadLine());
									excluirEq--;
									Console.Clear();

									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write("TEM CERTEZA? Digite \"SIM\" para continuar.\n");
									Console.ResetColor();

									string confirmacaoExclusao = Console.ReadLine();
									if (confirmacaoExclusao == "SIM" || confirmacaoExclusao == "sim")
                                    {
										idEquipamento[excluirEq] = 0;
										nomesEquipamento[excluirEq] = null;
										precosEquipamento[excluirEq] = 0;
										numerosSerieEquipamento[excluirEq] = 0;
										datasFabricacaoEquipamento[excluirEq] = DateTime.MinValue;
										fabricantesEquipamento[excluirEq] = null;
									}
								}
								else if (menuEquipamentos == 4)
								{
									int count = 0;
									Console.WriteLine("Equipamentos Cadastrados: ");
									foreach (int id in idEquipamento)
									{
										if (id != 0)
										{
											Console.Write("Nome: ");
											Console.WriteLine(nomesEquipamento[count]);

											Console.Write("Valor Aquisição: ");
											Console.WriteLine(precosEquipamento[count]);

											Console.Write("Número de Série: ");
											Console.WriteLine(numerosSerieEquipamento[count]);

											Console.Write("Data Fabricação: ");
											Console.WriteLine(datasFabricacaoEquipamento[count].ToShortDateString());

											Console.Write("Fabricante: ");
											Console.WriteLine(fabricantesEquipamento[count]);
											Console.WriteLine();
										}
										count++;

									}
									Console.ReadLine();
									Console.Clear();
								}
								else if (menuEquipamentos == 5)
								{
									break;
								}
								else
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine("Opção de menu equipamento inválida, tente novamente");
									Console.ResetColor();
									Console.ReadLine();
								}
							}
							break;
						}
					case 2:
                        {
							int menuChamados = 0;
							while (menuChamados != 5)
							{
								Console.WriteLine("########## Menu de Chamados ##########");
								Console.WriteLine("Digite a opcao desejada: ");
								Console.WriteLine("1 - Cadastrar");
								Console.WriteLine("2 - Editar");
								Console.WriteLine("3 - Remover");
								Console.WriteLine("4 - Listar");
								Console.WriteLine("5 - Voltar ao menu inicial");

								menuChamados = Convert.ToInt32(Console.ReadLine());
								Console.Clear();

								if (menuChamados == 1)
								{
									string tituloCh;
									bool tituloChInvalido = false;
									do
									{
										Console.Write("Digite o titulo do chamado: ");
										tituloCh = Console.ReadLine();
										if (tituloCh.Length < 6)
										{
											tituloChInvalido = true;
											Console.ForegroundColor = ConsoleColor.Red;
											Console.WriteLine("Nome inválido. Precisa ter ao menos 6 caracteres");
											Console.ResetColor();
										}
										else
										{
											tituloChInvalido = false;
										}
									} while (tituloChInvalido);

									Console.Write("Digite a descrição do chamado: ");
									string descricaoCh = Console.ReadLine();

									Console.Write("Digite a data de fabricação do equipamento: ");
									DateTime dataAberturaCh = Convert.ToDateTime(Console.ReadLine());

									Console.Write("Digite o fabricante do equipamento: ");
									string equipamentoCh = Console.ReadLine();

									Console.Clear();

									int j = 0;
									foreach (int id in idChamado)
									{
										if (id == 0)
										{
											idChamado[j] = j + 1;
											titulosChamado[j] = tituloCh;
											descricoesChamado[j] = descricaoCh;
											datasAberturaChamado[j] = dataAberturaCh;
											equipamentosChamado[j] = equipamentoCh;
											break;
										}
										j++;
									}
								}
								else if (menuChamados == 2)
								{
									int editarChCampo = 0;
									int editarCh = 0;

									Console.Write("IDs dos chamados Cadastrados: ");
									foreach (int id in idChamado)
									{
										if (id != 0)
										{
											Console.Write(id);
											Console.Write("  ");
										}

									}
									Console.WriteLine();
									Console.WriteLine("Digite o ID do chamado que você deseja alterar: ");
									editarCh = Convert.ToInt32(Console.ReadLine());

									editarCh--;
									Console.Clear();

									Console.WriteLine("1 - Alterar titulo");
									Console.WriteLine("2 - Alterar descrição");
									Console.WriteLine("3 - Alterar data de abertura");
									Console.WriteLine("4 - Alterar equipamento");
									editarChCampo = Convert.ToInt32(Console.ReadLine());
									Console.Clear();

									if (editarChCampo == 1)
									{
										Console.WriteLine("Digite o novo titulo");
										titulosChamado[editarCh] = Console.ReadLine();
									}
									else if (editarChCampo == 2)
									{
										Console.WriteLine("Digite a nova descrição");
										descricoesChamado[editarCh] = Console.ReadLine();
									}
									else if (editarChCampo == 3)
									{
										Console.WriteLine("Digite a nova data de abertura");
										datasAberturaChamado[editarCh] = Convert.ToDateTime(Console.ReadLine());
									}
									else if (editarChCampo == 4)
									{
										Console.WriteLine("Digite o novo equipamento");
										equipamentosChamado[editarCh] = Console.ReadLine();
									}
									else
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine("Nome inválido. Precisa ter ao menos 6 caracteres");
										Console.ResetColor();
										Console.Clear();
									}
								}
								else if (menuChamados == 3)
								{
									int excluirCh = 0;

									Console.Write("IDs dos Chamados Cadastrados: ");
									foreach (int id in idChamado)
									{
										if (id != 0)
										{
											Console.Write(id);
											Console.Write("  ");
										}
									}
									Console.WriteLine();
									Console.WriteLine("Digite o ID do chamado que você deseja excluir: ");
									excluirCh = Convert.ToInt32(Console.ReadLine());
									excluirCh--;
									Console.Clear();

									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write("TEM CERTEZA? Digite \"SIM\" para continuar.\n");
									Console.ResetColor();

									string confirmacaoExclusao = Console.ReadLine();
									if (confirmacaoExclusao == "SIM" || confirmacaoExclusao == "sim")
									{
										idEquipamento[excluirCh] = 0;
										titulosChamado[excluirCh] = null;
										descricoesChamado[excluirCh] = null;
										datasAberturaChamado[excluirCh] = DateTime.MinValue;
										equipamentosChamado[excluirCh] = null;
									}
								}
								else if (menuChamados == 4)
								{
									int count = 0;
									Console.WriteLine("Chamados Cadastrados: ");
									foreach (int id in idChamado)
									{
										if (id != 0)
										{
											Console.Write("Título: ");
											Console.WriteLine(titulosChamado[count]);

											Console.Write("Descrição: ");
											Console.WriteLine(descricoesChamado[count]);

											Console.Write("Data de abertura: ");
											Console.WriteLine(datasAberturaChamado[count].ToShortDateString());

											Console.Write("Equipamento: ");
											Console.WriteLine(equipamentosChamado[count]);
											Console.WriteLine();
										}
										count++;

									}
									Console.ReadLine();
									Console.Clear();
								}
								else if (menuChamados == 5)
								{
									break;
								}
								else
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine("Opção de menu equipamento inválida, tente novamente");
									Console.ResetColor();
									Console.ReadLine();
								}
							}
							break;
						}
					case 3:
                        {
							break;
                        }
					default:
                        {
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Opção de menu inválida, tente novamente");
							Console.ResetColor();
							Console.ReadLine();
							break;
						}
				}
			}

		}
	}
}
