using System;

public class Veiculo
{
    //Atributos
    private string renavam;
    private string chassi;
    private string modelo;
    private string marca;
    private string cor;
    private string ano;
    private string placa;
    private string cambio;
    private string combustivel;
    private double fipe;

    //Método Get / Set

    public string getRenavam() { return this.renavam; }
    public void setRenavam(string p_renavam) { this.renavam = p_renavam; }

    public string getChassi() { return this.chassi; }
    public void setChassi(string p_chassi) { this.chassi = p_chassi; }

    public string getModelo() { return this.modelo; }
    public void setModelo(string p_modelo) { this.modelo = p_modelo; }  

    public string getMarca() { return this.marca; }
    public void setMarca(string p_marca) { this.marca = p_marca; }

    public string getCor() { return this.cor; }
    public void setCor(string p_cor) { this.cor = p_cor; }

    public string getAno() { return this.ano; }
    public void setAno(string p_ano) { this.ano = p_ano;}

    public string getPlaca() { return this.placa; }
    public void setPlaca(string p_placa) { this.placa = p_placa; }

    public string getCambio() { return this.cambio; }
    public void setCambio(string p_cambio) { this.cambio = p_cambio; }

    public string getCombustivel() { return this.combustivel; }
    public void setCombustivel(string p_combustivel) { this.combustivel = p_combustivel; }

    public double getFipe() { return this.fipe; }
    public void setFipe(double fipe) { this.fipe = fipe; }
}