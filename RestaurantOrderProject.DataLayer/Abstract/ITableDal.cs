using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DataAccessLayer.Abstract
{
	public interface ITableDal : IGenericDal<Table>
	{
		int MenuTableCount();
	}
}
