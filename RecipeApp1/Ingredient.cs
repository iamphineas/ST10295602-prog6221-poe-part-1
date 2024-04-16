namespace RecipeApp1
{
    internal class Ingredient
    {
        // The Name property represents the name of the ingredient and provides read-only access.
        public string Name { get; }

        // The originalQuantity field stores the original quantity of the ingredient for resetting purposes.
        private double originalQuantity;

        // The Quantity property represents the quantity of the ingredient and provides both get and set access.
        public double Quantity { get; set; }

        // The Unit property represents the unit of measurement for the ingredient and provides read-only access.
        public string Unit { get; }

        // The constructor initializes the Ingredient object with the provided name, quantity, and unit.
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            originalQuantity = quantity;
            Unit = unit;
        }

        // The ResetQuantity method resets the current quantity of the ingredient to its original value.
        public void ResetQuantity()
        {
            Quantity = originalQuantity;
        }
    }
}
