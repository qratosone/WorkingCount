using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WorkingCount
{
    class Analysis
    {
        public string input;
        public int count_read=0, count_choice=0, count_code=0;
        public void GetCount()
        {
            
            string[] ContentLines = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in ContentLines)
            {
                if (line.StartsWith("####"))
                {
                    continue;
                }
                string[] Elements = line.Split('|');
                if (Elements[1]=="阅读")
                {
                    count_read++;
                }
                else if (Elements[1]=="选择")
                {
                    count_choice++;
                }
                else if (Elements[1]=="伴随")
                {
                    count_code++;
                }
                
            }
        }
    }
}
