using System;
using System.ComponentModel.DataAnnotations;

namespace calculadora_api.Models

{
    public class ChequeEmpresarial
    {
        [Key]
        public int Id { get; set; }
        public string dataBase { get; set; }
        public string indiceDB { get; set; }
        public float indiceDataBase { get; set; }
        public string indiceBA { get; set; }
        public float indiceDataBaseAtual { get; set; }
        public string dataBaseAtual { get; set; }
        public float valorDevedor { get; set; }
        public string encargosMonetarios { get; set; }
        public float lancamentos { get; set; }
        public string tipoLancamento { get; set; }
        public float valorDevedorAtualizado { get; set; }
        public string contractRef { get; set; }
        public string ultimaAtualizacao { get; set; }
        public string infoParaCalculo { get; set; }

    }

    // public class EncargosMonetarios
    // {
    //     [Key]
    //     public int Id { get; set; }
    //     public float correcaoPeloIndice { get; set; }
    //     public JurosAm jurosAm { get; set; }
    //     public float multa { get; set; }
    // }
    // public class JurosAm
    // {
    //     [Key]
    //     public int Id { get; set; }
    //     public float dias { get; set; }
    //     public float percentsJuros { get; set; }
    //     public float moneyValue { get; set; }
    // }
}