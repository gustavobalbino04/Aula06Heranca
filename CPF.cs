namespace Aula06Heranca
{
    //modo como lincamos uma class a outra na heranca
    public class CPF : Pessoa
    {
        public string cpf;

        public string rg;

        public bool ValidarCPF(){
            if(cpf != ""){
            return true;
              
            }
            return false;
        }
    }
}