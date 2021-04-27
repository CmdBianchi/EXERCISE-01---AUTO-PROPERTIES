using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___AUTO_PROPERTIES {
    //------------------------------- START -------------------------------//
    class Product {
        private string _name;
        public double Price { get; private set; }
        public int Amount { get; private set; }
        public Product() {
        }
        public Product(string name, double price, int amount) {
            _name = name;
            Price = price;
            Amount = amount;
        }
        public string Name {
            get { return _name; }
            set { if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }       
         
        public double AmountValueStock() {
            return Price * Amount;
        }
        public void AddProducts(int quantidade) {
            Amount += quantidade;
        }
        public void RemoveProducts(int quantidade) {
            Amount -= quantidade;
        }
        public override string ToString() {
            return _name
            + ", $ " + Price.ToString("F2") + ", " + Amount + " unidades, Total: $ " + AmountValueStock().ToString("F2");
        }
    }
    //-------------------------------- END -------------------------------// 
}