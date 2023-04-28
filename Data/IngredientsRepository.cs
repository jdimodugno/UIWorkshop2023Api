using Shared.Interfaces;
using Shared.DTO;
using Shared.Models;

namespace Data;

public class IngredientsRepository: EntityComponent<Ingredient, IngredientDTO>
{
    private static IngredientsRepository? _instance;
    private List<Ingredient> ingredients = new List<Ingredient>(); 

    public static IngredientsRepository getInstance()
    {
        if (_instance == null) _instance = new IngredientsRepository();
        return _instance;
    }

    public Ingredient Create(IngredientDTO newIngredientData)
    {
        Ingredient newIngredient = new Ingredient(newIngredientData);
        newIngredient.Id = Guid.NewGuid().ToString();
        this.ingredients.Add(newIngredient);
        return newIngredient;
    }

    public bool Delete(string id)
    {
        try
        {
            int itemIdx = ingredients.FindIndex((Ingredient item) => id == item.Id);
            if (itemIdx >= 0)
            {
                ingredients.RemoveAt(itemIdx);
                return true;
            }
            throw new Exception("Ingredient not found");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            return false;
        }
    }

    public List<Ingredient> Read()
    {
        return ingredients.ToList();
    }

    public Ingredient ReadOne(string id)
    {
        int itemIdx = ingredients.FindIndex((Ingredient item) => id == item.Id);
        return ingredients.ElementAt(itemIdx);
    }

    public Ingredient Update(string id, IngredientDTO updatedIngredientData)
    {
        int itemIdx = ingredients.FindIndex((Ingredient item) => id == item.Id);
        Ingredient newIngredient = new Ingredient(updatedIngredientData);
        newIngredient.Id = id;
        this.ingredients[itemIdx] = newIngredient;
        return newIngredient;
    }
}

