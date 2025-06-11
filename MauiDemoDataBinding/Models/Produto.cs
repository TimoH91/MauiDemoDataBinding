using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoDataBinding.Models
{
    internal class Produto : INotifyPropertyChanged
    {
        private string nome;
        private decimal preco;
        private int estoque;

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged();
            }
        }

        public decimal Preco
        {
            get => preco;
            set
            {
                preco = value;
                OnPropertyChanged();
            }
        }

        public int Estoque
        {
            get => estoque;
            set
            {
                estoque = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
