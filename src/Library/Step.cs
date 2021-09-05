//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        public double Costo() {
            return ((this.Input.UnitCost*this.Quantity)/1000) + ((this.Equipment.HourlyCost*this.Time)/3600);
        }
        // Tomamos el tiempo en segundos. 
        // Tomamos las unidades de los insumos en kilos/litros.
    }
}
// Le agregamos la responsabilidad de calcular el costo de los insumos y equipamientos porque conoce todos los datos.