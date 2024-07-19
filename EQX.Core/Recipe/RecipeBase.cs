namespace EQX.Core.Recipe
{
    public class RecipeBase : IRecipe
    {
        public int Id { get; internal set; }

        public string Name { get; set; }

        public virtual IRecipe Load()
        {
            return new RecipeBase();
        }

        public virtual void Save()
        {
        }
    }
}
