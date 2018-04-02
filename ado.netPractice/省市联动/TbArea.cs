using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 省市联动
{
    class TbArea
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int AreaPId { get; set; }
        public override string ToString()
        {
            return this.AreaName;
        }
    }
}
