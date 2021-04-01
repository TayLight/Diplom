using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зачетное_задание_Евтушевская
{
    class Word
    {
        private string slovo;
        private string translate;

        public Word(string slovo, string translate)
        {
            this.Slovo = slovo;
            this.translate = translate;
        }

        public string Translate { get => translate; set => translate = value; }
        public string Slovo { get => slovo; set => slovo = value; }
    }
}
