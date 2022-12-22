using System;
public class Cliente
{
    //Atributos
    private string nome;
    private string sexo;
    private string email;
    private string celular;
    private string residencial;
    private DateTime nascimento;
    private string cpf;
    private string logradouro;
    private string numero;
    private string complemento;
    private string cep;
    private string bairro;
    private string cidade;
    private string estado;

    //Método Get / Set
    public string getNome() { return this.nome; }
    public void setNome(string p_nome) { this.nome = p_nome; }

    public string getSexo() { return this.sexo; }
    public void setSexo(string p_sexo) { this.sexo = p_sexo; }

    public string getEmail() { return this.email; }
    public void setEmail(string p_email) { this.email = p_email; }

    public string getCelular() { return this.celular; }
    public void setCelular(string p_celular) { this.celular = p_celular; }

    public string getResidencial() { return this.residencial; }
    public void setResidencial(string p_residencial) { this.residencial = p_residencial; }

    public DateTime getNascimento() { return this.nascimento; }
    public void setNascimento(DateTime p_nascimento) { this.nascimento = p_nascimento; }

    public string getCpf() { return this.cpf; }
    public void setCpf(string p_cpf) { this.cpf = p_cpf; }

    public string getLog() { return this.logradouro; }
    public void setLog(string p_log) { this.logradouro = p_log; }

    public string getNumero() { return this.numero; }
    public void setNumero(string p_numero) { this.numero = p_numero; }

    public string getComplemento() { return this.complemento; }
    public void setComplemento(string p_complemento) { this.complemento = p_complemento; }

    public string getCep() { return this.cep; }
    public void setCep(string p_cep) { this.cep = p_cep; }

    public string getBairro() { return this.bairro; }
    public void setBairro(string p_bairro) { this.bairro = p_bairro; }

    public string getCidade() { return this.cidade; }
    public void setCidade(string p_cidade) { this.cidade = p_cidade; }

    public string getEstado() { return this.estado; }
    public void setEstado(string p_estado) { this.estado = p_estado; }
}
