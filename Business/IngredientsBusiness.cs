using Data;
using Shared.DTO;
using Shared.Interfaces;
using Shared.Models;

namespace Business;

public class IngredientsBusiness : EntityComponent<Ingredient, IngredientDTO>
{
    private readonly IngredientsRepository repository;

    public IngredientsBusiness()
    {
        repository = IngredientsRepository.getInstance();
    }

    public Ingredient Create(IngredientDTO newData)
    {
        return repository.Create(newData);
    }

    public bool Delete(string id)
    {
        return repository.Delete(id);
    }

    public List<Ingredient> Read()
    {
        return repository.Read();
    }

    public Ingredient ReadOne(string id)
    {
        return repository.ReadOne(id);
    }

    public Ingredient Update(string id, IngredientDTO updatedData)
    {
        return repository.Update(id, updatedData);
    }
}

