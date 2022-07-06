using System;
using System.ComponentModel.DataAnnotations;

namespace calculadora_api.Models

{
    public class ParceladoPre
    {
        [Key]
        public int Id { get; set; }
        public string nparcelas { get; set; }
        public double parcelaInicial { get; set; }
        public double indiceDataVencimento { get; set; }
        public double indiceDataCalcAmor { get; set; }
        public double valorNoVencimento { get; set; }
        public double subtotal { get; set; }
        public double amortizacao { get; set; }
        public double totalDevedor { get; set; }
        public string contractRef { get; set; }

        public string dataVencimento { get; set; }
        public string indiceDV { get; set; }
        public string indiceDCA { get; set; }
        public string dataCalcAmor { get; set; }
        public double valorPMTVincenda { get; set; }
        public string status { get; set; }
        public string ultimaAtualizacao { get; set; }
        public string encargosMonetarios { get; set; }
        public string infoParaCalculo { get; set; }
        public string tipoParcela { get; set; }
        public string infoParaAmortizacao { get; set; }

    }

    // public class EncargosMonetarios
    // {
    //     [Key]
    //     public int Id { get; set; }
    //     public double correcaoPeloIndice { get; set; }
    //     public JurosAm jurosAm { get; set; }
    //     public double multa { get; set; }
    // }
    // public class JurosAm
    // {
    //     [Key]
    //     public int Id { get; set; }
    //     public double dias { get; set; }
    //     public double percentsJuros { get; set; }
    //     public double moneyValue { get; set; }
    // }
    // public class JurosAm
    // {
    //     [Key]
    //     public int Id { get; set; }
    //     public double formMulta { get; set; }
    //     public double formJuros { get; set; }
    //     public double formHonorarios { get; set; }
    //     public double formMultaSobContrato { get; set; }
    //     public double formIndiceEncargos { get; set; }
    // }

    // export interface InfoParaCalculo
    // {
    //     public int Id { get; set; }
    //     public double formMulta { get; set; }
    //     public double formJuros { get; set; }
    //     public double formHonorarios { get; set; }
    //     public double formMultaSobContrato { get; set; }
    //     public double formIndiceEncargos { get; set; }
    //     public double formIndiceDesagio { get; set; }
    //     public string formIndice { get; set; }
    // }

}