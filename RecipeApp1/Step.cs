namespace RecipeApp1
{
    internal class Step
    {
        // This class encapsulates information about a specific step in a recipe, such as its description.
        public string Description { get; }


        // The constructor initializes the Step object with the provided description.
        public Step(string description)
        {
            Description = description;
        }
    }
}
