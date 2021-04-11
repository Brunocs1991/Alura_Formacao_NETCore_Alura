using ProjetoMVCECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVCECommerce.Models
{
    public class UpdateQuantidadeResponse
    {
        public ItemPedido ItemPedido { get; private set; }
        public CarrinhoViewModel CarrinhoViewModel { get; private set; }

        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            this.ItemPedido = itemPedido;
            this.CarrinhoViewModel = carrinhoViewModel;
        }
    }
}
