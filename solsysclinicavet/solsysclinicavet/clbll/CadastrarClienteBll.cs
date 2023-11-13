using System.Data;
using System;
using System.Collections.Generic;
using cldal;
using clmodel;

namespace clbll
{
    public class CadastrarClienteBll
    {
        private ClientesDal ClientesDal;

        public CadastrarClienteBll()
        {
            ClientesDal = new ClientesDal();
        }

        public void inserir(ClientesModel parCliente) 
        {
            
            if (ClientesDal.VerificarEmailExistente(parCliente.Email) == false)
            {
                this.ClientesDal.inserir(parCliente);
            }
            else
            {
                throw new Exception(" Este e-mail já está no sistema."); 
            }
        }

        public void atualizar(ClientesModel parCliente)
        {
            this.ClientesDal.atualizar(parCliente);
        }

        public void deletar(int parCodigoCliente)
        {
            this.ClientesDal.excluir(parCodigoCliente);
        }

        public DataTable listarTodosAlunos()
        {
            return this.ClientesDal.listarTodos();
        }

        public List<ClientesModel> listaTodosArray()
        {
            return this.ClientesDal.listarTodosArray();
        }
    }
}