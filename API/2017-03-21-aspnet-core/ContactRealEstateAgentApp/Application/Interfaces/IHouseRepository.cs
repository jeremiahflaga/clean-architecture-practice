using Domain;
using System;

namespace Application.Interfaces
{
	public interface IHouseRepository
	{
		House GetHouse(Guid houseId);
	}
}
