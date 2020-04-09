using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternHTML
{
    class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        private int indentSize = 2;
        public List<HtmlElement> Elements = new List<HtmlElement>();

        public HtmlElement()
        {

        }
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        private string ToStringBuilder(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }

            foreach (var e in Elements)
                sb.Append(e.ToStringBuilder(indent + 1));

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringBuilder(0);
        }
    }
}
