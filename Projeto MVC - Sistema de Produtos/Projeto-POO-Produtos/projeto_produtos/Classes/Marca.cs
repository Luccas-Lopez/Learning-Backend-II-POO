using System.Collections.Generic;
using System;
using projeto_produtos.Interfaces;

namespace projeto_produtos.Classes
{
    public class Marca : IMarca
    {
        // variáveis
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        private DateTime DataCadastro = DateTime.Now;

        public List<Marca> Marcas = new List<Marca>();

        List<Marca> marcas1 = new List<Marca>();
        
        
        public string Cadastrar(Marca novaMarca)
        {

            Marcas.Add(novaMarca);
            return "A marca foi registrada com sucesso !";  

            // funcionando
        }

        public List<Marca> Listar()
        {
            foreach (Marca item in Marcas)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("=================================");
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome da marca: {item.NomeMarca}");
                Console.WriteLine(DataCadastro);
                Console.ResetColor();
            }      
          
            // funcionando
            
            return Marcas;
        }

        public string Deletar(Marca marca, int index)
        {
        
                Marcas.RemoveAt(index);
            

            return "Marca removida com sucesso";

            // funcionando
        }

    }
}