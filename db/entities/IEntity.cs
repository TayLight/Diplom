using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зачетное_задание_Евтушевская.db.entities
{
    interface IEntity
    {
        string Table { get; set; }

        int Count { get; set; }

        List<string> Columns { get; set; }

        List<string> Values { set; }

        string Id { get; set; }

        int IdValue { get; set; }
    }
}
