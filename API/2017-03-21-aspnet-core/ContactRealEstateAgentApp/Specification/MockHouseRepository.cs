using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Specification
{
	internal class MockHouseRepository : IHouseRepository
	{
		House currentHouse;

		public MockHouseRepository(House currentHouse)
		{
			this.currentHouse = currentHouse;
		}

		public House GetHouse(Guid houseId)
		{
			if (houseId == currentHouse.Id)
			{
				return this.currentHouse;
			}

			return null;
		}
	}
}
