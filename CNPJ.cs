namespace Aula06Heranca
{
    //modo como lincamos uma class a outra na heranca
    public class CNPJ : Pessoa 
    {
        public string cnpj;

        public bool ValidarCNPJ(){
            if(cnpj != ""){
                return true;
            }
            return false;
        }
    }
}