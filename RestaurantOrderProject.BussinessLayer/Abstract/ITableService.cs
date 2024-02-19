using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.BussinessLayer.Abstract
{
	public interface ITableService : IGenericService<Table>
	{
		int TMenuTableCount();
	}
}
