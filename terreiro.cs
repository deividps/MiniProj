class Terreiro 
{
  private string NomeTerreiro;
  protected string NomeSacerdote;
  private string Endereco;
  
  public void setNomeTerreiro ()
  {
    NomeTerreiro = " ";
  }

  public string getNomeTerreiro(string NT)
  {
    NomeTerreiro = NT;
  }

  public void setNomeSacerdote()
  {
    NomeSacerdote = " ";
  }

  public string getNomeSacerdote(string NS)
  {
    NomeSacerdote = NS;
  }

  public void setEndereco()
  {
    Endereco = " ";
  }

  public string getEndereco(string Address)
  {
    Endereco = Address;
  }

  public Terreiro (string NT, string NS, string ADDRESS)
  {
    NT = " Digite o nome da casa";
    NS = " Digite o nome do Sacerdote responsável";
    ADDRESS = " Digite o Endereço da Casa";
  }
}