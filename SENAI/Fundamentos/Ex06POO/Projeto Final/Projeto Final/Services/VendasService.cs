﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Projeto_Final.Models;
//using Projeto_Final.Services;


//namespace Projeto_Final.Services
//{
//    public class VendasService : Produto
//    {
//        private List<List<Produto>> _vendasEfetuadas;

//        public VendasService()
//        {
//            _vendasEfetuadas = new List<List<Produto>>();
//        }

//        public void AdicionarVendas(List<Produto> listaProd)
//        {   
//           _vendasEfetuadas.Add(listaProd);
//        }
        
//        // Quero a lista que está dentro da lista, identificada pelo Id
//        public List<Produto> ProdutosCompradosID(int id)
//        {
//            return _vendasEfetuadas[id];
//        }    
        
//        public List<List<Produto>> ListarVendas()
//        {
//            return _vendasEfetuadas;
//        }
//    }
//}
