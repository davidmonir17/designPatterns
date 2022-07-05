using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
    public class MotorCycle : IBulder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;

        }

        public void AddHeadLieght()
        {
            product.Add("HeadLieght MotorCycle Was Added !");
        }

        public void BuildBody()
        {
            product.Add("Body MotorCycle Was Added !");
        }

        public void EndOperations()
        {
            product.Add("End operations of MotorCycle ");
        }

        public Product GetVehicle()
        {
            return product;

        }

        public void InsertWheels()
        {
            product.Add("Wheel MotorCycle are Added !");
        }

        public void StartupOperations()
        {
            product.Add($"MotorCycle Model Name: {this.brandName}");
        }
    }
}
