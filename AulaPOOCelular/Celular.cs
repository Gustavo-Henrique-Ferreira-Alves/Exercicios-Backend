namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor = "Azul";

        public string modelo = "Samsung Galaxy A11";

        public string tamanho = "6.4 polegadas";

        public bool ligar;

        public bool Ligar()
        {
            ligar = true;
            return ligar;
        }

        public bool Desligar()
        {
            ligar = false;
            return ligar;
        }

        public string Ligacao()
        {
            string ligacao = "Ligação conclúida!!!";
            return ligacao;
        }

        public string Mensagem()
        {
            string mensagem = "Mensagem enviada!!!";
            return mensagem;
        }
    }
}