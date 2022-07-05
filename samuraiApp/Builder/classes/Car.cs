using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
    public class Car :IBulder
    {
        private string brandName;
        private Product product;

        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;

        }

        public void AddHeadLieght()
        {
            product.Add("HeadLieght Care Was Added !");
        }

        public void BuildBody()
        {
            product.Add("Body Care Was Added !");
        }

        public void EndOperations()
        {
            product.Add("End operations of Care ");
        }

        public Product GetVehicle()
        {
            return product;

        }

        public void InsertWheels()
        {
            product.Add("Wheel Care are Added !");
        }

        public void StartupOperations()
        {
            product.Add($"Car Model Name: {this.brandName}");
        }
    }
}
