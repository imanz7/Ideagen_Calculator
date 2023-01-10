using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Calc : Form
    {
        public string sum;
        public string operation;
        public string[] number;
        public int sort;
        public string total;
        public string errorDetail;

        public Calc()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Input.Text = " ";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                errorDetail = null;
                sum = Input.Text;

                //var acceptableOperators = "+ - x / ( )".Split();
                //if (!acceptableOperators.Contains(sum))
                if (sum.Contains(" "))
                {
                    // test regex  
                    string[] digits = Regex.Split(sum, @"\s*([-+/*()])\s*");
                    List<String> tag = new List<string>(digits);
                    //List<String> tag = new List<string>(sum.Split(' '));

                    tag.RemoveAll(s => string.IsNullOrWhiteSpace(s));

                    var bracket = tag.Where(stringToCheck => stringToCheck.Contains("(")).Count();
                    Console.WriteLine("count: " + bracket);

                    while (tag.Contains("("))
                    {
                        tag = FirstBracket(tag);
                    }

                    while (tag.Contains("*") || tag.Contains("/"))
                    {
                        tag = MulDiv(tag);
                    }

                    tag = AddSub(tag);

                    Console.WriteLine("-----------");
                    total = string.Concat(tag);

                    if (errorDetail != null)
                        MessageBox.Show("Input cannot be 0. \nError: ");
                    else
                        MessageBox.Show(total);

                }
                else
                    MessageBox.Show("Please ensure numbers, operators and brackets are all separated by spaces");
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private List<String> FirstBracket(List<String> tag)
        {
            List<String> sorted = new List<string>();
            var index = tag.FindLastIndex(a => a == "(");
            var start = index;
            var stop = tag.FindIndex(a => a == ")");
            var range = stop - index + 1;

            /*List<string> sorted = tag.SkipWhile((value, ind) => ind < index && ind < stop).ToList();
            Console.WriteLine("*******");
            foreach (string amount in sorted)
            {
                Console.WriteLine(amount);
            }*/
            
            while (index <= stop)
            {
                sorted.Add(tag[index]);
                index++;
            }

            tag.RemoveRange(start, range);                  

            while (sorted.Contains("*") || sorted.Contains("/"))
            {
                sorted = MulDiv(sorted);
            }
            
            sorted = AddSub(sorted);
            tag.Insert(start, sorted[0]);
            return tag;
        }

        private List<String> MulDiv(List<String> sorted)
        {
            for(var i = 0; i < sorted.Count; i++)
            {
                if (sorted[i] == "*")
                {
                    var temp = Convert.ToDouble(sorted[i - 1]) * Convert.ToDouble(sorted[i + 1]);
                    sorted[i - 1] = temp.ToString();
                    sorted.RemoveRange(i, 2);
                    i = 0;
                }

                else if (sorted[i] == "/")
                {
                    if(Convert.ToDouble(sorted[i + 1]) != 0)
                    {
                        var temp = Convert.ToDouble(sorted[i - 1]) / Convert.ToDouble(sorted[i + 1]);
                        sorted[i - 1] = temp.ToString();
                        sorted.RemoveRange(i, 2);
                        i = 0;
                    }
                    else
                    {
                        errorDetail = "Input cannot be 0. \nError: ";
                        sorted.Clear();
                    }
                    
                }
                else if (sorted[i] == ")" || sorted[i] == "(")
                    sorted.RemoveRange(i, 1);              
            }

            return sorted;
        }

        private List<String> AddSub(List<String> sorted)
        {
            for (var i = 0; i < sorted.Count; i++)
            {
                if (sorted[i] == "+")
                {
                    var temp = Convert.ToDouble(sorted[i - 1]) + Convert.ToDouble(sorted[i + 1]);
                    sorted[i - 1] = temp.ToString();
                    sorted.RemoveRange(i, 2);
                    i = 0;
                }

                else if (sorted[i] == "-")
                {
                    var temp = Convert.ToDouble(sorted[i - 1]) - Convert.ToDouble(sorted[i + 1]);
                    sorted[i - 1] = temp.ToString();
                    sorted.RemoveRange(i, 2);
                    i = 0;
                }
                else if (sorted[i] == ")" || sorted[i] == "(")
                    sorted.RemoveRange(i, 1);
            }          
            
            return sorted;
        }
    }
}
