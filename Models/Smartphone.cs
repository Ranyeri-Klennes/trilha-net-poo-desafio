namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            string[] ponto = new string[3];
            ponto[0] = ".";
            ponto[1] = "..";
            ponto[2] = "...";

            foreach(string i in ponto){
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Ligando{0}", i);
                Thread.Sleep(1000);
            }
        }

        public void ReceberLigacao()
        {
            string[] ponto = new string[3];
            ponto[0] = ".";
            ponto[1] = "..";
            ponto[2] = "...";

            foreach(string i in ponto){
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Recebendo ligação{0}", i);
                Thread.Sleep(1000);
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}