using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingFactory
{
    class Helper
    {
        public static FurnitureEntities furnitureEntities;
        public static FurnitureEntities GetContext()
        {
            if (furnitureEntities == null)
            {
                furnitureEntities = new FurnitureEntities();
            }
            return furnitureEntities;
        }
    }
}
