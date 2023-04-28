using System;
using Shared.Models;

namespace Shared.Interfaces
{
	public interface EntityComponent<T, TDto>
	{
		List<T> Read();
        T ReadOne(string id);
        T Create(TDto newData);
        T Update(string id, TDto updatedData);
        bool Delete(string id);

    }
}

