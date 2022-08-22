using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator
{
    internal class Presentation
    {
        Model model = null;
        MainWindow main = null;
        public Presentation(MainWindow main)
        {
            model = new Model();
            this.main = main;
            this.main.Plus += new EventHandler(Plus);
            this.main.Minus += new EventHandler(Minus);
            this.main.Multi += new EventHandler(Multi);
            this.main.Delit += new EventHandler(Delit);
        }

        private void Delit(object sender, EventArgs e)
        {
            string s = "/";
            main.result.Text = model.Result(main.firstvalue.Text, main.secondvalue.Text, s);
        }

        private void Multi(object sender, EventArgs e)
        {
            string s = "*";
            main.result.Text = model.Result(main.firstvalue.Text, main.secondvalue.Text, s);
        }

        private void Minus(object sender, EventArgs e)
        {
            string s = "-";
            main.result.Text = model.Result(main.firstvalue.Text, main.secondvalue.Text, s);
        }

        private void Plus(object sender, EventArgs e)
        {
            string s = "+";
            main.result.Text = model.Result(main.firstvalue.Text, main.secondvalue.Text, s);
        }
    }
}
