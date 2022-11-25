using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8CS
{
    public class FileArray
    {
        public List<Int32> Arr { get; private set; }
        public int Length { get; private set; }

        public FileArray()
        {
            Arr = new List<Int32>();
            Length = 0;
        }

        public void Show(TextBox textBox)
        {
            textBox.Text = String.Empty;
            for (int i = 0; i < Length; i++)
            {
                textBox.AppendText(Arr[i].ToString());
                textBox.AppendText(" ");
            }
        }

        public void ReadArray(string fileName)
        {
            int i = 0;
            using (var sr = new StreamReader(fileName, System.Text.Encoding.Default))
            {
                string? line;
                while (!String.IsNullOrEmpty(line = sr.ReadLine()))
                {
                    Arr.Add(Convert.ToInt32(line));
                    i++;
                }
            }
            Length = i;
        }

        public void DoSomething()
        {
            var orderedList = new List<Int32>();
            for (int i = 0; i < Length; i++)
            {
                if (Arr[i] % 2 != 0)
                {
                    orderedList.Add(Arr[i]);
                }
            }
            for (int j = 0; j < Length; j++)
            {
                if (Arr[j] % 2 == 0)
                {
                    orderedList.Add(Arr[j]);
                }
            }
            Arr = orderedList;
        }

        public void WriteArray(string fileName)
        {
            using(var sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                for (int i=0; i < Length; i++)
                {
                    sw.WriteLine(Arr[i].ToString());
                }
            }
        }
    }
}
