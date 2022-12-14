using AtividadeFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var locacaoController = new LocacaoController();


            var tipoEquipamento = new TipoEquipamento();

            tipoEquipamento.Id = 1;
            tipoEquipamento.Descricao = "Notebook";
            tipoEquipamento.ValorLocacaoDiaria = 50.5f;

            var equipamento1 = new Equipamento();
            equipamento1.Id = 1;
            equipamento1.Nome = "Dell";

            var equipamento2 = new Equipamento();
            equipamento2.Id = 2;
            equipamento2.Nome = "Asus";

            tipoEquipamento.AdicionarEquipamento(equipamento1);
            tipoEquipamento.AdicionarEquipamento(equipamento2);

            locacaoController.Cadastrar(tipoEquipamento);

            var tipoEquipamento2 = new TipoEquipamento();

            tipoEquipamento2.Id = 2;
            tipoEquipamento2.Descricao = "DataShow";
            tipoEquipamento2.ValorLocacaoDiaria = 500.5f;

            var equipamento3 = new Equipamento();
            equipamento3.Id = 2;
            equipamento3.Nome = "Asus DataShow";

            tipoEquipamento2.AdicionarEquipamento(equipamento3);


            locacaoController.Cadastrar(tipoEquipamento2);

            var seletor = new Seletor(locacaoController);

            int opcao = -1;
            while (opcao != 0)
            {
                opcao = seletor.EscolherOpcao();
            }

        }
    }
}
