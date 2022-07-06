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
        public double indiceDataBase { get; set; }
        public string indiceBA { get; set; }
        public double indiceDataBaseAtual { get; set; }
        public string dataBaseAtual { get; set; }
        public double valorDevedor { get; set; }
        public string encargosMonetarios { get; set; }
        public double lancamentos { get; set; }
        public string tipoLancamento { get; set; }
        public double valorDevedorAtualizado { get; set; }
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