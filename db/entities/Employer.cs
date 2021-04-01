using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачетное_задание_Евтушевская.db.entities
{
    class Employer : IEntity
    {
        public string Table { get; set; }

        public int Count { get; set; }

        public List<string> Columns { get; set; }

        public List<string> Values { get; set; }

        public List<string> GetValuesList()
        {
            List<string> list = new List<string>();
            list.Add(this.Id);
            return list;
        }

        public string Id { get; set; }

        public int IdValue { get; set; }

        public string fio { get; set; }

        public DateTime birtday { get; set; }

        public string gender { get; set; }

        public int height { get; set; }

        public int weight { get; set; }

        public int headSize { get; set; }

        public int healthCategory { get; set; }

        public int shoeSize { get; set; }

        public Employer()
        {
            Table = "employers";
            Count = 9;
            Columns.Add("id");
            Columns.Add("fio");
            Columns.Add("birthday");
            Columns.Add("gender");
            Columns.Add("height");
            Columns.Add("weight");
            Columns.Add("head_size");
            Columns.Add("health_category");
            Columns.Add("shoe_size");
        }

        public Employer(string id, string fio, DateTime birtday, string gender, int height, int weight, int headSize, int healthCategory, int shoeSize)
        {
            Id = id;
            this.fio = fio;
            this.birtday = birtday;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.headSize = headSize;
            this.healthCategory = healthCategory;
            this.shoeSize = shoeSize;
        }

        public Employer(string fio, DateTime birtday, string gender, int height, int weight, int headSize, int healthCategory, int shoeSize)
        {
            this.fio = fio;
            this.birtday = birtday;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.headSize = headSize;
            this.healthCategory = healthCategory;
            this.shoeSize = shoeSize;
        }


    }
}
