namespace Sobreposicao_override
{
    public abstract class Player
    {
        private float Velocidade;
        private float ForçaDoPulo;
        public virtual string Correr()
        {
            return "O player correu!!!\n";
        }

        public virtual string Pular()
        {
            return "O player pulou!!!\n";
        }
    }
}
